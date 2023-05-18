using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterDekodolo
{
    internal class Karakter
    {
        private char betu;
        private int[,] matrix;
        private int sorok = 7;
        private int oszlopok = 4;

        public Karakter(char betu, int[,] matrix)
        {
            this.betu = betu;
            this.matrix = matrix;
        }

        public char Betu { get => betu; set => betu = value; }
        public int[,] Matrix { get => matrix; set => matrix = value; }
        public bool Felismer(Karakter masik)
        {
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if (this.matrix[i, j] != masik.matrix[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            string S = "";
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    S += matrix[i, j];
                }
                S += "\n";
            }
            return S;
        }
    }
}
