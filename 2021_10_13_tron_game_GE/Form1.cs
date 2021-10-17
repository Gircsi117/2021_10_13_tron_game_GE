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
        public static int[,] Colors = new int[2, 4] { {255, 0, 0, 100 },{0, 255, 0, 100 } };
        private List<Player> players = new List<Player>() { };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            general();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void general()
        {
            palya = new Panel[meret, meret];
            int x = 0;
            int y = 0;

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
                x = 0;
            }
            alapPANEL.BackColor = Color.Gray;
        }

        private void player_general()
        {
            players.Clear();
            int irany = 3;
            int sor = 10;
            int oszlop = 10;

            for (int i = 0; i < 2; i++)
            {
                players.Add(new Player(sor, oszlop, irany, new int[3]{Colors[i, 0], Colors[i, 1], Colors[i, 2] }, Colors[i, 3]));

                irany = 1;
                sor = 19;
                oszlop = 19;

                palya[players[i].Sor, players[i].Oszlop].BackColor = Color.FromArgb(players[i].Color[0], players[i].Color[1], players[i].Color[2]);
            }
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

        private void sett_szinez(object sender, EventArgs e)
        {
            sp1_1.BackColor = Color.FromArgb(Convert.ToInt32(sp1_cR.Value), Convert.ToInt32(sp1_cG.Value), Convert.ToInt32(sp1_cB.Value));
            sp1_2.BackColor = Color.FromArgb(Convert.ToInt32(sp1_cA.Value), Convert.ToInt32(sp1_cR.Value), Convert.ToInt32(sp1_cG.Value), Convert.ToInt32(sp1_cB.Value));
            
            sp2_1.BackColor = Color.FromArgb(Convert.ToInt32(sp2_cR.Value), Convert.ToInt32(sp2_cG.Value), Convert.ToInt32(sp2_cB.Value));
            sp2_2.BackColor = Color.FromArgb(Convert.ToInt32(sp2_cA.Value), Convert.ToInt32(sp2_cR.Value), Convert.ToInt32(sp2_cG.Value), Convert.ToInt32(sp2_cB.Value));

            Colors = new int[2, 4] {
                {Convert.ToInt32(sp1_cR.Value), Convert.ToInt32(sp1_cG.Value), Convert.ToInt32(sp1_cB.Value), Convert.ToInt32(sp1_cA.Value)},
                {Convert.ToInt32(sp2_cR.Value), Convert.ToInt32(sp2_cG.Value), Convert.ToInt32(sp2_cB.Value), Convert.ToInt32(sp2_cA.Value)}
            };
        }

        private bool szabade(Player player)
        {
            if (palya[player.Sor + player.irany_mozog()[0], player.Oszlop + player.irany_mozog()[1]].BackColor != Color.Gray)
            {
                return false;
            }
            return true;
        }

        private void ellenoriz()
        {
            if ((players[0].Sor + players[0].irany_mozog()[0] == players[1].Sor + players[1].irany_mozog()[0]) &&
                (players[0].Oszlop + players[0].irany_mozog()[1] == players[1].Oszlop + players[1].irany_mozog()[1]))
            {
                gameover($"Döntetlen!\nJátékidő: {timerLBL.Text}");
            }
            else if (!szabade(players[0]) && !szabade(players[1]))
            {
                gameover($"Döntetlen!\nJátékidő: {timerLBL.Text}");
            }
            else if (!szabade(players[0]))
            {
                gameover($"Player 2 győzött!\nJátékidő: {timerLBL.Text}");
            }
            else if (!szabade(players[1]))
            {
                gameover($"Player 1 győzött!\nJátékidő: {timerLBL.Text}");
            }
            else
            {
                mozog();
            }
        }

        private void mozog()
        {
            for (int i = 0; i < 2; i++)
            {
                palya[players[i].Sor, players[i].Oszlop].BackColor = Color.FromArgb(players[i].L_color, players[i].Color[0], players[i].Color[1], players[i].Color[2]);

                players[i].Sor += players[i].irany_mozog()[0];
                players[i].Oszlop += players[i].irany_mozog()[1];

                palya[players[i].Sor, players[i].Oszlop].BackColor = Color.FromArgb(players[i].Color[0], players[i].Color[1], players[i].Color[2]);
            }
        }

        private void gameover(string szoveg)
        {
            moveTIMER.Stop();
            oraTIMER.Stop();
            MessageBox.Show($"{szoveg}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            restart();
        }

        private void restart()
        {
            for (int i = 1; i < meret-1; i++)
            {
                for (int j = 1; j < meret-1; j++)
                {
                    palya[i, j].BackColor = Color.Gray;
                }
            }
            timerLBL.Text = "00:00";
            startBTN.Enabled = true;
            settingsPANEL.Enabled = true;
        }

        private void oraTIMER_Tick(object sender, EventArgs e)
        {
            set_timer();
        }

        private void moveTIMER_Tick(object sender, EventArgs e)
        {
            ellenoriz();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            player_general();

            oraTIMER.Enabled = true;
            oraTIMER.Start();

            moveTIMER.Enabled = true;
            moveTIMER.Start();

            startBTN.Enabled = false;
            settingsPANEL.Enabled = false;

            this.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            switch (e.KeyCode)
            {
                case Keys.Left: players[1].Irany = 4; break;
                case Keys.Up: players[1].Irany = 1; break;
                case Keys.Right: players[1].Irany = 2; break;
                case Keys.Down: players[1].Irany = 3; break;

                case Keys.A: players[0].Irany = 4; break;
                case Keys.W: players[0].Irany = 1; break;
                case Keys.D: players[0].Irany = 2; break;
                case Keys.S: players[0].Irany = 3; break;

                default: break;
            }
        }
    }
}
