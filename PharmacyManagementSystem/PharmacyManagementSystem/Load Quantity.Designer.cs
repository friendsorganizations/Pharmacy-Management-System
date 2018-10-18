namespace PharmacyManagementSystem
{
    partial class LoadQuantity
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
            this.cmdupdateQuantity = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblupdateQuantity = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdupdateQuantity
            // 
            this.cmdupdateQuantity.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdupdateQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdupdateQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdupdateQuantity.BorderRadius = 0;
            this.cmdupdateQuantity.ButtonText = "Save";
            this.cmdupdateQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdupdateQuantity.DisabledColor = System.Drawing.Color.Gray;
            this.cmdupdateQuantity.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdupdateQuantity.Iconimage = null;
            this.cmdupdateQuantity.Iconimage_right = null;
            this.cmdupdateQuantity.Iconimage_right_Selected = null;
            this.cmdupdateQuantity.Iconimage_Selected = null;
            this.cmdupdateQuantity.IconMarginLeft = 0;
            this.cmdupdateQuantity.IconMarginRight = 0;
            this.cmdupdateQuantity.IconRightVisible = true;
            this.cmdupdateQuantity.IconRightZoom = 0D;
            this.cmdupdateQuantity.IconVisible = true;
            this.cmdupdateQuantity.IconZoom = 90D;
            this.cmdupdateQuantity.IsTab = false;
            this.cmdupdateQuantity.Location = new System.Drawing.Point(245, 124);
            this.cmdupdateQuantity.Name = "cmdupdateQuantity";
            this.cmdupdateQuantity.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdupdateQuantity.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmdupdateQuantity.OnHoverTextColor = System.Drawing.Color.White;
            this.cmdupdateQuantity.selected = false;
            this.cmdupdateQuantity.Size = new System.Drawing.Size(94, 24);
            this.cmdupdateQuantity.TabIndex = 25;
            this.cmdupdateQuantity.Text = "Save";
            this.cmdupdateQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdupdateQuantity.Textcolor = System.Drawing.Color.White;
            this.cmdupdateQuantity.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdupdateQuantity.Click += new System.EventHandler(this.cmdupdateQuantity_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(47, 83);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtUpdateQuantity
            // 
            this.txtUpdateQuantity.Location = new System.Drawing.Point(128, 83);
            this.txtUpdateQuantity.Multiline = true;
            this.txtUpdateQuantity.Name = "txtUpdateQuantity";
            this.txtUpdateQuantity.Size = new System.Drawing.Size(211, 20);
            this.txtUpdateQuantity.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblupdateQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 49);
            this.panel1.TabIndex = 13;
            // 
            // lblupdateQuantity
            // 
            this.lblupdateQuantity.AutoSize = true;
            this.lblupdateQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdateQuantity.ForeColor = System.Drawing.Color.White;
            this.lblupdateQuantity.Location = new System.Drawing.Point(92, 9);
            this.lblupdateQuantity.Name = "lblupdateQuantity";
            this.lblupdateQuantity.Size = new System.Drawing.Size(211, 31);
            this.lblupdateQuantity.TabIndex = 0;
            this.lblupdateQuantity.Text = "Update Quantity";
            // 
            // LoadQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 172);
            this.Controls.Add(this.cmdupdateQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtUpdateQuantity);
            this.Controls.Add(this.panel1);
            this.Name = "LoadQuantity";
            this.Text = "Load Quantity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton cmdupdateQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtUpdateQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblupdateQuantity;
    }
}