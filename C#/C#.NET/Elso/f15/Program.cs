using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjon meg egy valós számot: ");
            float eSzam = float.Parse(Console.ReadLine());

            Console.WriteLine("Adjon meg egy másik valós számot: ");
            float mSzam = float.Parse(Console.ReadLine());

            Console.WriteLine($"x\t=\t{eSzam}");
            Console.WriteLine($"y\t=\t{mSzam}");
            Console.WriteLine("----------------------");
            Console.WriteLine($"x + y\t=\t{eSzam + mSzam}");
            Console.WriteLine($"x - y\t=\t{eSzam - mSzam}");
            Console.WriteLine($"x * y\t=\t{eSzam * mSzam}");
            Console.WriteLine($"x / y\t=\t{eSzam / mSzam}");
            Console.WriteLine($"x ^ 2\t=\t{eSzam * eSzam}");
            Console.WriteLine($"y ^ 2\t=\t{mSzam * mSzam}");
            Console.WriteLine($"x ^ 3\t=\t{Math.Pow(eSzam, 3)}");
            Console.WriteLine($"y ^ 3\t=\t{Math.Pow(mSzam, 3)}");

            Console.ReadKey();
        }
    }
}
