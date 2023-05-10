using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Hazi_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //F1();
            //F24();
            //F23();
            //F25();
            //F26();
            //F15();
            //F12();
            F3();
        }

        static void F1()
        {
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine(i); 
            }

            for (int i = 182; i < 213; i += 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 89; i > 58; i -= 2)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i + $" {Math.Pow(i, 2)}");
            }

            for (int i = 99; i > 0; i -= 3)
            {
                Console.WriteLine(i);
            }

            for (int i = 101; i > 49; i -= 5)
            {
                Console.WriteLine(i * 2);
            }

            for (int i = 1; i < 1000; i++)
            {
                Console.WriteLine(i + ",");
            }
            Console.WriteLine("1000.");

            for (int i = 1000; i > 0; i -= 3)
            {
                Console.WriteLine(i);
            }
        }

        static void F24()
        {
            Console.WriteLine("Adjon meg egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());

            int osszeg = 0;

            for (int i = 1; i < szam + 1; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

            Console.WriteLine(osszeg + " a megadott szám osztóinak összege. ");
        }

        static void F23()
        {
            Console.WriteLine("Adjon meg egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());

            for (int i = 1; i < szam + 1; i++)
            {
                if (szam % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void F25()
        {
            Console.WriteLine("Adjon meg egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());

            int osszeg = 0;

            for (int i = 1; i < szam + 1; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

            if (osszeg == (szam * 2))
            {
                Console.WriteLine("Ez egy tökéletes szám. ");
            }else
            {
                Console.WriteLine("Ez NEM egy tökéletes szám. ");
            }
        }

        static void F26()
        {
            Console.WriteLine("Hatványalap: ");
            int szam = int.Parse(Console.ReadLine());

            Console.WriteLine("Kitevő: ");
            int szam2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Akkor a Hatványérték: {Math.Pow(szam, szam2)}");
        }

        static void F15()
        {
            Random r1 = new Random();

            Console.WriteLine(r1.Next(0, 10));
            Console.WriteLine(r1.Next(0, 25));
            Console.WriteLine(r1.Next(0, 50));
            Console.WriteLine(r1.Next(10, 75));
            Console.WriteLine(r1.Next(-50, 50));
            Console.WriteLine(r1.Next(-100, -70));
        }

        static void F12()
        {
            int egy = 0, ketto = 1, ideg, i, n;

            Console.WriteLine("Adjon meg egy számot: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}{1}", egy, ketto);

            for (i = 3; i <= n; i++)
            {
                ideg = egy + ketto;
                Console.Write(ideg);
                egy = ketto;
                ketto = ideg;
            }
            Console.WriteLine("\n");
        }

        static void F3()
        {
            Console.WriteLine("Adjon meg egy egész számot: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adjon meg egy másik számot: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Adjon meg egy lépésközt: ");
            int lepes = Convert.ToInt32(Console.ReadLine());

            if (szam1 > szam2)
            {
                for (int i = szam2; i < szam1 + 1; i += lepes)
                {
                    Console.WriteLine(i);
                }
            }
            if (szam2 > szam1)
            {
                for (int i = szam1; i < szam2 + 1; i += lepes)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
