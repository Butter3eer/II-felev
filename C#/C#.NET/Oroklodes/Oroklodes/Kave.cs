using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    internal class Kave : ForroItal
    {
        private string tej;

        public Kave(string nev, int ar, int cukor, string tej) : base(nev, ar, cukor)
        {
            this.tej = tej;
        }

        public string Tej { get => tej; set => tej = value; }

        public override void Aremeles()
        {
            this.ar += 500;
        }

        public override string ToString()
        {
            return base.ToString() + this.tej;
        }
    }
}
