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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtName.Text, txtPrice.Value);
            //product.Name = txtName.Text;
            //product.Price = txtPrice.Value;

            Product.list.Add(product);

            lstProduct.Items.Add(product.getProductList());
        }
    }
}
