using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_erettsegi
{
    internal class Haz
    {
        private string szin;
        private string element;
        private string napszak;
        private string segitseg;
        private string tudasvagy;
        private string haz;

        public Haz(string szin, string element, string napszak, string segitseg, string tudasvagy, string haz)
        {
            this.szin = szin;
            this.element = element;
            this.napszak = napszak;
            this.segitseg = segitseg;
            this.tudasvagy = tudasvagy;
            this.haz = haz;
        }

        public string Szin { get => szin; set => szin = value; }
        public string Element { get => element; set => element = value; }
        public string Napszak { get => napszak; set => napszak = value; }
        public string Segitseg { get => segitseg; set => segitseg = value; }
        public string Tudasvagy { get => tudasvagy; set => tudasvagy = value; }
        public string Vegleges { get => haz; set => haz = value; }

        public override string ToString()
        {
            return $"({this.haz})";
        }
    }
}
