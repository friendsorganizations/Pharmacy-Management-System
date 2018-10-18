namespace PharmacyManagementSystem
{
    partial class ViewExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExpenses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddMedicine = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.POSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMedicineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMedicineStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expiryAlertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBxSearchMedicine = new Bunifu.Framework.UI.BunifuTextbox();
            this.cmdAddExpense = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.expensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewExpensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblAddMedicine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 58);
            this.panel1.TabIndex = 16;
            // 
            // lblAddMedicine
            // 
            this.lblAddMedicine.AutoSize = true;
            this.lblAddMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddMedicine.ForeColor = System.Drawing.Color.White;
            this.lblAddMedicine.Location = new System.Drawing.Point(140, 10);
            this.lblAddMedicine.Name = "lblAddMedicine";
            this.lblAddMedicine.Size = new System.Drawing.Size(254, 39);
            this.lblAddMedicine.TabIndex = 0;
            this.lblAddMedicine.Text = "View Expenses";
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
            this.menuStrip1.Size = new System.Drawing.Size(616, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // POSToolStripMenuItem
            // 
            this.POSToolStripMenuItem.Name = "POSToolStripMenuItem";
            this.POSToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.POSToolStripMenuItem.Text = "POS";
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
            // addMedicineToolStripMenuItem
            // 
            this.addMedicineToolStripMenuItem.Name = "addMedicineToolStripMenuItem";
            this.addMedicineToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addMedicineToolStripMenuItem.Text = "AddMedicine";
            // 
            // ViewMedicineStripMenuItem
            // 
            this.ViewMedicineStripMenuItem.Name = "ViewMedicineStripMenuItem";
            this.ViewMedicineStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ViewMedicineStripMenuItem.Text = "ViewMedicine";
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addCategoryToolStripMenuItem.Text = "AddCategory";
            // 
            // allSalesToolStripMenuItem
            // 
            this.allSalesToolStripMenuItem.Name = "allSalesToolStripMenuItem";
            this.allSalesToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.allSalesToolStripMenuItem.Text = "All Sales";
            // 
            // stockAlertToolStripMenuItem
            // 
            this.stockAlertToolStripMenuItem.Name = "stockAlertToolStripMenuItem";
            this.stockAlertToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.stockAlertToolStripMenuItem.Text = "Stock Alert";
            // 
            // expiryAlertToolStripMenuItem
            // 
            this.expiryAlertToolStripMenuItem.Name = "expiryAlertToolStripMenuItem";
            this.expiryAlertToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.expiryAlertToolStripMenuItem.Text = "Expiry Alert";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Change Password",
            "Logout"});
            this.comboBox1.Location = new System.Drawing.Point(483, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "Admin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column7,
            this.Column1,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(19, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(507, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // txtBxSearchMedicine
            // 
            this.txtBxSearchMedicine.BackColor = System.Drawing.Color.White;
            this.txtBxSearchMedicine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBxSearchMedicine.BackgroundImage")));
            this.txtBxSearchMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtBxSearchMedicine.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtBxSearchMedicine.Icon = ((System.Drawing.Image)(resources.GetObject("txtBxSearchMedicine.Icon")));
            this.txtBxSearchMedicine.Location = new System.Drawing.Point(341, 201);
            this.txtBxSearchMedicine.Name = "txtBxSearchMedicine";
            this.txtBxSearchMedicine.Size = new System.Drawing.Size(185, 27);
            this.txtBxSearchMedicine.TabIndex = 36;
            this.txtBxSearchMedicine.text = "Search Expenses";
            // 
            // cmdAddExpense
            // 
            this.cmdAddExpense.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdAddExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdAddExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdAddExpense.BorderRadius = 0;
            this.cmdAddExpense.ButtonText = "Add Expense";
            this.cmdAddExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAddExpense.DisabledColor = System.Drawing.Color.Gray;
            this.cmdAddExpense.Iconcolor = System.Drawing.Color.Transparent;
            this.cmdAddExpense.Iconimage = null;
            this.cmdAddExpense.Iconimage_right = null;
            this.cmdAddExpense.Iconimage_right_Selected = null;
            this.cmdAddExpense.Iconimage_Selected = null;
            this.cmdAddExpense.IconMarginLeft = 0;
            this.cmdAddExpense.IconMarginRight = 0;
            this.cmdAddExpense.IconRightVisible = true;
            this.cmdAddExpense.IconRightZoom = 0D;
            this.cmdAddExpense.IconVisible = true;
            this.cmdAddExpense.IconZoom = 90D;
            this.cmdAddExpense.IsTab = false;
            this.cmdAddExpense.Location = new System.Drawing.Point(19, 92);
            this.cmdAddExpense.Name = "cmdAddExpense";
            this.cmdAddExpense.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.cmdAddExpense.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmdAddExpense.OnHoverTextColor = System.Drawing.Color.White;
            this.cmdAddExpense.selected = false;
            this.cmdAddExpense.Size = new System.Drawing.Size(118, 33);
            this.cmdAddExpense.TabIndex = 34;
            this.cmdAddExpense.Text = "Add Expense";
            this.cmdAddExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdAddExpense.Textcolor = System.Drawing.Color.White;
            this.cmdAddExpense.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Amount";
            this.Column1.Name = "Column1";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Edit ";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Delete";
            this.Column9.Name = "Column9";
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
            this.addExpensesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addExpensesToolStripMenuItem.Text = "Add Expenses";
            this.addExpensesToolStripMenuItem.Click += new System.EventHandler(this.addExpensesToolStripMenuItem_Click);
            // 
            // viewExpensesToolStripMenuItem
            // 
            this.viewExpensesToolStripMenuItem.Name = "viewExpensesToolStripMenuItem";
            this.viewExpensesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewExpensesToolStripMenuItem.Text = "View Expenses";
            this.viewExpensesToolStripMenuItem.Click += new System.EventHandler(this.viewExpensesToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem1
            // 
            this.addCategoryToolStripMenuItem1.Name = "addCategoryToolStripMenuItem1";
            this.addCategoryToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
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
            // ViewExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBxSearchMedicine);
            this.Controls.Add(this.cmdAddExpense);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewExpenses";
            this.Text = "View Expenses";
            this.Load += new System.EventHandler(this.ViewExpenses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddMedicine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem POSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMedicineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMedicineStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockAlertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expiryAlertToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column9;
        private Bunifu.Framework.UI.BunifuTextbox txtBxSearchMedicine;
        private Bunifu.Framework.UI.BunifuFlatButton cmdAddExpense;
        private System.Windows.Forms.ToolStripMenuItem expensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewExpensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
    }
}