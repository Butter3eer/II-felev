using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03het
{
    internal class Program
    {
        static void Main(string[] args)
        {
            f1();
            f2();
        }

        static void f1()
        {
            Console.WriteLine("Adjon meg egy egész számot: ");
            int eSzam = int.Parse(Console.ReadLine());

            Console.WriteLine("Adjon meg egy másik egész számot: ");
            int bSzam = int.Parse(Console.ReadLine());

            Console.WriteLine($"Összegük: {eSzam + bSzam}\nHányadosuk: {eSzam / bSzam}");
        }

        static void f2()
        {

        }
    }   
}
