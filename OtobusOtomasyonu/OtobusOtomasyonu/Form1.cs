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
            FillBusSeat(58, 7);
        }

        void FillBusSeat(int seatNumber, int order)
        {
            //koltuk listesinin temizlenmesini sağlar.
            flowLayoutPanel1.Controls.Clear();

            //Koltuk sayısı kadar koltuk olusturacak for döngüsü
            for (int i = 1; i <= seatNumber; i++)
            {
                //Her bir koltuk birer buton
                Button seat = new Button();
                seat.Width = 40;
                seat.Height = 40;
                seat.Text = i.ToString();
                //son 4'lü yanyana dursun diye sondan 3 önceki elamanı 20 ilerlettik. ( ortalı olsun diye)
                if (seatNumber - 3 == i) 

                    seat.Margin = new Padding(20, 0, 0, 0);

                else if (seatNumber - 1 == i) //son sıradaki elemanda koridor olmasını engeller
                    seat.Margin = new Padding(0);

                else if (order * 4 - 2 == i)//orta kapıyı bulup orta kapının karşısına gelen koltuğun sağına koltuk gelmemesini sağlayan koşul                
                seat.Margin = new Padding(0, 0, 120, 0);

                else if (i % 4 == 3 && i < (order - 1) * 4) //kapıdan çnceki koltuklarda koridor koltuk numarasının 4'e modunun 3 olduğu durumdur.

                    seat.Margin = new Padding(40, 0, 0, 0);

                else if (i % 4 == 1 && i > order * 4)// kapıdan sonra sıra 2 kayar ve mod 4 = 1 olduğu zaman koridor olmalıdır

                    seat.Margin = new Padding(40, 0, 0, 0);

                else // bu koşullardan biri değilse normal koltuktur. Boşluksuz hizalanmalı.
                    seat.Margin = new Padding(0);
                //koltugu panele ekledik.
           flowLayoutPanel1.Controls.Add(seat);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (toolStripComboBox1.SelectedItem.ToString())
            {
                case "07:00":
                    FillBusSeat(46, 7);
                break;
                case "09:00":
                    FillBusSeat(42, 6);
                    break;
                case "13:00":
                    FillBusSeat(50, 8);
                    break;
                case "20:00":
                    FillBusSeat(54, 8);
                    break;
               
            }

        }
    }
}
