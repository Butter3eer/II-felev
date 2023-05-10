using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarsalgo
{
    internal class Ajto
    {
        public int ora { get; }
        public int perc { get; }
        public int azon { get; }
        public bool bemegy { get; }
        public string ido { get; }

        public Ajto(string sor)
        {
            string[] reszek = sor.Split(' ');
            ora = int.Parse(reszek[0]);
            perc = int.Parse(reszek[1]);
            azon = int.Parse(reszek[2]);
            if (reszek[3] == "be")
            {
                bemegy = true;
            }
            else
            {
                bemegy = false;
            }
            ido = $"{reszek[0]}:{reszek[1]}";
        }
    }
}
