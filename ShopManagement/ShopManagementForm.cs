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
    public partial class ShopManagementForm : Form
    {
        public ShopManagementForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ShopManagementForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopManagementDataSet.Produse". При необходимости она может быть перемещена или удалена.
            this.produseTableAdapter.Fill(this.shopManagementDataSet.Produse);

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            this.Hide();
            addProduct.Show();
        }
    }
}
