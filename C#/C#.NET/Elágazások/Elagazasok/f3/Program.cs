using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            Igaz(szam);
            Console.ReadKey();
        }

        static void Igaz(int szam)
        {
            if (szam == 4)
            {
                Console.WriteLine("A megadott szám a 4-es. ");
            }
            if (szam < 10)
            {
                Console.WriteLine("A megadott szám kisebb mint 10. ");
            }
            if (szam % 2 == 0)
            {
                Console.WriteLine("A megadott szám páros. ");
            }
            if (0 <= szam && szam <= 10)
            {
                Console.WriteLine("A megadott szám a [0, 10] intervallumba esik. ");
            }
            if (szam % 3 == 0 && szam % 5 == 0)
            {
                Console.WriteLine("A megadott szám osztható 3-al és 5-el is. ");
            }
            if (szam < 10 && szam > 20)
            {
                Console.WriteLine("A megadott szám nem a [10, 20] intervallumba esik. ");
            }
        }
    }
}
