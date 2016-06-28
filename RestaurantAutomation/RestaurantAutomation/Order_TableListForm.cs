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
    public partial class Order_TableListForm : Form
    {
        public Order_TableListForm()
        {
            InitializeComponent();
        }

        public Saloon Saloon { get; set; }

        private void Order_TableListForm_Load(object sender, EventArgs e)
        {
            lblSaloonName.Text = Saloon.Name;

            foreach (Table table in Saloon.Tables)
            {
                table.Click += Table_Click;
                flTable.Controls.Add(table);
            }
        }

        private void Table_Click(object sender, EventArgs e)
        {
            TableDetailForm tdf = new TableDetailForm();
            tdf.Table = (Table)sender;
            tdf.MdiParent = this.MdiParent;
            tdf.Show();
        }

        private void Order_TableListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
