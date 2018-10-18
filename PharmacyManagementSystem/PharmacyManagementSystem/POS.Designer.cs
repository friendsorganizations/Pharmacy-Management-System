namespace PharmacyManagementSystem
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblHeaderPOS = new System.Windows.Forms.Label();
            this.POSdataGridView = new System.Windows.Forms.DataGridView();
            this.expiryAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMedicineStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.POSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.allSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmdPrintBill = new Bunifu.Framework.UI.BunifuFlatButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bunifuTextbox1 = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POSdataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.lblHeaderPOS);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(704, 58);
            this.panel3.TabIndex = 44;
            // 
            // lblHeaderPOS
            // 
            this.lblHeaderPOS.AutoSize = true;
            this.lblHeaderPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderPOS.ForeColor = System.Drawing.Color.White;
            this.lblHeaderPOS.Location = new System.Drawing.Point(245, 10);
            this.lblHeaderPOS.Name = "lblHeaderPOS";
            this.lblHeaderPOS.Size = new System.Drawing.Size(212, 39);
            this.lblHeaderPOS.TabIndex = 0;
            this.lblHeaderPOS.Text = "Point of Sale";
            // 
            // POSdataGridView
            // 
            this.POSdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.POSdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.POSdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewButtonColumn3});
            this.POSdataGridView.Location = new System.Drawing.Point(42, 218);
            this.POSdataGridView.Name = "POSdataGridView";
            this.POSdataGridView.RowHeadersVisible = false;
            this.POSdataGridView.Size = new System.Drawing.Size(602, 150);
            this.POSdataGridView.TabIndex = 47;
            this.POSdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.POSdataGridView_CellContentClick);
            // 
            // expiryAlertToolStripMenuItem
            // 
            this.expiryAlertToolStripMenuItem.Name = "expiryAlertToolStripMenuItem";
            this.expiryAlertToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.expiryAlertToolStripMenuItem.Text = "Expiry Alert";
            this.expiryAlertToolStripMenuItem.Click += new System.EventHandler(this.expiryAlertToolStripMenuItem_Click);
            // 
            // stockAlertToolStripMenuItem
            // 
            this.stockAlertToolStripMenuItem.Name = "stockAlertToolStripMenuItem";
            this.stockAlertToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.stockAlertToolStripMenuItem.Text = "Stock Alert";
            this.stockAlertToolStripMenuItem.Click += new System.EventHandler(this.stockAlertToolStripMenuItem_Click);
            // 
            // ViewMedicineStripMenuItem
            // 
            this.ViewMedicineStripMenuItem.Name = "ViewMedicineStripMenuItem";
            this.ViewMedicineStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ViewMedicineStripMenuItem.Text = "ViewMedicine";
            this.ViewMedicineStripMenuItem.Click += new System.EventHandler(this.ViewMedicineStripMenuItem_Click);
            // 
            // addMedicineToolStripMenuItem
            // 
            this.addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            this.addMedicineToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addMedicineToolStripMenuItem.Text = "AddMedicine";
            this.addMedicineToolStripMenuItem.Click += new System.EventHandler(this.addMedicineToolStripMenuItem_Click);
            // 
            // medicineToolStripMenuItem
            // 
            this.medicineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMedicineToolStripMenuItem,
            this.ViewMedicineStripMenuItem,
            this.addCategoryToolStripMenuItem});
            this.medicineToolStripMenuItem.Name = "medicineToolStripMenuItem";
            this.medicineToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.medicineToolStripMenuItem.Text = "Medicine";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addCategoryToolStripMenuItem.Text = "AddCategory";
            // 
            // POSToolStripMenuItem
            // 
            this.POSToolStripMenuItem.Name = "POSToolStripMenuItem";
            this.POSToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.POSToolStripMenuItem.Text = "POS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.POSToolStripMenuItem,
            this.medicineToolStripMenuItem,
            this.allSalesToolStripMenuItem,
            this.stockAlertToolStripMenuItem,
            this.expiryAlertToolStripMenuItem,
            this.expensesToolStripMenuItem,
            this.dashboardToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // allSalesToolStripMenuItem
            // 
            this.allSalesToolStripMenuItem.Name = "allSalesToolStripMenuItem";
            this.allSalesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.allSalesToolStripMenuItem.Text = "All Sales";
            this.allSalesToolStripMenuItem.Click += new System.EventHandler(this.allSalesToolStripMenuItem_Click);
            // 
            // expensesToolStripMenuItem
            // 
            this.expensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExpensesToolStripMenuItem,
            this.viewExpensesToolStripMenuItem,
            this.addCategoryToolStripMenuItem1});
            this.expensesToolStripMenuItem.Name = "expensesToolStripMenuItem";
            this.expensesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.expensesToolStripMenuItem.Text = "Expenses";
            // 
            // addExpensesToolStripMenuItem
            // 
            this.addExpensesToolStripMenuItem.Name = "addExpensesToolStripMenuItem";
            this.addExpensesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addExpensesToolStripMenuItem.Text = "Add Expenses";
            this.addExpensesToolStripMenuItem.Click += new System.EventHandler(this.addExpensesToolStripMenuItem_Click);
            // 
            // viewExpensesToolStripMenuItem
            // 
            this.viewExpensesToolStripMenuItem.Name = "viewExpensesToolStripMenuItem";
            this.viewExpensesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.viewExpensesToolStripMenuItem.Text = "View Expenses";
            this.viewExpensesToolStripMenuItem.Click += new System.EventHandler(this.viewExpensesToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem1
            // 
            this.addCategoryToolStripMenuItem1.Name = "addCategoryToolStripMenuItem1";
            this.addCategoryToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.addCategoryToolStripMenuItem1.Text = "Add Category";
            this.addCategoryToolStripMenuItem1.Click += new System.EventHandler(this.addCategoryToolStripMenuItem1_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectItem.Location = new System.Drawing.Point(84, 112);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(102, 24);
            this.lblSelectItem.TabIndex = 48;
            this.lblSelectItem.Text = "Select Item";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 161);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 49;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(84, 173);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(78, 24);
            this.lblQuantity.TabIndex = 50;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmdPrintBill
            // 
            this.cmdPrintBill.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdPrintBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdPrintBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPrintBill.BorderRadius = 0;
            this.cmdPrintBill.ButtonText = "Print Bill";
            this.cmdPrintBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPrintBill.DisabledColor = System.Drawing.Color.Gray;
            this.cmdPrintBill.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdPrintBill.Iconimage = null;
            this.cmdPrintBill.Iconimage_right = null;
            this.cmdPrintBill.Iconimage_right_Selected = null;
            this.cmdPrintBill.Iconimage_Selected = null;
            this.cmdPrintBill.IconMarginLeft = 0;
            this.cmdPrintBill.IconMarginRight = 0;
            this.cmdPrintBill.IconRightVisible = true;
            this.cmdPrintBill.IconRightZoom = 0D;
            this.cmdPrintBill.IconVisible = true;
            this.cmdPrintBill.IconZoom = 90D;
            this.cmdPrintBill.IsTab = false;
            this.cmdPrintBill.Location = new System.Drawing.Point(42, 384);
            this.cmdPrintBill.Name = "cmdPrintBill";
            this.cmdPrintBill.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdPrintBill.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmdPrintBill.OnHoverTextColor = System.Drawing.Color.White;
            this.cmdPrintBill.selected = false;
            this.cmdPrintBill.Size = new System.Drawing.Size(93, 30);
            this.cmdPrintBill.TabIndex = 51;
            this.cmdPrintBill.Text = "Print Bill";
            this.cmdPrintBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdPrintBill.Textcolor = System.Drawing.Color.White;
            this.cmdPrintBill.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPrintBill.Click += new System.EventHandler(this.cmdPrintBill_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Change Password",
            "Logout"});
            this.comboBox1.Location = new System.Drawing.Point(564, 1);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.Text = "Admin";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bunifuTextbox1
            // 
            this.bunifuTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextbox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.BackgroundImage")));
            this.bunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTextbox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuTextbox1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuTextbox1.Icon")));
            this.bunifuTextbox1.Location = new System.Drawing.Point(210, 109);
            this.bunifuTextbox1.Name = "bunifuTextbox1";
            this.bunifuTextbox1.Size = new System.Drawing.Size(173, 27);
            this.bunifuTextbox1.TabIndex = 46;
            this.bunifuTextbox1.text = "Search Medicine";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Category";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.HeaderText = "Delete";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 426);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmdPrintBill);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblSelectItem);
            this.Controls.Add(this.bunifuTextbox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.POSdataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.POSdataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTextbox bunifuTextbox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblHeaderPOS;
        private System.Windows.Forms.DataGridView POSdataGridView;
        private System.Windows.Forms.ToolStripMenuItem expiryAlertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockAlertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMedicineStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem POSToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem allSalesToolStripMenuItem;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblQuantity;
        private Bunifu.Framework.UI.BunifuFlatButton cmdPrintBill;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
    }
}