namespace PharmacyManagementSystem
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.cmdLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.cmdLogin.ButtonText = "Send Email";
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
            this.cmdLogin.Location = new System.Drawing.Point(106, 218);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmdLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.cmdLogin.selected = false;
            this.cmdLogin.Size = new System.Drawing.Size(142, 36);
            this.cmdLogin.TabIndex = 13;
            this.cmdLogin.Text = "Send Email";
            this.cmdLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdLogin.Textcolor = System.Drawing.Color.White;
            this.cmdLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pharmacy Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 100);
            this.panel1.TabIndex = 14;
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.BackColor = System.Drawing.Color.White;
            this.txtBxUsername.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBxUsername.BackgroundImage")));
            this.txtBxUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBxUsername.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBxUsername.Icon = ((System.Drawing.Image)(resources.GetObject("txtBxUsername.Icon")));
            this.txtBxUsername.Location = new System.Drawing.Point(76, 148);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(199, 36);
            this.txtBxUsername.TabIndex = 11;
            this.txtBxUsername.text = "";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.txtBxUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ForgetPassword";
            this.Text = "Forget Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox txtBxUsername;
        private Bunifu.Framework.UI.BunifuFlatButton cmdLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}