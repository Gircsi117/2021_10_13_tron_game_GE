using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_10_13_tron_game_GE
{
    public partial class Form1 : Form
    {
        public static int meret = 30; //A pálya méretét adja meg
        public static Panel[,] palya;
        public static int[,] p_colors = new int[2, 4] { {255,0,0,100 },{0,255,0,100 } };

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            general();
        }

        private void general()
        {
            palya = new Panel[meret, meret];
            int x = 12;
            int y = 12;

            for (int i = 0; i < meret; i++)
            {
                for (int j = 0; j < meret; j++)
                {
                    Panel pan = new Panel();
                    alapPANEL.Controls.Add(pan);

                    pan.Size = new Size((600 / meret), (600 / meret));
                    pan.Location = new Point(x, y);
                    if (i == 0 || j == 0 || i == (meret - 1) || j == (meret - 1))
                    {
                        pan.BackColor = Color.Black;
                        pan.BorderStyle = BorderStyle.None;
                    }
                    else
                    {
                        pan.BackColor = Color.Gray;
                        pan.BorderStyle = BorderStyle.FixedSingle;
                    }
                    

                    palya[i, j] = pan;
                    x += (600 / meret);
                }
                y += (600 / meret);
                x = 12;
            }

            timer_general();

            player_general();
        }

        private void timer_general()
        {
            Label timerLBL = new Label();
            timePANEL.Controls.Add(timerLBL);
            timerLBL.Text = "00:00";
            timerLBL.TextAlign = ContentAlignment.MiddleCenter;
            timerLBL.Size = new Size(317, 100);
            timerLBL.Location = new Point(0, 0);
            timerLBL.Font = new Font("Arial", 48);
        }

        private void set_timer()
        {
            int perc = Convert.ToInt32(timePANEL.Controls[0].Text.Split(':')[0]);
            int mp = Convert.ToInt32(timePANEL.Controls[0].Text.Split(':')[1]) + 1;
            string ido = "";

            if (mp == 60)
            {
                perc++;
                mp = 0;
            }

            if (perc < 10)
            {
                ido += "0";
            }
            ido += $"{perc}:";

            if (mp < 10)
            {
                ido += "0";
            }
            ido += $"{mp}";

            timePANEL.Controls[0].Text = ido;
        }

        private void player_general()
        {

        }

        private void sett_szinez(object sender, EventArgs e)
        {
            sp1_1.BackColor = Color.FromArgb(Convert.ToInt32(sp1_cR.Value), Convert.ToInt32(sp1_cG.Value), Convert.ToInt32(sp1_cB.Value));
            sp1_2.BackColor = Color.FromArgb(Convert.ToInt32(sp1_cA.Value), Convert.ToInt32(sp1_cR.Value), Convert.ToInt32(sp1_cG.Value), Convert.ToInt32(sp1_cB.Value));
            
            sp2_1.BackColor = Color.FromArgb(Convert.ToInt32(sp2_cR.Value), Convert.ToInt32(sp2_cG.Value), Convert.ToInt32(sp2_cB.Value));
            sp2_2.BackColor = Color.FromArgb(Convert.ToInt32(sp2_cA.Value), Convert.ToInt32(sp2_cR.Value), Convert.ToInt32(sp2_cG.Value), Convert.ToInt32(sp2_cB.Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oraTIMER.Enabled = true;
            oraTIMER.Start();
        }

        private void oraTIMER_Tick(object sender, EventArgs e)
        {
            set_timer();
        }
    }
}
