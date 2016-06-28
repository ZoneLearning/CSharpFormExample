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
    public partial class SaloonForm : Form
    {
        public SaloonForm()
        {
            InitializeComponent();
        }

        private void btnTableAdd_Click(object sender, EventArgs e)
        {
            Saloon saloon = new Saloon(txtSaloonName.Text, (int)txtNumberOfTable.Value, txtPrefixOfTable.Text);

            Saloon.Saloons.Add(saloon);

            lstTables.Items.Add(saloon.getSaloonList());

        }

        private void SaloonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
