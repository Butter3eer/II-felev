using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szobaszerviz
{
    internal class Lakosztály : Szoba
    {
        private bool komornyik;

        public Lakosztály(int szobaszam, bool komornyik) : base(szobaszam)
        {
            this.komornyik = komornyik;
        }

        public override int Fizetes()
        {
            double alapar = 24000;
            double kaja = 0; 
            double extra = 0;
            if (this.szobaSzerviz.TartalmazEtelt)
            {
                kaja = alapar * 0.1;
            }
            if (this.komornyik)
            {
                extra = alapar * 0.5;
            }
            return (int)(alapar + kaja + extra);
        }

    }
}
