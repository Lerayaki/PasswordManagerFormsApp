using System;
using System.Linq;

namespace PasswordManagerFormsApp
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.SuspendLayout();
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PasswordManagerFormsApp.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordManager";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private void FormMain_Load(object sender, EventArgs e)
        {
            UserControlStart userControlStart = new UserControlStart();
            UserControlPasswordRequest userControlPasswordRequest = new UserControlPasswordRequest();
            UserControlSetNewPassword userControlSetNewPassword = new UserControlSetNewPassword();
            UserControlMain userControlMain = new UserControlMain();

            userControlStart.Dock = System.Windows.Forms.DockStyle.Fill;
            userControlPasswordRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            userControlSetNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            userControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            
            Controls.Add(userControlPasswordRequest);
            Controls.Add(userControlSetNewPassword);
            Controls.Add(userControlMain);
            Controls.Add(userControlStart);

            Controls["UserControlMain"].Visible = false;
            Controls["UserControlSetNewPassword"].Visible = false;
            Controls["UserControlPasswordRequest"].Visible = false;
            Controls["UserControlStart"].Visible = true;
        }
    }
}