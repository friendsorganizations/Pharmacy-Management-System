namespace PharmacyManagementSystem
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.cmdLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lnklblSignUP = new System.Windows.Forms.LinkLabel();
            this.lnklblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.txtBxPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtBxUsername = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdLogin
            // 
            this.cmdLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdLogin.BorderRadius = 0;
            this.cmdLogin.ButtonText = "Login";
            this.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLogin.DisabledColor = System.Drawing.Color.Gray;
            this.cmdLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdLogin.Iconimage = null;
            this.cmdLogin.Iconimage_right = null;
            this.cmdLogin.Iconimage_right_Selected = null;
            this.cmdLogin.Iconimage_Selected = null;
            this.cmdLogin.IconMarginLeft = 0;
            this.cmdLogin.IconMarginRight = 0;
            this.cmdLogin.IconRightVisible = true;
            this.cmdLogin.IconRightZoom = 0D;
            this.cmdLogin.IconVisible = true;
            this.cmdLogin.IconZoom = 90D;
            this.cmdLogin.IsTab = false;
            this.cmdLogin.Location = new System.Drawing.Point(137, 259);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmdLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.cmdLogin.selected = false;
            this.cmdLogin.Size = new System.Drawing.Size(114, 36);
            this.cmdLogin.TabIndex = 6;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdLogin.Textcolor = System.Drawing.Color.White;
            this.cmdLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 100);
            this.panel1.TabIndex = 7;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pharmacy Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Don\'t Have Account ?";
            // 
            // lnklblSignUP
            // 
            this.lnklblSignUP.AutoSize = true;
            this.lnklblSignUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblSignUP.LinkColor = System.Drawing.Color.SeaGreen;
            this.lnklblSignUP.Location = new System.Drawing.Point(220, 321);
            this.lnklblSignUP.Name = "lnklblSignUP";
            this.lnklblSignUP.Size = new System.Drawing.Size(56, 16);
            this.lnklblSignUP.TabIndex = 9;
            this.lnklblSignUP.TabStop = true;
            this.lnklblSignUP.Text = "Sign Up";
            this.lnklblSignUP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSignUP_LinkClicked);
            // 
            // lnklblForgetPassword
            // 
            this.lnklblForgetPassword.AutoSize = true;
            this.lnklblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblForgetPassword.LinkColor = System.Drawing.Color.SeaGreen;
            this.lnklblForgetPassword.Location = new System.Drawing.Point(149, 347);
            this.lnklblForgetPassword.Name = "lnklblForgetPassword";
            this.lnklblForgetPassword.Size = new System.Drawing.Size(122, 18);
            this.lnklblForgetPassword.TabIndex = 10;
            this.lnklblForgetPassword.TabStop = true;
            this.lnklblForgetPassword.Text = "Forget Password";
            this.lnklblForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblForgetPassword_LinkClicked);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.BackColor = System.Drawing.Color.White;
            this.txtBxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBxPassword.BackgroundImage")));
            this.txtBxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBxPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBxPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtBxPassword.Icon")));
            this.txtBxPassword.Location = new System.Drawing.Point(106, 193);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(199, 36);
            this.txtBxPassword.TabIndex = 5;
            this.txtBxPassword.text = "Enter userpassword";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.BackColor = System.Drawing.Color.White;
            this.txtBxUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBxUsername.BackgroundImage")));
            this.txtBxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBxUsername.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBxUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtBxUsername.Icon")));
            this.txtBxUsername.Location = new System.Drawing.Point(106, 125);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(199, 36);
            this.txtBxUsername.TabIndex = 4;
            this.txtBxUsername.text = "Enter username";
            this.txtBxUsername.Click += new System.EventHandler(this.txtBxUsername_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 399);
            this.ControlBox = false;
            this.Controls.Add(this.lnklblForgetPassword);
            this.Controls.Add(this.lnklblSignUP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox txtBxUsername;
        private Bunifu.Framework.UI.BunifuTextbox txtBxPassword;
        private Bunifu.Framework.UI.BunifuFlatButton cmdLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnklblSignUP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnklblForgetPassword;
    }
}

