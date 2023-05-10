using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labda
{
    public class Labda : IRughato, IPattinthato
    {
        private string markanev;
        private int pattintasokSzama;
        private int rugasokSzama;

        public string Markanev { get => markanev; set => markanev = value; }
        public int PattintasokSzama { get => pattintasokSzama; set => pattintasokSzama = value; }
        public int RugasokSzama { get => rugasokSzama; set => rugasokSzama = value; }

        public Labda(string markanev)
        {
            this.markanev = markanev;
        }
        public void Rug()
        {
            Console.WriteLine($"{markanev} labda elrúgva.");
            RugasokSzama++;
        }

        public void Pattint()
        {
            Console.WriteLine($"{markanev} labda elpattintva.");
            PattintasokSzama++;
        }

        public override string ToString()
        {
            return $"{rugasokSzama} a rúgások száma, {pattintasokSzama} a pattintások száma.";
        }
    }
}
