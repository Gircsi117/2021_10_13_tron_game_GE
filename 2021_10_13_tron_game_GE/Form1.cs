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
        public static int meret = 50; //A pálya méretét adja meg
        public static Panel[,] palya;
        

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

            player_general();
        }

        private void player_general()
        {

        }
    }
}
