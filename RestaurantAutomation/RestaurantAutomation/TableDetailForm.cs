using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation
{
    public partial class TableDetailForm : Form
    {

        public TableDetailForm()
        {
            InitializeComponent();
        }
        public Table Table { get; set; }
        private void TableDetailForm_Load(object sender, EventArgs e)
        {
            lblTableNo.Text = Table.Code;
            lblTotalPrice.Text = Table.TotalPrice.ToString("C2");
            foreach (Product p in Table.Products)
            {
                lstProducts.Items.Add(p.getProductList());
            }

            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Price";
            cmbProduct.DataSource = Product.list;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product p = (Product)cmbProduct.SelectedItem;
            Table.Products.Add(p);
            lstProducts.Items.Add(p.getProductList());

        }
    }
}
