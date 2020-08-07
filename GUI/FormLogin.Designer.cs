namespace HiTechLibrary.GUI
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.mTxtUserName = new MetroFramework.Controls.MetroTextBox();
            this.mTxtPasswd = new MetroFramework.Controls.MetroTextBox();
            this.mBtnLogin = new MetroFramework.Controls.MetroButton();
            this.mBtnRegister = new MetroFramework.Controls.MetroButton();
            this.mBtnExit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mTxtUserName
            // 
            this.mTxtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(63)))));
            // 
            // 
            // 
            this.mTxtUserName.CustomButton.Image = null;
            this.mTxtUserName.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.mTxtUserName.CustomButton.Name = "";
            this.mTxtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtUserName.CustomButton.TabIndex = 1;
            this.mTxtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtUserName.CustomButton.UseSelectable = true;
            this.mTxtUserName.CustomButton.Visible = false;
            this.mTxtUserName.Lines = new string[] {
        "Username"};
            this.mTxtUserName.Location = new System.Drawing.Point(97, 257);
            this.mTxtUserName.MaxLength = 32767;
            this.mTxtUserName.Name = "mTxtUserName";
            this.mTxtUserName.PasswordChar = '\0';
            this.mTxtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtUserName.SelectedText = "";
            this.mTxtUserName.SelectionLength = 0;
            this.mTxtUserName.SelectionStart = 0;
            this.mTxtUserName.ShortcutsEnabled = true;
            this.mTxtUserName.Size = new System.Drawing.Size(236, 23);
            this.mTxtUserName.TabIndex = 2;
            this.mTxtUserName.Tag = "";
            this.mTxtUserName.Text = "Username";
            this.mTxtUserName.UseSelectable = true;
            this.mTxtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtUserName.Enter += new System.EventHandler(this.mTxtUserName_Enter);
            this.mTxtUserName.Leave += new System.EventHandler(this.mTxtUserName_Leave);
            // 
            // mTxtPasswd
            // 
            this.mTxtPasswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(20)))), ((int)(((byte)(63)))));
            // 
            // 
            // 
            this.mTxtPasswd.CustomButton.Image = null;
            this.mTxtPasswd.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.mTxtPasswd.CustomButton.Name = "";
            this.mTxtPasswd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mTxtPasswd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mTxtPasswd.CustomButton.TabIndex = 1;
            this.mTxtPasswd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mTxtPasswd.CustomButton.UseSelectable = true;
            this.mTxtPasswd.CustomButton.Visible = false;
            this.mTxtPasswd.Lines = new string[] {
        "Password"};
            this.mTxtPasswd.Location = new System.Drawing.Point(97, 303);
            this.mTxtPasswd.MaxLength = 32767;
            this.mTxtPasswd.Name = "mTxtPasswd";
            this.mTxtPasswd.PasswordChar = '*';
            this.mTxtPasswd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mTxtPasswd.SelectedText = "";
            this.mTxtPasswd.SelectionLength = 0;
            this.mTxtPasswd.SelectionStart = 0;
            this.mTxtPasswd.ShortcutsEnabled = true;
            this.mTxtPasswd.Size = new System.Drawing.Size(236, 23);
            this.mTxtPasswd.TabIndex = 3;
            this.mTxtPasswd.Text = "Password";
            this.mTxtPasswd.UseSelectable = true;
            this.mTxtPasswd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mTxtPasswd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mTxtPasswd.Enter += new System.EventHandler(this.mTxtPasswd_Enter);
            this.mTxtPasswd.Leave += new System.EventHandler(this.mTxtPasswd_Leave);
            // 
            // mBtnLogin
            // 
            this.mBtnLogin.Location = new System.Drawing.Point(174, 345);
            this.mBtnLogin.Name = "mBtnLogin";
            this.mBtnLogin.Size = new System.Drawing.Size(91, 23);
            this.mBtnLogin.TabIndex = 4;
            this.mBtnLogin.Text = "Login";
            this.mBtnLogin.UseSelectable = true;
            this.mBtnLogin.Click += new System.EventHandler(this.mBtnLogin_Click);
            // 
            // mBtnRegister
            // 
            this.mBtnRegister.Location = new System.Drawing.Point(336, 462);
            this.mBtnRegister.Name = "mBtnRegister";
            this.mBtnRegister.Size = new System.Drawing.Size(88, 23);
            this.mBtnRegister.TabIndex = 5;
            this.mBtnRegister.Text = "&Register";
            this.mBtnRegister.UseSelectable = true;
            // 
            // mBtnExit
            // 
            this.mBtnExit.Location = new System.Drawing.Point(12, 462);
            this.mBtnExit.Name = "mBtnExit";
            this.mBtnExit.Size = new System.Drawing.Size(47, 23);
            this.mBtnExit.TabIndex = 8;
            this.mBtnExit.Text = "E&xit";
            this.mBtnExit.UseSelectable = true;
            this.mBtnExit.Click += new System.EventHandler(this.mBtnExit_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(436, 497);
            this.Controls.Add(this.mBtnExit);
            this.Controls.Add(this.mBtnRegister);
            this.Controls.Add(this.mBtnLogin);
            this.Controls.Add(this.mTxtPasswd);
            this.Controls.Add(this.mTxtUserName);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox mTxtUserName;
        private MetroFramework.Controls.MetroTextBox mTxtPasswd;
        private MetroFramework.Controls.MetroButton mBtnLogin;
        private MetroFramework.Controls.MetroButton mBtnRegister;
        private MetroFramework.Controls.MetroButton mBtnExit;
    }
}