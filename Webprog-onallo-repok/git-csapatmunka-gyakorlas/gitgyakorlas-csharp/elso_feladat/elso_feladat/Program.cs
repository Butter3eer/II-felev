using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elso_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            F1();
            F2();
        }

        static void F1()
        {
            Console.WriteLine("Adjon meg egy számot: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adjon meg egy másik számot: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A nagyobb szám: " + a);
            }
            if (b > a)
            {
                Console.WriteLine("A nagyobb szám: " + b);
            }
            if (a == b)
            {
                Console.WriteLine("A két szám egyenlő. ");
            }
        }

        static void F2()
        {
            Console.WriteLine("Adjon meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            List<int> lista = new List<int>();
            lista.Add(szam);

            while (szam != 0)
            {
                Console.WriteLine("Adjon meg egy másik számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
                lista.Add(szam);
            }

            int max = lista.Max();
            Console.WriteLine("A létrehozott lista maximuma: " + max);

            int min = lista.Min();
            Console.WriteLine("A létrehozott lista minimuma: " + min);
        }
    }
}
