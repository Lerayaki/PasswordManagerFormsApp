using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagerFormsApp
{
    static class Program
    {
        public static PasswordManager PasswordManager;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //rfc2898test rfc = new rfc2898test("mypasword");


            PasswordManager = new PasswordManager();
            PasswordManager.GenerateRandomPassword();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
