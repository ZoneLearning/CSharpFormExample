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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void Saloon_Click(object sender, EventArgs e)
        {
            Saloon s = (Saloon)sender;
            Order_TableListForm o_tlf = new Order_TableListForm();

            o_tlf.MdiParent = this.MdiParent;
            o_tlf.Saloon = s;
            o_tlf.Show();
        }
    }
}
