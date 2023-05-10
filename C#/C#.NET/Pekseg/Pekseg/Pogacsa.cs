using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    internal class Pogacsa : Peksutemeny
    {
        public Pogacsa(float mennyiseg, float alapar) : base(mennyiseg, alapar)
        {
        }

        public override void Megkostol()
        {
            mennyiseg /= 2;
        }

        public override string ToString()
        {
            return $"Pogacsa " + base.ToString() + ", ahol Y azt jelenti, mennyibe kerül összesen";
        }
    }
}
