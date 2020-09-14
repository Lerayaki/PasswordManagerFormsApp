using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;

namespace PasswordManagerFormsApp
{
    partial class UserControlMain
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBottomButtons = new System.Windows.Forms.TableLayoutPanel();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonCreateNewEntry = new System.Windows.Forms.Button();
            this.buttonCloseManager = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanelWarning = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanelEntryList = new System.Windows.Forms.TableLayoutPanel();
            this.labelDomainName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxNewDomain = new System.Windows.Forms.TextBox();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxReenterPassword = new System.Windows.Forms.TextBox();
            this.buttonRemoveEntry = new System.Windows.Forms.Button();
            this.buttonAddEntry = new System.Windows.Forms.Button();
            this.tableLayoutPanelPassword = new System.Windows.Forms.TableLayoutPanel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.pictureBoxCopy = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelBottomButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelWarning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanelEntryList.SuspendLayout();
            this.tableLayoutPanelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelBottomButtons, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanelBottomButtons
            // 
            this.tableLayoutPanelBottomButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelBottomButtons.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelBottomButtons.ColumnCount = 3;
            this.tableLayoutPanelBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelBottomButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelBottomButtons.Controls.Add(this.buttonChangePassword, 0, 0);
            this.tableLayoutPanelBottomButtons.Controls.Add(this.buttonCreateNewEntry, 1, 0);
            this.tableLayoutPanelBottomButtons.Controls.Add(this.buttonCloseManager, 2, 0);
            this.tableLayoutPanelBottomButtons.Location = new System.Drawing.Point(230, 580);
            this.tableLayoutPanelBottomButtons.Name = "tableLayoutPanelBottomButtons";
            this.tableLayoutPanelBottomButtons.RowCount = 1;
            this.tableLayoutPanelBottomButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBottomButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelBottomButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelBottomButtons.Size = new System.Drawing.Size(539, 100);
            this.tableLayoutPanelBottomButtons.TabIndex = 0;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChangePassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.Location = new System.Drawing.Point(19, 28);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(141, 43);
            this.buttonChangePassword.TabIndex = 0;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonCreateNewEntry
            // 
            this.buttonCreateNewEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreateNewEntry.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateNewEntry.Location = new System.Drawing.Point(198, 28);
            this.buttonCreateNewEntry.Name = "buttonCreateNewEntry";
            this.buttonCreateNewEntry.Size = new System.Drawing.Size(141, 43);
            this.buttonCreateNewEntry.TabIndex = 1;
            this.buttonCreateNewEntry.Text = "Create New Entry";
            this.buttonCreateNewEntry.UseVisualStyleBackColor = true;
            // 
            // buttonCloseManager
            // 
            this.buttonCloseManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCloseManager.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseManager.Location = new System.Drawing.Point(378, 28);
            this.buttonCloseManager.Name = "buttonCloseManager";
            this.buttonCloseManager.Size = new System.Drawing.Size(141, 43);
            this.buttonCloseManager.TabIndex = 2;
            this.buttonCloseManager.Text = "Close Manager";
            this.buttonCloseManager.UseVisualStyleBackColor = true;
            this.buttonCloseManager.Click += new System.EventHandler(this.buttonCloseManager_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.tableLayoutPanelWarning);
            this.panel1.Controls.Add(this.tableLayoutPanelEntryList);
            this.panel1.Location = new System.Drawing.Point(75, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 499);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanelWarning
            // 
            this.tableLayoutPanelWarning.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanelWarning.ColumnCount = 2;
            this.tableLayoutPanelWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelWarning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWarning.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanelWarning.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanelWarning.Location = new System.Drawing.Point(248, 226);
            this.tableLayoutPanelWarning.Name = "tableLayoutPanelWarning";
            this.tableLayoutPanelWarning.RowCount = 1;
            this.tableLayoutPanelWarning.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelWarning.Size = new System.Drawing.Size(390, 60);
            this.tableLayoutPanelWarning.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PasswordManagerFormsApp.Properties.Resources.icons8_warning_48;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 54);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Currently there are no passwords being stored.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tableLayoutPanelEntryList
            // 
            this.tableLayoutPanelEntryList.AutoSize = true;
            this.tableLayoutPanelEntryList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelEntryList.ColumnCount = 5;
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelEntryList.Controls.Add(this.labelDomainName, 0, 0);
            this.tableLayoutPanelEntryList.Controls.Add(this.labelUsername, 1, 0);
            this.tableLayoutPanelEntryList.Controls.Add(this.textBoxNewDomain, 0, 1);
            this.tableLayoutPanelEntryList.Controls.Add(this.textBoxNewUsername, 1, 1);
            this.tableLayoutPanelEntryList.Controls.Add(this.textBoxNewPassword, 2, 1);
            this.tableLayoutPanelEntryList.Controls.Add(this.textBoxReenterPassword, 3, 1);
            this.tableLayoutPanelEntryList.Controls.Add(this.buttonRemoveEntry, 4, 0);
            this.tableLayoutPanelEntryList.Controls.Add(this.buttonAddEntry, 4, 1);
            this.tableLayoutPanelEntryList.Controls.Add(this.tableLayoutPanelPassword, 2, 0);
            this.tableLayoutPanelEntryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelEntryList.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelEntryList.Name = "tableLayoutPanelEntryList";
            this.tableLayoutPanelEntryList.RowCount = 2;
            this.tableLayoutPanelEntryList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelEntryList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelEntryList.Size = new System.Drawing.Size(850, 60);
            this.tableLayoutPanelEntryList.TabIndex = 0;
            this.tableLayoutPanelEntryList.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelEntryList_Paint);
            // 
            // labelDomainName
            // 
            this.labelDomainName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDomainName.AutoSize = true;
            this.labelDomainName.Location = new System.Drawing.Point(68, 8);
            this.labelDomainName.Name = "labelDomainName";
            this.labelDomainName.Size = new System.Drawing.Size(53, 13);
            this.labelDomainName.TabIndex = 0;
            this.labelDomainName.Text = "appName";
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(248, 8);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "accountName";
            // 
            // textBoxNewDomain
            // 
            this.textBoxNewDomain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewDomain.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNewDomain.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewDomain.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNewDomain.Location = new System.Drawing.Point(3, 35);
            this.textBoxNewDomain.Name = "textBoxNewDomain";
            this.textBoxNewDomain.Size = new System.Drawing.Size(184, 20);
            this.textBoxNewDomain.TabIndex = 5;
            this.textBoxNewDomain.Text = "sdghf...";
            this.textBoxNewDomain.Enter += new System.EventHandler(this.textBoxNewDomain_Enter);
            this.textBoxNewDomain.Leave += new System.EventHandler(this.textBoxNewDomain_Leave);
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewUsername.Location = new System.Drawing.Point(193, 35);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(184, 20);
            this.textBoxNewUsername.TabIndex = 6;
            this.textBoxNewUsername.Text = "sdghf...";
            this.textBoxNewUsername.Enter += new System.EventHandler(this.textBoxNewUsername_Enter);
            this.textBoxNewUsername.Leave += new System.EventHandler(this.textBoxNewUsername_Leave);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNewPassword.Location = new System.Drawing.Point(383, 35);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(184, 20);
            this.textBoxNewPassword.TabIndex = 7;
            this.textBoxNewPassword.Text = "sdghf...";
            this.textBoxNewPassword.Enter += new System.EventHandler(this.textBoxNewPassword_Enter);
            this.textBoxNewPassword.Leave += new System.EventHandler(this.textBoxNewPassword_Leave);
            // 
            // textBoxReenterPassword
            // 
            this.textBoxReenterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxReenterPassword.Location = new System.Drawing.Point(573, 35);
            this.textBoxReenterPassword.Name = "textBoxReenterPassword";
            this.textBoxReenterPassword.Size = new System.Drawing.Size(184, 20);
            this.textBoxReenterPassword.TabIndex = 10;
            this.textBoxReenterPassword.Text = "sfgsdgf...";
            this.textBoxReenterPassword.Enter += new System.EventHandler(this.textBoxReenterPassword_Enter);
            this.textBoxReenterPassword.Leave += new System.EventHandler(this.textBoxReenterPassword_Leave);
            // 
            // buttonRemoveEntry
            // 
            this.buttonRemoveEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRemoveEntry.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveEntry.Location = new System.Drawing.Point(763, 3);
            this.buttonRemoveEntry.Name = "buttonRemoveEntry";
            this.buttonRemoveEntry.Size = new System.Drawing.Size(83, 23);
            this.buttonRemoveEntry.TabIndex = 9;
            this.buttonRemoveEntry.Text = "Remove";
            this.buttonRemoveEntry.UseVisualStyleBackColor = true;
            // 
            // buttonAddEntry
            // 
            this.buttonAddEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddEntry.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEntry.Location = new System.Drawing.Point(763, 33);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new System.Drawing.Size(83, 23);
            this.buttonAddEntry.TabIndex = 8;
            this.buttonAddEntry.Text = "Add";
            this.buttonAddEntry.UseVisualStyleBackColor = true;
            this.buttonAddEntry.Click += new System.EventHandler(this.buttonAddEntry_Click);
            // 
            // tableLayoutPanelPassword
            // 
            this.tableLayoutPanelPassword.ColumnCount = 3;
            this.tableLayoutPanelEntryList.SetColumnSpan(this.tableLayoutPanelPassword, 2);
            this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelPassword.Controls.Add(this.labelPassword, 0, 0);
            this.tableLayoutPanelPassword.Controls.Add(this.pictureBoxShow, 1, 0);
            this.tableLayoutPanelPassword.Controls.Add(this.pictureBoxCopy, 2, 0);
            this.tableLayoutPanelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPassword.Location = new System.Drawing.Point(383, 3);
            this.tableLayoutPanelPassword.Name = "tableLayoutPanelPassword";
            this.tableLayoutPanelPassword.RowCount = 1;
            this.tableLayoutPanelPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPassword.Size = new System.Drawing.Size(374, 24);
            this.tableLayoutPanelPassword.TabIndex = 11;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(128, 5);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(58, 13);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "password?";
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShow.Image = global::PasswordManagerFormsApp.Properties.Resources.eye1;
            this.pictureBoxShow.Location = new System.Drawing.Point(317, 3);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(24, 18);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 3;
            this.pictureBoxShow.TabStop = false;
            // 
            // pictureBoxCopy
            // 
            this.pictureBoxCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCopy.Image = global::PasswordManagerFormsApp.Properties.Resources.copy;
            this.pictureBoxCopy.Location = new System.Drawing.Point(347, 3);
            this.pictureBoxCopy.Name = "pictureBoxCopy";
            this.pictureBoxCopy.Size = new System.Drawing.Size(24, 18);
            this.pictureBoxCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCopy.TabIndex = 4;
            this.pictureBoxCopy.TabStop = false;
            // 
            // UserControlMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserControlMain";
            this.Size = new System.Drawing.Size(1000, 700);
            this.VisibleChanged += new System.EventHandler(this.UserControlMain_VisibleChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelBottomButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelWarning.ResumeLayout(false);
            this.tableLayoutPanelWarning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanelEntryList.ResumeLayout(false);
            this.tableLayoutPanelEntryList.PerformLayout();
            this.tableLayoutPanelPassword.ResumeLayout(false);
            this.tableLayoutPanelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void buttonCreateNewEntry_Click(object sender, EventArgs e)
        {
            Parent.Controls["UserControlCreateNewEntry"].BringToFront();
        }
        private void buttonCloseManager_Click(object sender, EventArgs e)
        {
            Program.PasswordManager.Close();
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            //TODO userControlChangePassword UserControl implementar
            //this.Visible = false;
            //Parent.Controls["UserControlChangePassword"].Visible = true;
        }
        private void UserControlMain_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                tableLayoutPanelEntryList_Refresh();

                this.textBoxNewDomain.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxNewUsername.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxNewPassword.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxReenterPassword.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                this.textBoxNewDomain.ForeColor = System.Drawing.Color.Gray;
                this.textBoxNewUsername.ForeColor = System.Drawing.Color.Gray;
                this.textBoxNewPassword.ForeColor = System.Drawing.Color.Gray;
                this.textBoxReenterPassword.ForeColor = System.Drawing.Color.Gray;

                textBoxNewDomain.Text = "Enter domain name...";
                textBoxNewUsername.Text = "Enter username...";
                textBoxNewPassword.Text = "Enter password...";
                textBoxReenterPassword.Text = "Reenter password...";
            }
        }

        private void textBoxNewDomain_Enter(object sender, EventArgs e)
        {
            if (textBoxNewDomain.Text == "Enter domain name...")
            {
                this.textBoxNewDomain.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxNewDomain.ForeColor = System.Drawing.SystemColors.ControlText;
                textBoxNewDomain.Text = "";
            }
        }

        private void textBoxNewDomain_Leave(object sender, EventArgs e)
        {
            if (textBoxNewDomain.Text == "")
            {
                this.textBoxNewDomain.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxNewDomain.ForeColor = System.Drawing.Color.Gray;
                textBoxNewDomain.Text = "Enter domain name...";
            }
        }
        private void textBoxNewUsername_Enter(object sender, EventArgs e)
        {
            if (textBoxNewUsername.Text == "Enter username...")
            {
                this.textBoxNewUsername.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxNewUsername.ForeColor = System.Drawing.SystemColors.ControlText;
                textBoxNewUsername.Text = "";
            }
        }

        private void textBoxNewUsername_Leave(object sender, EventArgs e)
        {
            if (textBoxNewUsername.Text == "")
            {
                this.textBoxNewUsername.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxNewUsername.ForeColor = System.Drawing.Color.Gray;
                textBoxNewUsername.Text = "Enter username...";
            }
        }
        private void textBoxNewPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "Enter password...")
            {
                this.textBoxNewPassword.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxNewPassword.ForeColor = System.Drawing.SystemColors.ControlText;
                this.textBoxNewPassword.UseSystemPasswordChar = true;
                textBoxNewPassword.Text = "";
            }
        }

        private void textBoxNewPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
            {
                this.textBoxNewPassword.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxNewPassword.ForeColor = System.Drawing.Color.Gray;
                this.textBoxNewPassword.UseSystemPasswordChar = false;
                textBoxNewPassword.Text = "Enter password...";
            }
        }
        private void textBoxReenterPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxReenterPassword.Text == "Reenter password...")
            {
                this.textBoxReenterPassword.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxReenterPassword.ForeColor = System.Drawing.SystemColors.ControlText;
                this.textBoxReenterPassword.UseSystemPasswordChar = true;
                textBoxReenterPassword.Text = "";
            }
        }

        private void textBoxReenterPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxReenterPassword.Text == "")
            {
                this.textBoxReenterPassword.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.textBoxReenterPassword.ForeColor = System.Drawing.Color.Gray;
                this.textBoxReenterPassword.UseSystemPasswordChar = false;
                textBoxReenterPassword.Text = "Reenter password...";
            }
        }

        public void tableLayoutPanelEntryList_Refresh()
        {
            var entryList = Program.PasswordManager.GetEntries();

            this.tableLayoutPanelEntryList.Controls.Clear();
            this.tableLayoutPanelPassword.Controls.Clear();
            this.tableLayoutPanelEntryList.AutoSize = true;
            this.tableLayoutPanelEntryList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelEntryList.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelEntryList.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelEntryList.Name = "tableLayoutPanelEntryList";
            this.tableLayoutPanelEntryList.ColumnCount = 5;
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelEntryList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelEntryList.RowCount = 0;

            if (entryList.Count > 0)
            {
                this.labelListDomainName = new List<System.Windows.Forms.Label>();
                this.labelListUsername = new List<System.Windows.Forms.Label>();
                this.labelListPassword = new List<System.Windows.Forms.Label>();
                this.tableLayoutPanelListPassword = new List<System.Windows.Forms.TableLayoutPanel>();
                this.buttonRemoveListEntry = new List<System.Windows.Forms.Button>();
                this.pictureBoxListShow = new List<System.Windows.Forms.PictureBox>();

                tableLayoutPanelWarning.Visible = false;
                foreach (var entry in entryList)
                {
                    this.labelDomainName = new System.Windows.Forms.Label();
                    this.labelUsername = new System.Windows.Forms.Label();
                    this.labelPassword = new System.Windows.Forms.Label();
                    this.buttonRemoveEntry = new System.Windows.Forms.Button();
                    this.tableLayoutPanelPassword = new System.Windows.Forms.TableLayoutPanel();
                    this.pictureBoxShow = new System.Windows.Forms.PictureBox();
                    this.pictureBoxCopy = new System.Windows.Forms.PictureBox();
                    // 
                    // labelDomainName
                    // 
                    this.labelDomainName.Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.labelDomainName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.labelDomainName.AutoSize = true;
                    this.labelDomainName.Location = new System.Drawing.Point(58, 8);
                    this.labelDomainName.Name = "labelDomainName_" + this.tableLayoutPanelEntryList.RowCount;
                    this.labelDomainName.Size = new System.Drawing.Size(53, 13);
                    this.labelDomainName.TabIndex = 0;
                    this.labelDomainName.Text = entry.Key;
                    // 
                    // labelUsername
                    // 
                    this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.labelUsername.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.labelUsername.AutoSize = true;
                    this.labelUsername.Location = new System.Drawing.Point(218, 8);
                    this.labelUsername.Name = "labelUsername_" + this.tableLayoutPanelEntryList.RowCount;
                    this.labelUsername.Size = new System.Drawing.Size(74, 13);
                    this.labelUsername.TabIndex = 1;
                    this.labelUsername.Text = entry.Value;
                    // 
                    // labelPassword
                    // 
                    this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.labelPassword.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.labelPassword.AutoSize = true;
                    this.labelPassword.Location = new System.Drawing.Point(128, 5);
                    this.labelPassword.Name = "labelPassword_" + this.tableLayoutPanelEntryList.RowCount;
                    this.labelPassword.Size = new System.Drawing.Size(58, 13);
                    this.labelPassword.TabIndex = 2;
                    this.labelPassword.Text = "***************************************";
                    // 
                    // pictureBox2
                    // 
                    this.pictureBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.pictureBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.pictureBoxShow.Image = global::PasswordManagerFormsApp.Properties.Resources.eye;
                    this.pictureBoxShow.Location = new System.Drawing.Point(317, 3);
                    this.pictureBoxShow.Name = "Show_" + this.tableLayoutPanelEntryList.RowCount;
                    this.pictureBoxShow.Size = new System.Drawing.Size(24, 18);
                    this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.pictureBoxShow.TabIndex = 3;
                    this.pictureBoxShow.TabStop = false;
                    this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click);
                    // 
                    // pictureBox3
                    // 
                    this.pictureBoxCopy.Cursor = System.Windows.Forms.Cursors.Hand;
                    this.pictureBoxCopy.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.pictureBoxCopy.Image = global::PasswordManagerFormsApp.Properties.Resources.copy;
                    this.pictureBoxCopy.Location = new System.Drawing.Point(347, 3);
                    this.pictureBoxCopy.Name = "Copy_" + this.tableLayoutPanelEntryList.RowCount;
                    this.pictureBoxCopy.Size = new System.Drawing.Size(24, 18);
                    this.pictureBoxCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    this.pictureBoxCopy.TabIndex = 4;
                    this.pictureBoxCopy.TabStop = false;
                    this.pictureBoxCopy.Click += new System.EventHandler(this.pictureBoxCopy_Click);
                    // 
                    // tableLayoutPanelPassword
                    // 
                    this.tableLayoutPanelPassword.ColumnCount = 3;
                    this.tableLayoutPanelEntryList.SetColumnSpan(this.tableLayoutPanelPassword, 2);
                    this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
                    this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                    this.tableLayoutPanelPassword.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
                    this.tableLayoutPanelPassword.Controls.Add(this.labelPassword, 0, 0);
                    this.tableLayoutPanelPassword.Controls.Add(this.pictureBoxShow, 1, 0);
                    this.tableLayoutPanelPassword.Controls.Add(this.pictureBoxCopy, 2, 0);
                    this.tableLayoutPanelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.tableLayoutPanelPassword.Location = new System.Drawing.Point(383, 3);
                    this.tableLayoutPanelPassword.Name = "Password_" + this.tableLayoutPanelEntryList.RowCount;
                    this.tableLayoutPanelPassword.RowCount = 1;
                    this.tableLayoutPanelPassword.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
                    this.tableLayoutPanelPassword.Size = new System.Drawing.Size(374, 24);
                    this.tableLayoutPanelPassword.TabIndex = 11;
                    
                    // 
                    // buttonRemoveEntry
                    // 
                    this.buttonRemoveEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
                    this.buttonRemoveEntry.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.buttonRemoveEntry.Location = new System.Drawing.Point(723, 3);
                    this.buttonRemoveEntry.Name = "buttonRemoveEntry_" + this.tableLayoutPanelEntryList.RowCount;
                    this.buttonRemoveEntry.Size = new System.Drawing.Size(83, 23);
                    this.buttonRemoveEntry.TabIndex = 9;
                    this.buttonRemoveEntry.Text = "Remove";
                    this.buttonRemoveEntry.UseVisualStyleBackColor = true;
                    this.buttonRemoveEntry.Click += new System.EventHandler(this.buttonRemoveEntry_Click);

                    this.labelListDomainName.Add(this.labelDomainName);
                    this.labelListUsername.Add(this.labelUsername);
                    this.labelListPassword.Add(this.labelPassword);
                    this.buttonRemoveListEntry.Add(this.buttonRemoveEntry);
                    this.tableLayoutPanelListPassword.Add(this.tableLayoutPanelPassword);
                    this.pictureBoxListShow.Add(this.pictureBoxShow);

                    this.tableLayoutPanelEntryList.Controls.Add(this.labelDomainName, 0, this.tableLayoutPanelEntryList.RowCount);
                    this.tableLayoutPanelEntryList.Controls.Add(this.labelUsername, 1, this.tableLayoutPanelEntryList.RowCount);
                    this.tableLayoutPanelEntryList.Controls.Add(this.tableLayoutPanelPassword, 2, this.tableLayoutPanelEntryList.RowCount);
                    this.tableLayoutPanelEntryList.Controls.Add(this.buttonRemoveEntry, 4, this.tableLayoutPanelEntryList.RowCount);

                    this.tableLayoutPanelEntryList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));

                    this.tableLayoutPanelEntryList.RowCount++;
                }
            }
            else
            {
                tableLayoutPanelWarning.Visible = true;
            }
            this.tableLayoutPanelEntryList.Controls.Add(this.textBoxNewDomain, 0, this.tableLayoutPanelEntryList.RowCount);
            this.tableLayoutPanelEntryList.Controls.Add(this.textBoxNewUsername, 1, this.tableLayoutPanelEntryList.RowCount);
            this.tableLayoutPanelEntryList.Controls.Add(this.textBoxNewPassword, 2, this.tableLayoutPanelEntryList.RowCount);
            this.tableLayoutPanelEntryList.Controls.Add(this.textBoxReenterPassword, 3, this.tableLayoutPanelEntryList.RowCount);
            this.tableLayoutPanelEntryList.Controls.Add(this.buttonAddEntry, 4, this.tableLayoutPanelEntryList.RowCount);

            this.tableLayoutPanelEntryList.RowCount++;

            this.tableLayoutPanelEntryList.Size = new System.Drawing.Size(850, 60);
            this.tableLayoutPanelEntryList.TabIndex = 0;
        }
        private void pictureBoxCopy_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((System.Windows.Forms.PictureBox)sender).Name.Replace("Copy_", ""));
            Program.PasswordManager.CopyPasswordToClipboard(labelListDomainName.ElementAt(index).Text, labelListUsername.ElementAt(index).Text);
        }
        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((System.Windows.Forms.PictureBox)sender).Name.Replace("Show_", ""));
            if (labelListPassword.ElementAt(index).Text == "***************************************")
            {
                for (int i=0; i<pictureBoxListShow.Count; i++)
                {
                    labelListPassword.ElementAt(i).Text = "***************************************";
                    pictureBoxListShow.ElementAt(i).Image = global::PasswordManagerFormsApp.Properties.Resources.eye;
                }
                ((System.Windows.Forms.PictureBox)sender).Image = global::PasswordManagerFormsApp.Properties.Resources.hide;
                labelListPassword.ElementAt(index).Text = Program.PasswordManager.GetPassword(labelListDomainName.ElementAt(index).Text, labelListUsername.ElementAt(index).Text);
            }
            else
            {
                ((System.Windows.Forms.PictureBox)sender).Image = global::PasswordManagerFormsApp.Properties.Resources.eye;
                labelListPassword.ElementAt(index).Text = "***************************************";
            }

        }
        private void buttonRemoveEntry_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(((System.Windows.Forms.Button)sender).Name.Replace("buttonRemoveEntry_", ""));
            Program.PasswordManager.RemoveEntry(this.labelListDomainName.ElementAt(index).Text, this.labelListUsername.ElementAt(index).Text);
            this.labelListUsername.Clear();
            this.labelListPassword.Clear();
            this.labelListDomainName.Clear();
            this.buttonRemoveListEntry.Clear();
            this.tableLayoutPanelListPassword.Clear();

            //TODO ask for confirmation/password

            tableLayoutPanelEntryList_Refresh();
        }
        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            if (((textBoxNewDomain.Text != "" && textBoxNewDomain.Text != "Enter domain name...") || (textBoxNewUsername.Text != "" && textBoxNewUsername.Text != "Enter username...")))
            {
                if (textBoxNewPassword.Text != "" && textBoxNewPassword.Text != "Enter password..." && textBoxNewDomain.Text != "" && textBoxNewDomain.Text != "Reenter password...")
                {
                    if (textBoxNewPassword.Text == textBoxReenterPassword.Text)
                    {
                        Program.PasswordManager.CreateNewEntry(textBoxNewDomain.Text, textBoxNewUsername.Text, textBoxNewPassword.Text);
                        this.tableLayoutPanelEntryList.Controls.Clear();
                        tableLayoutPanelEntryList_Refresh();

                        this.textBoxNewDomain.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.textBoxNewDomain.ForeColor = System.Drawing.Color.Gray;
                        textBoxNewDomain.Text = "Enter domain name...";

                        this.textBoxNewUsername.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.textBoxNewUsername.ForeColor = System.Drawing.Color.Gray;
                        textBoxNewUsername.Text = "Enter username...";
                    }
                    //Passwords don't match
                    this.textBoxNewPassword.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.textBoxNewPassword.ForeColor = System.Drawing.Color.Gray;
                    this.textBoxNewPassword.UseSystemPasswordChar = false;
                    textBoxNewPassword.Text = "Enter password...";

                    this.textBoxReenterPassword.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.textBoxReenterPassword.ForeColor = System.Drawing.Color.Gray;
                    this.textBoxReenterPassword.UseSystemPasswordChar = false;
                    textBoxReenterPassword.Text = "Reenter password...";
                }
                else
                {
                    //No password has been set
                }
            }
            else
            {
                //Must have username or domain name
            }
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottomButtons;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonCreateNewEntry;
        private System.Windows.Forms.Button buttonCloseManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWarning;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEntryList;
        private System.Windows.Forms.Label labelDomainName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private List<System.Windows.Forms.Label> labelListDomainName;
        private List<System.Windows.Forms.Label> labelListUsername;
        private List<System.Windows.Forms.Label> labelListPassword;
        private List<System.Windows.Forms.Button> buttonRemoveListEntry;
        private List<System.Windows.Forms.TableLayoutPanel> tableLayoutPanelListPassword;
        private List<System.Windows.Forms.PictureBox> pictureBoxListShow;
        private System.Windows.Forms.TextBox textBoxNewDomain;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonAddEntry;
        private System.Windows.Forms.Button buttonRemoveEntry;
        private System.Windows.Forms.TextBox textBoxReenterPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPassword;
        private System.Windows.Forms.PictureBox pictureBoxCopy;
        private System.Windows.Forms.PictureBox pictureBoxShow;
    }
}
