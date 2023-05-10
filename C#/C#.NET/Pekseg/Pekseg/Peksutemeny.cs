using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    public abstract class Peksutemeny : Arlap
    {
        protected float mennyiseg;
        private float alapar;

        protected Peksutemeny(float mennyiseg, float alapar)
        {
            this.mennyiseg = mennyiseg;
            this.alapar = alapar;
        }
        public abstract void Megkostol();

        public float mennyibeKerul()
        {
            float ar = mennyiseg * alapar;
            return ar;
        }

        public override string ToString()
        {
            return $"{mennyiseg}db - {mennyibeKerul()} Ft";
        }

    }
}
