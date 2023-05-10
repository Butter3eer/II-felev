using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csata
{
    internal class Harcos
    {
        private string nev;
        private Helyzet helyzet;
        private string szin;
        private int eletero;

        public Harcos(string nev, Helyzet helyzet, string szin)
        {
            this.nev = nev;
            this.helyzet = helyzet;
            this.szin = szin;
            this.eletero = 100;
        }

        public int Sebesules(int mennyiseg)
        {
            return eletero -= mennyiseg;
        }

        public virtual void Tamadas(Harcos masik)
        {
            double tavolsag = Math.Sqrt(Math.Pow((double)masik.helyzet.X - (double)this.helyzet.X, 2) +  Math.Pow((double)masik.helyzet.Y - (double)this.helyzet.Y, 2));

            if (tavolsag < 2)
            {
                masik.Sebesules(30);
            }
            Console.WriteLine(this.nev, masik.nev);
        }

        public string Nev { get => nev; set => nev = value; }
        public string Szin { get => szin; set => szin = value; }
        public int Eletero { get => eletero; set => eletero = value; }
        internal Helyzet Helyzet { get => helyzet; set => helyzet = value; }

        public override string ToString()
        {
            return $"{this.nev} {this.szin} {this.eletero} {this.helyzet}";
        }
    }
}
