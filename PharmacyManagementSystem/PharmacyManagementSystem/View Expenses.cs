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
    public partial class ViewExpenses : Form
    {
        public ViewExpenses()
        {
            InitializeComponent();
        }

        private void ViewExpenses_Load(object sender, EventArgs e)
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
    }
}
