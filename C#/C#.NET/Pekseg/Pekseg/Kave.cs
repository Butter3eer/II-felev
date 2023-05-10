using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    internal class Kave : Arlap
    {
        private bool habosE;

        public Kave(bool habosE)
        {
            this.habosE = habosE;
        }

        public float mennyibeKerul()
        {
            float ar = 180;
            if (habosE)
            {
                ar = (float)(ar * 1.5);
            }
            return ar;
        }

        public override string ToString()
        {
            if (habosE)
            {
                return $"Habos kávé - {mennyibeKerul()} Ft";
            }
            return $"Nem habos kávé - {mennyibeKerul()} Ft";
        }
    }
}
