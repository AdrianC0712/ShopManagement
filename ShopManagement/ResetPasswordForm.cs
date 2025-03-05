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
    public partial class ResetPasswordForm : Form
    {
        public ResetPasswordForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string userName = LoginBox.Text;
            string password = NewPasswordBox.Text;
            string confirmPassword = ConfirmPasswordBox.Text;
            bool isOkPassword = false;
            User user = new User();

            if ( user.CheckIdetityPassword(password,confirmPassword) == true)
            {
                user.ResetUserPassword(userName, password);
            }  
        }
    }
}
