using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jegyek
{
    internal class Vonaljegy : Jegy
    {
        private bool ervenyesseg;

        public Vonaljegy(bool ervenyesseg)
        {
            this.ervenyesseg = ervenyesseg;
            ar = Napiar;
        }

        public override bool Ervenyesit()
        {
            return ervenyesseg = false;
        }

        public bool Ervenyesseg { get => ervenyesseg; set => ervenyesseg = value; }
    }
}
