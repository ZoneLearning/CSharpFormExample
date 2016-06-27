using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarParkAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.Plaque = txtPlaque.Text;
            vehicle.Type = (VehicleType)lbVehicleType.SelectedItem;
            vehicle.Contact = chbContact.Checked;
            vehicle.Subscriber = chbSubscriber.Checked;
            lbVehicles.Items.Add(vehicle); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbVehicleType.Items.Add(new VehicleType { Name = " Otomobil(1)", Price = 1 });
            lbVehicleType.Items.Add(new VehicleType { Name = " Minübüs(2)", Price = 2 });
            lbVehicleType.Items.Add(new VehicleType { Name = " Otobüs41)", Price = 4 });
            lbVehicleType.Items.Add(new VehicleType { Name = " Kamyon(4)", Price = 4 });
            lbVehicleType.Items.Add(new VehicleType { Name = " Tır(8)", Price = 8 });
        }

        List<Vehicle> ExitVehicles = new List<Vehicle>();
        private void lbVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbVehicles.SelectedItem == null) return;
            Vehicle selected = (Vehicle)lbVehicles.SelectedItem;
            selected.Exit = DateTime.Now;
            lblPlaque.Text = selected.Plaque;
            lblTime.Text = selected.Duration.ToString();
            lblPrice.Text = selected.Fee.ToString("C2");//sonuna TL yazmak için C2 
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (lbVehicles.SelectedItem == null) return;
            Vehicle selected = (Vehicle)lbVehicles.SelectedItem;
            ExitVehicles.Add(selected);
            lbVehicles.Items.Remove(selected);

        }

        private void btnSeeReport_Click(object sender, EventArgs e)
        {
            Report form = new Report();
            decimal total = 0;

            foreach (Vehicle item in ExitVehicles)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Plaque;
                li.SubItems.Add(item.Type.Name);
                li.SubItems.Add(item.Subscriber ? "Abone" : "Değil");
                li.SubItems.Add(item.Duration.ToString());
                li.SubItems.Add(item.Fee.ToString("C2"));
                form.listView1.Items.Add(li);
                total += item.Fee;
            }
            form.lblTotalFee.Text = total.ToString("C2");
            form.lblTotalVehicles.Text = ExitVehicles.Count.ToString();
            form.Show();
        }
    }
}
