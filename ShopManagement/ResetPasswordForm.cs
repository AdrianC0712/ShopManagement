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
        public string UserName {  get; set; }
        public string Password { get; set; }
        public string OTPCod { get; set; }
        public ResetPasswordForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            string userName = LoginBox.Text;
            string password = NewPasswordBox.Text;
            string confirmPassword = ConfirmPasswordBox.Text;
            User user = new User();

            if ( user.CheckIdetityPassword(password,confirmPassword) == true)
            {
                if (user.CheckExistUser(userName) == true)
                {
                    UserName = userName;
                    Password = password;
                    ConfirmOTP confirmOTP = new ConfirmOTP(UserName, Password);
                    this.Hide();
                    confirmOTP.Show();
                    await SendOtp(confirmOTP);
                }
            }

            async Task SendOtp(ConfirmOTP confirmOTP)
            {
                string otp = OTPGenerator.GenerateOTP(); 
                string email = "adrian07cirlig@gmail.com";
                OTPCod = otp;
                confirmOTP.SetOtpCode(otp);
                Console.WriteLine($"OTP generat: {otp}");
                await EmailSender.SendEmailAsync(email, otp);
            }
        }
    }
}
