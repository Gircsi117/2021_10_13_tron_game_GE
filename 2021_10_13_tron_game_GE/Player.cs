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
        private int[] color;
        private int l_color;

        public int Sor { get => sor; set => sor = value; }
        public int Oszlop { get => oszlop; set => oszlop = value; }
        public int Irany { get => irany; set => irany = value; }
        public int[] Color { get => color; set => color = value; }
        public int L_color { get => l_color; set => l_color = value; }

        public Player(int sor, int oszlop, int irany, int[] p_color, int l_color)
        {
            this.sor = sor;
            this.oszlop = oszlop;
            this.irany = irany;
            this.color = new int[3];
            this.l_color = l_color;

            for (int i = 0; i < 3; i++)
            {
                this.color[i] = p_color[i];
            }
        }

        public int[] irany_mozog()
        {
            switch (this.irany)
            {
                case 1: return new int[] { -1, 0 }; //fel
                case 2: return new int[] { 0, 1 }; //jobbra
                case 3: return new int[] { 1, 0 }; //le
                case 4: return new int[] { 0, -1 }; //balra

                default: return new int[] { 0, 0 };
            }
        }
    }
}
