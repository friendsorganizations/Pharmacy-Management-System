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
    public partial class AllSales : Form
    {
        public AllSales()
        {
            InitializeComponent();
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

        private void expiryAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpiryAlert expiryAlert = new ExpiryAlert();
            this.Hide();
            expiryAlert.Show();
        }

        private void stockAlertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockAlert stockAlert = new StockAlert();
            this.Hide();
            stockAlert.Show();
        }

        private void POSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            POS pos = new POS();
            this.Hide();
            pos.Show();
        }
        int mov, movX, movY;
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {

            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Logout")
            {
                HomeScreen homeScreen = new HomeScreen();
                this.Hide();
                homeScreen.Show();
            } 
            else if (comboBox1.Text == "Change Password")
            {
                ChangePassword changePassword = new ChangePassword();
                this.Hide();
                changePassword.Show();
            }
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

        private void dashoardToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}
