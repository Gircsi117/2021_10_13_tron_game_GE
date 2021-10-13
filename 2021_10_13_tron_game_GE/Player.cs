using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_10_13_tron_game_GE
{
    class Player
    {
        private int sor;
        private int oszlop;
        private int irany;
        private int[] p_color;
        private int[] l_color;

        public int Sor { get => sor; set => sor = value; }
        public int Oszlop { get => oszlop; set => oszlop = value; }
        public int Irany { get => irany; set => irany = value; }
        public int[] P_color { get => p_color; set => p_color = value; }
        public int[] L_color { get => l_color; set => l_color = value; }

        public Player(int sor, int oszlop, int irany, int[] p_color, int[] l_color)
        {
            this.sor = sor;
            this.oszlop = oszlop;
            this.irany = irany;
            this.p_color = new int[4];
            this.l_color = new int[4];

            for (int i = 0; i < 4; i++)
            {
                this.p_color[i] = p_color[i];
                this.l_color[i] = l_color[i];
            }
        }
    }
}
