using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szobaszerviz
{
    internal class SzobaSzervíz
    {
        private bool tartalmazEtelt;
        private bool tartalmazWellnesst;

        public SzobaSzervíz(bool tartalmazEtelt, bool tartalmazWellnesst)
        {
            this.tartalmazEtelt = tartalmazEtelt;
            this.tartalmazWellnesst = tartalmazWellnesst;
        }

        public bool TartalmazEtelt { get => tartalmazEtelt; set => tartalmazEtelt = value; }
        public bool TartalmazWellnesst { get => tartalmazWellnesst; set => tartalmazWellnesst = value; }
    }
}
