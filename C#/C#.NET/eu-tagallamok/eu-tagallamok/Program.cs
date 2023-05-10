using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eu_tagallamok
{
    internal class Orszag
    {
        private string nev;
        private DateTime datum;

        public Orszag(string nev, DateTime datum)
        {
            this.nev = nev;
            this.Datum = datum;
        }

        public string Nev
        {
            get => nev;
            set
            {
                if (value.Length > 0)
                {
                    nev = value;
                }
                else
                {
                    nev = null;
                }
            }
        }

        public DateTime Datum { get => datum; set => datum = value; }

        public 
    }
}
