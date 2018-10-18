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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            HomeScreen homeScreen = new HomeScreen();
            this.Hide();
            homeScreen.Show();
        

        }

        private void lnklblSignUP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminSignUp signUp = new AdminSignUp();
            this.Hide();
            signUp.Show();
        }

        private void lnklblForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword forgetPassword = new ForgetPassword();
            this.Hide();
            forgetPassword.Show();
        }
        int mov,movX,movY;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

       

        private void txtBxUsername_Click(object sender, EventArgs e)
        {
            txtBxUsername.text="";
        }

        private void txtBxUsername_Enter(object sender, EventArgs e)
        {
            txtBxUsername.text = "hahha";
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
    }
}
