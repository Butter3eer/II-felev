using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belepok
{
    internal class Latogatok
    {
        private List<Jegy> jegyek;

        public Latogatok(Jegy jegy)
        {
            jegyek = new List<Jegy>();
            Belepes(jegy);
        }

        public void Belepes(Jegy jegy)
        {
            if (jegy is Jegy)
            {
                jegyek.Add(jegy);
            }
            if (jegy is Berlet)
            {
                Berlet berlet = jegy as Berlet;
                if (berlet.BerletHasznal())
                {
                    jegyek.Add(berlet);
                }
            }
        }

        public int Delutani(List<Jegy> jegyek)
        {
            int db = 0;
            foreach (Jegy jegy in jegyek)
            {
                if (jegy is Berlet && jegy.Tipus == "délutáni")
                {
                    db += 1;
                }
            }
            return db;
        }

        internal List<Jegy> Jegyek { get => jegyek; set => jegyek = value; }

        public override string ToString()
        {
            string output = "";
            foreach (Jegy jegy in jegyek)
            {
                if (jegy is Jegy)
                {
                    output += $"{jegy} (N)\n";
                }
                else
                {
                    output += $"{jegy} (B)\n";
                }
            }
            return output;
        }
    }
}
