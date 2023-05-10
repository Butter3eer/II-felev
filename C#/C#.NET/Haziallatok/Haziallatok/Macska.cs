using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haziallatok
{
    internal class Macska : Haziallat
    {
        private int lustasagSzint;
        public Macska(string nev, int vidamsag, int lustasagSzint) : base(nev, vidamsag)
        {
            this.lustasagSzint = lustasagSzint;
        }

        public override void Jatszik()
        {
            if (vidamsag <= 8)
            {
                vidamsag++;
            }
            if (lustasagSzint >= 0)
            {
                lustasagSzint--;
            }
            Console.WriteLine($"{nev} macska galacsint kergetett!");
        }

        public override string ToString()
        {
            return $"Név:{nev}cica, Vidámság:{vidamsag}, Lustaság:{lustasagSzint}";
        }
    }
}
