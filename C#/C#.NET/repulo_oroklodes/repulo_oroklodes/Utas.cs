using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulo_oroklodes
{
    internal class Utas
    {
        private string nev;
        private int suly;

        public Utas(string nev, int suly, RepJegy jegy)
        {
            this.nev = nev;
            this.suly = suly;
            this.jegy = jegy;
        }

        public RepJegy jegy { get ; set; }
        public string Nev { get => nev; set => nev = value; }
        public int Suly { get => suly; set => suly = value; }

        public override string ToString()
        {
            return $"{this.nev} {this.jegy} {this.suly} kg";
        }

        public virtual DateTime BoardingTime()
        {
            DateTime boardTime = jegy.IndulIdo.AddMinutes(-15);
            return boardTime;
        }
    }
}
