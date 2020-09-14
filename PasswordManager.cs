using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.Xml;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.Win32;
using Liphsoft.Crypto.Argon2;
using System.Security;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;
using System.Diagnostics;
//using static System.Collections.Generic.Dictionary<TKey, TValue>;

namespace PasswordManagerFormsApp
{
    public class PasswordManager
    {
        [Serializable]
        public class PasswordManagerData
        {
            public Dictionary<KeyValuePair<string, string>, string> Values;
            public PasswordManagerData()
            {
                Values = new Dictionary<KeyValuePair<string, string>, string>();
            }
            public string this[KeyValuePair<string, string> key] 
            {
                get
                {
                    return Values[key];
                }
                set
                {
                    Values[key] = value;
                } 
            }
            public List<KeyValuePair<string,string>> Keys
            {
                get
                {
                    return Values.Keys.ToList();
                }
            }
            public void Remove(KeyValuePair<string, string> key)
            {
                Values.Remove(key);
            }

        }
        private static readonly string RegistryPath = @"Software\LPWM\1.0";
        private string HashedPassword = string.Empty;
        private byte[] Salt;
        private byte[] IV;
        private static readonly string Path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.LPWM";
        private static readonly string DataFile = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.LPWM\\data.dat";
        private Rfc2898DeriveBytes K;
        private PasswordHasher Hasher;
        private PasswordManagerData Data;
        private Stopwatch Timer;
        public PasswordManager()
        {
            Hasher = new PasswordHasher();
            Data = new PasswordManagerData();
            Timer = new Stopwatch();
            Timer.Start();
            IV = new byte[8];
            Salt = new byte[8];
            DirectoryInfo dir = Directory.CreateDirectory(Path);
            dir.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            if (!File.Exists(DataFile))
                using (File.Create(DataFile)) { }
            InitializeRegistry();
        }
        private void InitializeRegistry()
        {
            if (Registry.CurrentUser.OpenSubKey(RegistryPath) == null || Registry.CurrentUser.OpenSubKey(RegistryPath).GetValue("Base") == null 
                || Registry.CurrentUser.OpenSubKey(RegistryPath).GetValue("Mode") == null || Registry.CurrentUser.OpenSubKey(RegistryPath).GetValue("Main") == null )
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
                using (RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider())
                {
                    rngCsp.GetBytes(Salt);
                    rngCsp.GetBytes(IV);
                }

                key.CreateSubKey("LPWM");
                key = key.OpenSubKey("LPWM", true);

                key.CreateSubKey("1.0");
                key = key.OpenSubKey("1.0", true);

                key.SetValue("Main", "");
                key.SetValue("Base", Salt);
                key.SetValue("Mode", IV);
            }
        }
        public void WriteToRegistry()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath, true);

            key.SetValue("Main", HashedPassword);
            key.SetValue("Base", Salt);
            key.SetValue("Mode", IV);
        }
        public bool ReadFromRegistry()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath, false);

            HashedPassword = (string)key.GetValue("Main");
            Salt = (byte[])key.GetValue("Base");
            IV = (byte[])key.GetValue("Mode");

            return !(string.IsNullOrEmpty(HashedPassword) || Salt.Length == 0 || IV.Length == 0);
        }
        private byte[] Encrypt(string plainText)
        {
            TripleDES encAlg = TripleDES.Create();
            encAlg.Key = K.GetBytes(16);
            IV = encAlg.IV;
            MemoryStream encryptionStream = new MemoryStream();
            CryptoStream encrypt = new CryptoStream(encryptionStream, encAlg.CreateEncryptor(), CryptoStreamMode.Write);
            byte[] utfD1 = UnicodeEncoding.Unicode.GetBytes(plainText);

            encrypt.Write(utfD1, 0, utfD1.Length);
            encrypt.FlushFinalBlock();
            encrypt.Close();

            K.Reset();
            return encryptionStream.ToArray();
        }
        private string Decrypt(byte[] encryptedText)
        {
            TripleDES decAlg = TripleDES.Create();
            decAlg.Key = K.GetBytes(16);
            decAlg.IV = IV;
            MemoryStream decryptionStreamBacking = new MemoryStream();
            using (CryptoStream decrypt = new CryptoStream(decryptionStreamBacking, decAlg.CreateDecryptor(), CryptoStreamMode.Write))
            {
                decrypt.Write(encryptedText, 0, encryptedText.Length);
                decrypt.FlushFinalBlock();
            }

            K.Reset();
            return UnicodeEncoding.Unicode.GetString(decryptionStreamBacking.ToArray());
        }
        public void CreateNewEntry(string domain, string userId, string password)
        {
            Data[new KeyValuePair<string, string>(domain, userId)] = password;
            WriteDataFile();
            WriteToRegistry();
        }
        public string GetPassword(string domain, string userId)
        {
            return Data[new KeyValuePair<string, string>(domain, userId)];
        }
        public void RemoveEntry(string domain, string userId)
        {
            Data.Remove(new KeyValuePair<string, string>(domain, userId));
        }
        public List<KeyValuePair<string,string>> GetEntries()
        {
            return Data.Keys.ToList();
        }
        public void CopyPasswordToClipboard(string domain, string userId)
        {
            try
            {
                System.Windows.Forms.Clipboard.SetText(Data[new KeyValuePair<string, string>(domain, userId)]);
            }
            catch (Exception)
            {

            }
        }
        public void CopyPasswordToClipboard(KeyValuePair<string,string> key)
        {
            try
            {
                System.Windows.Forms.Clipboard.SetText(Data[key]);
            }
            catch (Exception)
            {

            }
        }
        public string GenerateRandomPassword()
        {
            char[] passwordChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789{}[]-_$!%&()=*<>@|#?+<>".ToCharArray();
            string password = string.Empty;
            double[] log = new double[32];

            for (int i=0; i<32; i++)
            {
                log[i] = Timer.Elapsed.TotalMilliseconds * 1000;
                Random rng = new Random((int)log[i]);
                int n = rng.Next(0, passwordChars.Length);

                password += passwordChars[n];
            }
            return password;
        }
        public bool CheckPassword(string password)
        {
            if (!Hasher.Verify(HashedPassword, password))
                return false;

            HashedPassword = Hasher.Hash(password);
            K = new Rfc2898DeriveBytes(password, Salt, 10000);
            WriteToRegistry();
            ReadDataFile();
            return true;
        }
        public void SetNewPassword(string password)
        {
            HashedPassword = Hasher.Hash(password);
            K = new Rfc2898DeriveBytes(password, Salt, 10000);
        }
        public void Close()
        {
            WriteDataFile();
            WriteToRegistry();
        }
        public bool IsSafePassword(string pw)
        {
            if (!(pw.Length >= 10)) return false;

            bool lowerCase = false;
            bool upperCase = false;
            bool digit = false;

            foreach (char c in pw)
            {
                if (Char.IsDigit(c))
                {
                    digit = true;
                }
                if (Char.IsLower(c))
                {
                    lowerCase = true;
                }
                if (Char.IsUpper(c))
                {
                    upperCase = true;
                }
            }

            if (lowerCase && upperCase && digit) return true;
            return false;
        } 
        private void WriteDataFile()
        {
            var fileStream = new FileStream(DataFile, FileMode.Create);
            var binaryFormatter = new BinaryFormatter();
            string str;
            MemoryStream memStream = new MemoryStream(100);
            binaryFormatter.Serialize(memStream, Data);
            str = Convert.ToBase64String(memStream.ToArray());
            binaryFormatter.Serialize(fileStream, Encrypt(str));
            fileStream.Close();
            memStream.Close();
        }
        private void ReadDataFile()
        {
            var fileStream = new FileStream(DataFile, FileMode.Open);
            var binaryFormatter = new BinaryFormatter();
            byte[] bytes = (byte[])binaryFormatter.Deserialize(fileStream);
            string str = Decrypt(bytes);
            bytes = Convert.FromBase64String(str);
            MemoryStream memStream = new MemoryStream(bytes);
            Data = (PasswordManagerData)binaryFormatter.Deserialize(memStream);
            fileStream.Close();
            memStream.Close();
        }
    }
}
