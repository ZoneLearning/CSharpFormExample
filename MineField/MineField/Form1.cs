using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineField
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int score = 0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            FillMine(10, 10);

        }
        void FillMine(int mine, int size)
        {
            flowLayoutPanel.Width = size * 30;
            flowLayoutPanel.Height = size * 30;

            //start butonuna yeniden basınca içindeki kontrolleri temizlemek için.
            flowLayoutPanel.Controls.Clear();

            int[] mines = new int[mine];

            Random random = new Random();
            for (int i = 0; i < mine; i++)
            {
                int selected = random.Next(0, size * size);
                if (mines.Contains(selected))
                {
                    i--;
                    continue;
                }
                mines[i] = selected;
            }

            for (int i = 0; i < size * size; i++)
            {
                Button btn = new Button();
                btn.Width = 30;
                btn.Height = 30;
                btn.Margin = new Padding(0);
                //i=0'dan size*size kadar bütün elamanlardan mines eger mayınlı numaralardan olan i'yi içeriyorsa true döndürür, içermiyorsa false döndürür.
                //Tag özelliği, nesnenin değerini saklamak için kullanılır. = Cep gibi
                btn.Tag = mines.Contains(i);
                btn.Click += Btn_Click;
                flowLayoutPanel.Controls.Add(btn);

            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            bool state = (bool)clicked.Tag;
            if (state == true)
            {
                clicked.BackColor = Color.PaleVioletRed;
                FinishGame();

            }
            else
            {
                clicked.BackColor = Color.GreenYellow;
                score++;
                txtScore.Text = score.ToString();
            }


        }

        void FinishGame()
        {
            score = 0;

            foreach (Button item in flowLayoutPanel.Controls)
            {

                bool state = (bool)item.Tag;

                if (state)
                {
                    item.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    item.BackColor = Color.GreenYellow;
                }
            }
            DialogResult result = MessageBox.Show("Do you want to play again?", " Finish Game", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                FillMine(10, 10);
            }

        }


    }
}
