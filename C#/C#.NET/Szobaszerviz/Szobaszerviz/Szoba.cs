using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szobaszerviz
{
    internal class Szoba
    {
        protected SzobaSzervíz szobaSzerviz;
        protected int szobaszam;
        protected bool foglaltE;

        internal SzobaSzervíz Szobaszerviz { get => szobaSzerviz; set => szobaSzerviz = value; }
        public int Szobaszam { get => szobaszam; set => szobaszam = value; }
        public bool FoglaltE { get => foglaltE; set => foglaltE = value; }

        public Szoba(int szobaszam)
        {
            this.szobaszam = szobaszam;
            this.foglaltE = false;
        }

        public void Foglalas(SzobaSzervíz szobaszervíz)
        {
            this.szobaSzerviz = szobaszervíz;
            this.foglaltE = true;
        }

        public virtual int Fizetes()
        {
            double alapar = 12000;
            double kaja = 0;
            double wellness = 0;

            if (this.foglaltE)
            {
                if (this.szobaSzerviz.TartalmazEtelt)
                {
                    kaja = alapar * 0.1;
                }
                if (this.szobaSzerviz.TartalmazWellnesst)
                {
                    wellness = alapar * 0.1;
                }
                return (int)Math.Round(alapar + kaja + wellness);
            }
            else
            {
                return 0;
            }
        }
    }
}
