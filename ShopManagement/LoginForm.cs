using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagement.BFF.Models;

namespace ShopManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AutentificationButton_Click(object sender, EventArgs e)
        {
            string userName = LoginBox.Text;
            string password = PasswordBox.Text;
            User user = new User();
            user.CheckUser(userName, password);
        }

        private void linkResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswordForm resetPasswordForm = new ResetPasswordForm();
            this.Hide();
            resetPasswordForm.Show();
        }
    }
}
