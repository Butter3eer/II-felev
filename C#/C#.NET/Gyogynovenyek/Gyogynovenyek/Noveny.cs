using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyogynovenyek
{
    internal class Noveny
    {
        private string nev;
        private string resz;
        private string kezdoHonap;
        private string vegsoHonap;

        public Noveny(string nev, string resz, string kezdoHonap, string vegsoHonap)
        {
            this.nev = nev;
            this.resz = resz;
            this.kezdoHonap = kezdoHonap;
            this.vegsoHonap = vegsoHonap;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Resz { get => resz; set => resz = value; }
        public string KezdoHonap { get => kezdoHonap; set => kezdoHonap = value; }
        public string VegsoHonap { get => vegsoHonap; set => vegsoHonap = value; }
        public int ElteltIdo
        {
            get
            {
                int vegsoInt;
                int ido;
                if (int.Parse(vegsoHonap) < int.Parse(kezdoHonap))
                {
                    vegsoInt = int.Parse(vegsoHonap) + 12;
                    ido = vegsoInt - int.Parse(kezdoHonap);
                }
                else
                {
                    ido = int.Parse(vegsoHonap) - int.Parse(kezdoHonap);
                }
                return ido;
            }
        }
    }
}
