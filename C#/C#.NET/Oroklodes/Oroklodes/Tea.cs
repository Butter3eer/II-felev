using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    internal class Tea : ForroItal
    {
        private bool citrom;

        public Tea(string nev, int ar, int cukor, bool citrom) : base(nev, ar, cukor)
        {
            this.citrom = citrom;
        }

        public bool Citrom { get => citrom; set => citrom = value; }

        public override string ToString()
        {
            return base.ToString() + (this.citrom?"citrommal":"citrom nélkül");
        }
    }
}
