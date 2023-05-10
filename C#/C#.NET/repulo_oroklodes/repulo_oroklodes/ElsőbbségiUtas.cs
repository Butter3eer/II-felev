using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulo_oroklodes
{
    internal class ElsőbbségiUtas : Utas
    {
        private int pluszSuly;

        public ElsőbbségiUtas(string nev, int suly, RepJegy jegy, int pluszSuly) : base(nev, suly, jegy)
        {
            this.pluszSuly = pluszSuly;
        }

        public int PluszSuly { get => pluszSuly; set => pluszSuly = value; }

        public override string ToString()
        {
            return base.ToString() + this.PluszSuly;
        }

        public override DateTime BoardingTime()
        {
            DateTime boardTime = jegy.IndulIdo.AddMinutes(-45);
            return boardTime;
        }
    }
}
