using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haziallatok
{
    public abstract class Haziallat
    {
        protected string nev;
        protected int vidamsag;

        protected Haziallat(string nev, int vidamsag)
        {
            this.nev = nev;
            this.vidamsag = vidamsag;
        }

        public abstract void Jatszik();

        public override string ToString()
        {
            return $"Név:{nev}, Vidámság:{vidamsag}";
        }
    }
}
