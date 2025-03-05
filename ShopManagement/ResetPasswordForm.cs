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

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string userName = LoginBox.Text;
            string password = NewPasswordBox.Text;
            string confirmPassword = ConfirmPasswordBox.Text;
            User user = new User();

            if ( user.CheckIdetityPassword(password,confirmPassword) == true)
            {
                user.ResetUserPassword(userName, password);
                await SendOtp();
            }

            async Task SendOtp()
            {
                string otp = OTPGenerator.GenerateOTP(); // Sau GenerateAlphanumericOTP()
                string email = "liudadonic11@gmail.com";

                Console.WriteLine($"OTP generat: {otp}");
                await EmailSender.SendEmailAsync(email, otp);
            }
        }
    }
}
