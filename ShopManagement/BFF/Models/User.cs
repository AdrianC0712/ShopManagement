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

            string querySelectUser = $"select * from Users where Name_of_user = '{UserName}' and User_password = '{Password}'";

            SqlCommand sqlCommand = new SqlCommand(querySelectUser, dataBaseConnection.GetConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Autentificare reusita!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Autentificare esuata!", "Esuare!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (dataTable.Rows.Count == 1)
            {
                string queryUpdatePasswordUser = $"update Users set User_password = '{password}' where Name_of_user = '{userName}'";
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
    }
}
