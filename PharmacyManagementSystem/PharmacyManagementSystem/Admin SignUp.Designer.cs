namespace PharmacyManagementSystem
{
    partial class AdminSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdSignUp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBxPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtBxUsername = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtBxEmail = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 100);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pharmacy Management System";
            // 
            // cmdSignUp
            // 
            this.cmdSignUp.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdSignUp.BorderRadius = 0;
            this.cmdSignUp.ButtonText = "Sign UP";
            this.cmdSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSignUp.DisabledColor = System.Drawing.Color.Gray;
            this.cmdSignUp.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdSignUp.Iconimage = null;
            this.cmdSignUp.Iconimage_right = null;
            this.cmdSignUp.Iconimage_right_Selected = null;
            this.cmdSignUp.Iconimage_Selected = null;
            this.cmdSignUp.IconMarginLeft = 0;
            this.cmdSignUp.IconMarginRight = 0;
            this.cmdSignUp.IconRightVisible = true;
            this.cmdSignUp.IconRightZoom = 0D;
            this.cmdSignUp.IconVisible = true;
            this.cmdSignUp.IconZoom = 90D;
            this.cmdSignUp.IsTab = false;
            this.cmdSignUp.Location = new System.Drawing.Point(106, 340);
            this.cmdSignUp.Name = "cmdSignUp";
            this.cmdSignUp.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdSignUp.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmdSignUp.OnHoverTextColor = System.Drawing.Color.White;
            this.cmdSignUp.selected = false;
            this.cmdSignUp.Size = new System.Drawing.Size(142, 36);
            this.cmdSignUp.TabIndex = 13;
            this.cmdSignUp.Text = "Sign UP";
            this.cmdSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdSignUp.Textcolor = System.Drawing.Color.White;
            this.cmdSignUp.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSignUp.Click += new System.EventHandler(this.cmdSignUp_Click);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.BackColor = System.Drawing.Color.White;
            this.txtBxPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBxPassword.BackgroundImage")));
            this.txtBxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBxPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBxPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtBxPassword.Icon")));
            this.txtBxPassword.Location = new System.Drawing.Point(75, 235);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(199, 36);
            this.txtBxPassword.TabIndex = 12;
            this.txtBxPassword.text = "Enter userpassword";
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.BackColor = System.Drawing.Color.White;
            this.txtBxUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBxUsername.BackgroundImage")));
            this.txtBxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBxUsername.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBxUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtBxUsername.Icon")));
            this.txtBxUsername.Location = new System.Drawing.Point(75, 181);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(199, 36);
            this.txtBxUsername.TabIndex = 11;
            this.txtBxUsername.text = "Enter username";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.BackColor = System.Drawing.Color.White;
            this.txtBxEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBxEmail.BackgroundImage")));
            this.txtBxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBxEmail.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBxEmail.Icon = ((System.Drawing.Image)(resources.GetObject("txtBxEmail.Icon")));
            this.txtBxEmail.Location = new System.Drawing.Point(75, 289);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(199, 36);
            this.txtBxEmail.TabIndex = 15;
            this.txtBxEmail.text = "Enter email";
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(75, 125);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(199, 36);
            this.bunifuTextbox1.TabIndex = 16;
            this.bunifuTextbox1.text = "Account Name";
            // 
            // AdminSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 430);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdSignUp);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSignUp";
            this.Text = "AdminSignUp";
            this.Load += new System.EventHandler(this.AdminSignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton cmdSignUp;
        private Bunifu.Framework.UI.BunifuTextbox txtBxPassword;
        private Bunifu.Framework.UI.BunifuTextbox txtBxUsername;
        private Bunifu.Framework.UI.BunifuTextbox txtBxEmail;
        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
    }
}