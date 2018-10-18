namespace PharmacyManagementSystem
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdResetPassword = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBxNewPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtBxoldPassword = new Bunifu.Framework.UI.BunifuTextbox();
            this.cmdCancelReset = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel1.Size = new System.Drawing.Size(397, 100);
            this.panel1.TabIndex = 14;
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
            // cmdResetPassword
            // 
            this.cmdResetPassword.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdResetPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdResetPassword.BorderRadius = 0;
            this.cmdResetPassword.ButtonText = "Reset";
            this.cmdResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdResetPassword.DisabledColor = System.Drawing.Color.Gray;
            this.cmdResetPassword.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdResetPassword.Iconimage = null;
            this.cmdResetPassword.Iconimage_right = null;
            this.cmdResetPassword.Iconimage_right_Selected = null;
            this.cmdResetPassword.Iconimage_Selected = null;
            this.cmdResetPassword.IconMarginLeft = 0;
            this.cmdResetPassword.IconMarginRight = 0;
            this.cmdResetPassword.IconRightVisible = true;
            this.cmdResetPassword.IconRightZoom = 0D;
            this.cmdResetPassword.IconVisible = true;
            this.cmdResetPassword.IconZoom = 90D;
            this.cmdResetPassword.IsTab = false;
            this.cmdResetPassword.Location = new System.Drawing.Point(218, 270);
            this.cmdResetPassword.Name = "cmdResetPassword";
            this.cmdResetPassword.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdResetPassword.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmdResetPassword.OnHoverTextColor = System.Drawing.Color.White;
            this.cmdResetPassword.selected = false;
            this.cmdResetPassword.Size = new System.Drawing.Size(87, 36);
            this.cmdResetPassword.TabIndex = 13;
            this.cmdResetPassword.Text = "Reset";
            this.cmdResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdResetPassword.Textcolor = System.Drawing.Color.White;
            this.cmdResetPassword.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResetPassword.Click += new System.EventHandler(this.cmdResetPassword_Click);
            // 
            // txtBxNewPassword
            // 
            this.txtBxNewPassword.BackColor = System.Drawing.Color.White;
            this.txtBxNewPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBxNewPassword.BackgroundImage")));
            this.txtBxNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBxNewPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBxNewPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtBxNewPassword.Icon")));
            this.txtBxNewPassword.Location = new System.Drawing.Point(106, 206);
            this.txtBxNewPassword.Name = "txtBxNewPassword";
            this.txtBxNewPassword.Size = new System.Drawing.Size(199, 36);
            this.txtBxNewPassword.TabIndex = 12;
            this.txtBxNewPassword.text = "Enter New Password";
            // 
            // txtBxoldPassword
            // 
            this.txtBxoldPassword.BackColor = System.Drawing.Color.White;
            this.txtBxoldPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBxoldPassword.BackgroundImage")));
            this.txtBxoldPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBxoldPassword.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBxoldPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtBxoldPassword.Icon")));
            this.txtBxoldPassword.Location = new System.Drawing.Point(106, 138);
            this.txtBxoldPassword.Name = "txtBxoldPassword";
            this.txtBxoldPassword.Size = new System.Drawing.Size(199, 36);
            this.txtBxoldPassword.TabIndex = 11;
            this.txtBxoldPassword.text = "Enter Old Password";
            // 
            // cmdCancelReset
            // 
            this.cmdCancelReset.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdCancelReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdCancelReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdCancelReset.BorderRadius = 0;
            this.cmdCancelReset.ButtonText = "Cancel";
            this.cmdCancelReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCancelReset.DisabledColor = System.Drawing.Color.Gray;
            this.cmdCancelReset.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdCancelReset.Iconimage = null;
            this.cmdCancelReset.Iconimage_right = null;
            this.cmdCancelReset.Iconimage_right_Selected = null;
            this.cmdCancelReset.Iconimage_Selected = null;
            this.cmdCancelReset.IconMarginLeft = 0;
            this.cmdCancelReset.IconMarginRight = 0;
            this.cmdCancelReset.IconRightVisible = true;
            this.cmdCancelReset.IconRightZoom = 0D;
            this.cmdCancelReset.IconVisible = true;
            this.cmdCancelReset.IconZoom = 90D;
            this.cmdCancelReset.IsTab = false;
            this.cmdCancelReset.Location = new System.Drawing.Point(106, 270);
            this.cmdCancelReset.Name = "cmdCancelReset";
            this.cmdCancelReset.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdCancelReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmdCancelReset.OnHoverTextColor = System.Drawing.Color.White;
            this.cmdCancelReset.selected = false;
            this.cmdCancelReset.Size = new System.Drawing.Size(87, 36);
            this.cmdCancelReset.TabIndex = 15;
            this.cmdCancelReset.Text = "Cancel";
            this.cmdCancelReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdCancelReset.Textcolor = System.Drawing.Color.White;
            this.cmdCancelReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelReset.Click += new System.EventHandler(this.cmdCancelReset_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 364);
            this.Controls.Add(this.cmdCancelReset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdResetPassword);
            this.Controls.Add(this.txtBxNewPassword);
            this.Controls.Add(this.txtBxoldPassword);
            this.Name = "ChangePassword";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton cmdResetPassword;
        private Bunifu.Framework.UI.BunifuTextbox txtBxNewPassword;
        private Bunifu.Framework.UI.BunifuTextbox txtBxoldPassword;
        private Bunifu.Framework.UI.BunifuFlatButton cmdCancelReset;
    }
}