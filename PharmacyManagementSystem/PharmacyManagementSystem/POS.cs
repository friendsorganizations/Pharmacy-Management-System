using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void allSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSales allSales = new AllSales();
            this.Hide();
            allSales.Show();
        }

        private void stockAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockAlert stockAlert = new StockAlert();
            this.Hide();
            stockAlert.Show();
        }

        private void expiryAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpiryAlert expiryAlert = new ExpiryAlert();
            this.Hide();
            expiryAlert.Show();
        }

        private void addMedicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine();
            this.Hide();
            addMedicine.Show();
        }

        private void ViewMedicineStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMedicine viewMedicine = new ViewMedicine();
            this.Hide();
            viewMedicine.Show();
        }
        int mov, movX, movY;
        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void POSdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          if (e.ColumnIndex == 5)
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this order", "Delete Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.OK)
                {
                    MessageBox.Show("so deletion confirm");
                }
            }
        }

        private void cmdPrintBill_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = Properties.Resources.headericonadmin;
            Image newImage = bm;
            e.Graphics.DrawImage(newImage, 225, 225, 100, 100);
            e.Graphics.DrawString("Medicine print page", new Font("Arial", 48, FontStyle.Bold), Brushes.DarkBlue, new Point(50, 150));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Logout")
            {
                AdminLogin adminLogin = new AdminLogin();
                this.Hide();
                adminLogin.Show();
            }
            else if (comboBox1.Text == "Change Password")
            {
                ChangePassword changePassword = new ChangePassword();
                this.Hide();
                changePassword.Show();
            }
        }

        private void POS_Load(object sender, EventArgs e)
        {

        }

        private void addExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExpenses addExpenses = new AddExpenses();
            this.Hide();
            addExpenses.Show();
        }

        private void viewExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewExpenses viewExpenses = new ViewExpenses();
            this.Hide();
            viewExpenses.Show();
        }

        private void addCategoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddExpensesCategory addExpensesCategory = new AddExpensesCategory();
            this.Hide();
            addExpensesCategory.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            this.Hide();
            homeScreen.Show();
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
           
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;

        }
    }
}
