using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagement
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopManagementDataSet1.Producator". При необходимости она может быть перемещена или удалена.
            this.producatorTableAdapter.Fill(this.shopManagementDataSet1.Producator);

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ShopManagementForm form = new ShopManagementForm();
            this.Hide();
            form.Show();
        }
    }
}
