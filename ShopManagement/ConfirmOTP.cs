using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopManagement.BFF.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ShopManagement
{
    public partial class ConfirmOTP : Form
    {
        private string _UserName, _Password, _OTPCod;
        public ConfirmOTP(string UserName, string Password)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _UserName = UserName;
            _Password = Password;
        }
        public void SetOtpCode(string otpCod)
        {
            _OTPCod = otpCod;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OtpCod = OTP_Box.Text;

            if (OtpCod == _OTPCod)
            {
                User user = new User();
                user.ResetUserPassword(_UserName, _Password);
            }
            else { MessageBox.Show("Codul OTP este introdus gresit!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
