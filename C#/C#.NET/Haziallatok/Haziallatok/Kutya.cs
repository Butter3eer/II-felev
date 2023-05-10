using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haziallatok
{
    internal class Kutya : Haziallat
    {
        private int elasottCsontok;
        public Kutya(string nev, int vidamsag) : base(nev, vidamsag)
        {
            elasottCsontok = 0;
        }

        public override void Jatszik()
        {
            if (vidamsag <= 10)
            {
                vidamsag += 2;
                Console.WriteLine($"{nev} kutya visszahozta a labdát!");
            }
        }

        public void CsontAsas()
        {
            elasottCsontok++;
        }

        public override string ToString()
        {
            return $"Név:{nev} kutya,  Vidámság:{vidamsag}, Elásott csontok:{elasottCsontok}";
        }
    }
}
