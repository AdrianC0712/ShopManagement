using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.BFF.Models
{
    internal class EmailSender
    {
        public static async Task SendEmailAsync(string recipientEmail, string otp)
        {
            string senderEmail = "adrian07cirlig@gmail.com";
            string senderPassword = "cork jvbu peer zxqi";

            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                client.EnableSsl = true;

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(recipientEmail);
                mail.Subject = "Codul tău OTP";
                mail.Body = $"Codul tău OTP este: {otp}";
                mail.IsBodyHtml = false;

                await client.SendMailAsync(mail);
            }
        }
    }
}
