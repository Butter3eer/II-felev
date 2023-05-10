using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_erettsegi
{
    internal class Palca
    {
        private string fa;
        private string hossz;
        private string core;
        private string szin;

        public Palca(string fa, string hossz, string core, string szin)
        {
            this.fa = fa;
            this.hossz = hossz;
            this.core = core;
            this.szin = szin;
        }

        public string Fa { get => fa; set => fa = value; }
        public string Hossz { get => hossz; set => hossz = value; }
        public string Core { get => core; set => core = value; }
        public string Szin { get => szin; set => szin = value; }

        public override string ToString()
        {
            return $"({this.fa} - {this.hossz} - {this.core} - {this.szin})";
        }
    }
}
