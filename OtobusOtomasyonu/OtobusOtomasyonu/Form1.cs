using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillBusSeat(40, 7);
        }
  
        void FillBusSeat(int seatNumber, int order)
        {
            for (int i = 1; i <= seatNumber; i++)
            {
                //Herbirkoltuk birer buton
                Button seat = new Button();
                seat.Width = 50;
                seat.Height = 50;
                seat.Margin = new Padding(0);
                flowLayoutPanel1.Controls.Add(seat); 
            }
        }
    }
}
