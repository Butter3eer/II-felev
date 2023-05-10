using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi_feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //F10();
            //F11();
            //F12();
            //F16();
            //F17();
            //F18();
            //F26();
            F27();
        }

        static void F10()
        {
            Console.WriteLine("Adjon meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam >= 1 && szam <= 9)
            {
                Console.WriteLine("A szám benne van az [1, 9] intervallumban. ");
            } 
            else
            {
                Console.WriteLine("A szám NINCS benne az [1, 9] intervallumban. ");
            }
        }

        static void F11()
        {
            Console.WriteLine("Adjon meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            double eredmeny = 0;

            if (szam > 0)
            {
                eredmeny = Math.Round(Math.Sqrt(szam), 2);
                Console.WriteLine(eredmeny + " a megadott szám gyöke. ");
            }
            else
            {
                Console.WriteLine("Érvénytelen szám. ");
            }
        }

        static void F12()
        {
            Console.WriteLine("A oldal: ");
            double a =Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("B oldal: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("C oldal: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double kerulet = 0;

            if (a + b <= c || b + c <= a || c + a <= b || (a == b && b == c))
            {
                kerulet = a + b + c;
                Console.WriteLine(kerulet + " a háromszög kerülete. ");
            }
            else
            {
                Console.WriteLine("Ez nem egy háromszög oldalai. ");
            }
        }

        static void F16()
        {
            Console.WriteLine("Első coordináta: ");
            int cord1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Második coordináta: ");
            int cord2 = Convert.ToInt32(Console.ReadLine());

            if (cord1 > 0 && cord2 > 0)
            {
                Console.WriteLine("Első síknegyed (+,+)");
            }
            if (cord1 > 0 && cord2 < 0)
            {
                Console.WriteLine("Negyedik síknegyed (+,-)");
            }
            if (cord1 < 0 && cord2 > 0)
            {
                Console.WriteLine("Második síknegyed (-,+)");
            }
            if (cord1 < 0 && cord2 < 0)
            {
                Console.WriteLine("Harmadik síknegyed (-,-)");
            }
        }

        static void F17()
        {
            Console.WriteLine("Pontszám: ");
            int pont = int.Parse(Console.ReadLine());

            if (pont >= 0 && pont <= 42)
            {
                Console.WriteLine("Elégtelen");
            }

            if (pont >= 43 && pont <= 57)
            {
                Console.WriteLine("Elégséges");
            }

            if (pont >= 58 && pont <= 72)
            {
                Console.WriteLine("Közepes");
            }

            if (pont >= 73 && pont <= 87)
            {
                Console.WriteLine("Jó");
            }

            if (pont >= 88 && pont <= 100)
            {
                Console.WriteLine("Jeles");
            }
        }

        static void F18()
        {
            Console.WriteLine("Pontszám: ");
            int pont = int.Parse(Console.ReadLine());

            if (pont >= 0 && pont <= 13)
            {
                Console.WriteLine("Gyerek");
            }

            if (pont >= 14 && pont <= 17)
            {
                Console.WriteLine("Fiatalkorú");
            }

            if (pont >= 18 && pont <= 23)
            {
                Console.WriteLine("Ifjú");
            }

            if (pont >= 24 && pont <= 59)
            {
                Console.WriteLine("Felnőtt");
            }

            if (pont >= 60)
            {
                Console.WriteLine("Idős");
            }
        }

        static void F26()
        {
            int ev = 0, ho = 0, nap = 0;

            Console.WriteLine("Dátum (év/hónap/nap): ");
            string datum = (Console.ReadLine());
            string[] datum1 = datum.Split('.');

            ev += Convert.ToInt32(datum1[0]);
            ho += Convert.ToInt32(datum1[1]);
            nap += Convert.ToInt32(datum1[2]);

            string honap = "";

            switch (ho)
            {
                case 1: honap = "Jaunár";
                    break;
                case 2: honap = "Február";
                    break;
                case 3:
                    honap = "Március";
                    break;
                case 4:
                    honap = "Április";
                    break;
                case 5:
                    honap = "Május";
                    break;
                case 6:
                    honap = "Június";
                    break;
                case 7:
                    honap = "Július";
                    break;
                case 8:
                    honap = "Augusztus";
                    break;
                case 9:
                    honap = "Szeptember";
                    break;
                case 10:
                    honap = "Október";
                    break;
                case 11:
                    honap = "November";
                    break;
                case 12:
                    honap = "December";
                    break;
            }
            Console.WriteLine($"{ev}.{honap}.{nap}");
        }

        static void F27()
        {
            Random rnd = new Random();

            int tipp = rnd.Next(1, 6);

            if (tipp >= 1 && tipp <= 2)
            {
                Console.WriteLine("Gyenge!");
            }

            else if (tipp >= 3 && tipp <= 4)
            {
                Console.WriteLine("Nem rossz!");
            }

            else if (tipp == 5)
            {
                Console.WriteLine("Jó!");
            }

            else if (tipp == 6)
            {
                Console.WriteLine("Kiváló!");
            }
        }
    }
}
