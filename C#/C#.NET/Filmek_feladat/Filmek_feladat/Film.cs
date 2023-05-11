using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek_feladat
{
    internal class Film
    {
        private string cim;
        private string kiadEv;
        private long bevetel;

        public Film(string cim, string kiadEv, long bevetel)
        {
            this.cim = cim;
            this.kiadEv = kiadEv;
            this.bevetel = bevetel;
        }

        public string Cim { get => cim; set => cim = value; }
        public string KiadEv { get => kiadEv; set => kiadEv = value; }
        public long Bevetel { get => bevetel; set => bevetel = value; }
        public DateTime KiadEvDate
        {
            get
            {
                DateTime datum = DateTime.ParseExact(kiadEv, "yyyy", CultureInfo.CurrentCulture);
                return datum;
            }
        }
        public int BevetelInMillio
        {
            get
            {
                int szam = Convert.ToInt32(Math.Round((double)bevetel / 1000000, 2));
                if (szam % Math.Floor((double)szam) < 5)
                {
                    szam = Convert.ToInt32(Math.Floor((double)szam));
                }
                else if (szam % Math.Floor((double)szam) >= 5)
                {
                    szam = Convert.ToInt32(Math.Ceiling((double)szam));
                }
                return szam;
            }
        }
    }
}
