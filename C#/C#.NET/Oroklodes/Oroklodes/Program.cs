using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForroItal f1 = new ForroItal("forrócsoki", 220, 3);
            Console.WriteLine(f1);
            Kave k1 = new Kave("espresso", 250, 1, "tej nélkül");
            Console.WriteLine(k1);
            Kave k2 = new Kave("latte", 350, 5, "sok tej");
            Console.WriteLine(k2);

            Tea t1 = new Tea("gyümölcstea", 300, 3, true);
            Console.WriteLine(t1);

            Tea t2 = new Tea("fekete tea", 300, 0, false);
            Console.WriteLine(t2);

            Console.WriteLine("------------------------------------------------------------");

            f1.Aremeles();
            k1.Aremeles();
            t1.Aremeles();

            Console.WriteLine(f1);
            Console.WriteLine(k1);
            Console.WriteLine(t1);
        }

    }
}
