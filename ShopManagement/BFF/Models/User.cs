using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using ShopManagement.BFF.DataBase;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using BCrypt.Net;

namespace ShopManagement.BFF.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public DateTime DataRegistred { get; set; }
        public string Type_of_user {  get; set; }

        public void CheckUser(string UserName, string Password)
        { 
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            
            string querySelectUser = $"select User_password from Users where Name_of_user = '{UserName}' ";
            string queryPassword = null;
            SqlCommand sqlCommand = new SqlCommand(querySelectUser, dataBaseConnection.GetConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                queryPassword = dataTable.Rows[0]["User_password"].ToString();

                if (VerifyPassword(Password, queryPassword))
                {
                    MessageBox.Show("Autentificare reusita!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Autentificare esuata!", "Esuare!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                MessageBox.Show("Nu a fost identificat asa utilizator!", "Esuare!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        public void ResetUserPassword(string userName, string password)
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string querySelectUser = $"select * from Users where Name_of_user = '{userName}'";
            SqlCommand sqlCommand = new SqlCommand(querySelectUser,dataBaseConnection.GetConnection());
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            string passwordHash = HashPassword(password);

            if (dataTable.Rows.Count == 1)
            {
                string queryUpdatePasswordUser = $"update Users set User_password = '{passwordHash}' where Name_of_user = '{userName}'";
                sqlCommand = new SqlCommand(queryUpdatePasswordUser, dataBaseConnection.GetConnection());
                sqlDataAdapter.SelectCommand = sqlCommand;
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count == 1)
                {
                    MessageBox.Show("Parola a fost resetata cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nu a fost identificat asa utilizator!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool CheckIdetityPassword(string newPassword, string confirmedPassword)
        { 
            bool isOk = false;
            if (newPassword == confirmedPassword)
            {
                isOk = true;
            }
            else 
            {
                MessageBox.Show("Nu coincid parolele introduse!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isOk;
        }

        public bool CheckExistUser(string userName)
        { 
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string queryCheckExistUser = $"select * from users where Name_of_user = '{userName}'";

            SqlCommand sqlCommand = new SqlCommand(queryCheckExistUser, dataBaseConnection.GetConnection());
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);

            bool isExist = false;

            if (dataTable.Rows.Count == 1)
            { 
                isExist = true;
            }
            return isExist;
        }

        public static string GetEmailUser(string userName)
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            SqlDataAdapter dataDataAdapter = new SqlDataAdapter();
            DataTable sqlTable = new DataTable();

            string queryGetEmailUser = $"select User_email from Users where Name_of_user = '{userName}'";
            SqlCommand sqlCommand = new SqlCommand(queryGetEmailUser, dataBaseConnection.GetConnection());
            dataDataAdapter.SelectCommand = sqlCommand;
            dataDataAdapter.Fill(sqlTable);

            string userEmail = null;

            if (sqlTable.Rows.Count == 1)
            {
                userEmail = sqlTable.Rows[0]["User_email"].ToString();
            }
            else 
            {
                MessageBox.Show("Nu a fost identificat asa utilizator!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return userEmail;

        }

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(password); 
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, hashedPassword);
        }
    }
}
