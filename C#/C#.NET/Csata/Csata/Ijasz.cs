using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csata
{
    internal class Ijasz : Harcos
    {
        private int nyilakSzama;

        public Ijasz(string nev, Helyzet helyzet, string szin, int nyilakSzama) : base(nev, helyzet, szin)
        {
            this.nyilakSzama = nyilakSzama;
        }


        public override void Tamadas(Harcos masik)
        {
            double tavolsag = Math.Sqrt(Math.Pow((double)masik.Helyzet.X - (double)this.Helyzet.X, 2) + Math.Pow((double)masik.Helyzet.Y - (double)this.Helyzet.Y, 2));

            if (tavolsag < 11)
            {
                masik.Sebesules(15);
            }
            Console.WriteLine(this.Nev, masik.Nev);
        }
        public int NyilakSzama { get => nyilakSzama; set => nyilakSzama = value; }

        public override string ToString()
        {
            return base.ToString() + " " + this.nyilakSzama;
        }
    }
}
