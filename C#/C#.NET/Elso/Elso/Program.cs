using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Világ!");
            Console.Write("Kiss");
            Console.Write("Jakab");

            int szam = 6;
            Console.WriteLine();
            Console.WriteLine("A változó értéke:" + szam);
            Console.WriteLine("A változó értéke: {0}", szam);
            Console.WriteLine($"A változó értéke: {szam}");

            Console.Write("Kérem adja meg a nevét: ");
            string nev = Console.ReadLine();

            char karakter = '*';

            nev = "agsfajhsfg";

            bool logikai = false;

            double valosSzam = 121.3764;

            Console.Write("Kérek egy számot: ");
            int egeszSzam = Convert.ToInt32(Console.ReadLine());
            //int egeszSzam2 = int.Parse(Console.ReadLine());

            Console.Write("Kérek egy valós számot: ");
            double valos = Convert.ToDouble(Console.ReadLine());
            //double valos2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"55 * 10 = {1.0 * 55 / 10}");
            //Console.WriteLine($"55 * 10 = {(double)55 / 10}");

            Console.WriteLine($"55 % 10 = {55 % 10}");

            Console.WriteLine("Ez egy sor\nEz egy új sor\n\tEgy tabbal bentebb");

            Console.ReadKey();

        }
    }
}
