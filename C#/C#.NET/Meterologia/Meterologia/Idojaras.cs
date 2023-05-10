using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meterologia
{
    internal class Idojaras
    {
        private string telepules;
        private string ido;
        private string szelIranyErosseg;
        private int homerseklet;
        private string szelirany;
        private string szelerosseg;

        public Idojaras(string telepules, string ido, string szelIranyErosseg, int homerseklet)
        {
            this.telepules = telepules;
            this.ido = ido;
            this.szelIranyErosseg = szelIranyErosseg;
            szelirany = szelIranyErosseg.Substring(0, 3);
            szelerosseg = szelIranyErosseg.Substring(3, 2);
            this.homerseklet = homerseklet;
        }

        public string Telepules { get => telepules; set => telepules = value; }
        public string Ido { get => ido ; set => ido = value; }
        public string SzelIranyErosseg { get => szelIranyErosseg;}
        public int Homerseklet { get => homerseklet; set => homerseklet = value; }
        public string Szelirany { get => szelirany; set => szelirany = value; }
        public string Szelerosseg { get => szelerosseg; set => szelerosseg = value; }
    }
}
