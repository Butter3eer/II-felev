using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csata
{
    internal class Csatater
    {
        List<Harcos> harcosok = new List<Harcos>();

        public void ListaHarcos(Harcos harcos)
        {
            if (!harcosok.Any(x => x.Helyzet == harcos.Helyzet))
            {
                harcosok.Add(harcos);
            }
        }

        public void Harc(int k)
        {
            Harcos kHarcos = harcosok[k - 1];
            foreach (Harcos harcos in harcosok)
            {
                int min = harcosok.Min(x => x.Eletero);
                if (harcos.Szin != kHarcos.Szin && harcos.Eletero == min)
                {
                    kHarcos.Tamadas(harcos);
                }
            }
        }
    }
}
