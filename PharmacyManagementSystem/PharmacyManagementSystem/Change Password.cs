﻿using System;
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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void cmdResetPassword_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            this.Hide();
            homeScreen.Show();
        }

        private void cmdCancelReset_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            this.Hide();
            homeScreen.Show();
        }
    }
}
