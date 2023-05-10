using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //F1();
            //F3();
            //F4();
            //F5();
            //F6();
            //-----------//
            //F19();
            //F20();
            //F21();
            //F22();
            F23();
        }

        static void F1()
        {
            Console.WriteLine("Fej vagy írás? [0/1]: ");
            int tipp = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            int randtipp = rnd.Next(2);

            while (tipp != randtipp)
            {
                randtipp = rnd.Next(2);
                Console.WriteLine("Új tipp: ");
                tipp = int.Parse(Console.ReadLine());
            }
        }

        static void F3()
        {
            Console.WriteLine("Adjon meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());

            int osszeg = 0;
            osszeg += szam;

            while (szam != 0)
            {
                Console.WriteLine(osszeg);
                Console.WriteLine("Nem talált, újra: ");
                szam = int.Parse(Console.ReadLine());
                osszeg *= szam;
            }
        }

        static void F4()
        {
            string alma = "alma";

            Console.WriteLine(alma + "\n");

            Console.WriteLine("Új szó: ");
            string szo = Console.ReadLine();

            alma += " " + szo;

            while (szo != " ")
            {
                Console.WriteLine(alma);
                Console.WriteLine("Új tipp: ");
                szo = Console.ReadLine();
                alma += " " + szo;
            }
        }

        static void F5()
        {
            Console.WriteLine("Darabszám: ");
            int db = int.Parse(Console.ReadLine());

            string karlanc = "";

            while (db != 0)
            {
                db -= 1;
                Console.WriteLine("Karakter: ");
                char kar = Convert.ToChar(Console.ReadLine());
                karlanc += kar;
            }
            Console.WriteLine(karlanc);
        }

        static void F6()
        {
            Console.WriteLine("Első szám: ");
            int szam1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Második szám: ");
            int szam2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lépésköz: ");
            int lepes = int.Parse(Console.ReadLine());

            if (szam1 < szam2)
            {
                while (szam1 != szam2 + 1)
                {
                    Console.WriteLine(szam1);
                    szam1 += lepes;
                }
            }
            else if (szam2 < szam1)
            {
                while (szam2 != szam1 + 1)
                {
                    Console.WriteLine(szam2);
                    szam2 += lepes;
                }
            }
        }
        //-----------------------DO-WHILE-----------------//

        static void F19()
        {
            Console.WriteLine("Páros szám: ");
            int parSzam = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Próbáld újra: ");
                parSzam = int.Parse(Console.ReadLine());
            } while (parSzam % 2 != 0);
            Console.WriteLine("A megadott szám megfelelő.");
        }

        static void F20()
        {
            Console.WriteLine("Páros szám: ");
            int parSzam = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Próbáld újra: ");
                parSzam = int.Parse(Console.ReadLine());
            } while (parSzam % 2 != 0);
            Console.WriteLine(parSzam % 5);
        }

        static void F21()
        {
            Console.WriteLine("Adjon egy számot [1, 7] között: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam > 7 || szam < 1)
            {
                do
                {
                    Console.WriteLine("Próbáld újra: ");
                    szam = int.Parse(Console.ReadLine());

                } while (szam > 7 || szam < 1);
            }

            string nap = "";

            switch (szam)
            {
                case 1: nap = "hétfő";
                    break;

                case 2:
                    nap = "kedd";
                    break;

                case 3:
                    nap = "szerda";
                    break;

                case 4:
                    nap = "csütörtök";
                    break;

                case 5:
                    nap = "péntek";
                    break;

                case 6:
                    nap = "szombat";
                    break;

                case 7:
                    nap = "vasárnap";
                    break;
            }
            Console.WriteLine(nap);
        }

        static void F22()
        {
            Console.WriteLine("Negatív páratlan szám: ");
            int negPar = int.Parse(Console.ReadLine());

            if (negPar >= 0 && negPar % 2 != 0)
            {
                do
                {
                    Console.WriteLine("Próbáld újra: ");
                    negPar = int.Parse(Console.ReadLine());

                } while (negPar >= 0 && negPar % 2 != 0);
            }
            Console.WriteLine("Sikeres!");
        }

        static void F23()
        {
            Console.WriteLine("3-al és 5-el osztható szám: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam % 5 != 0 && szam % 3 != 0)
            {
                do
                {
                    Console.WriteLine("Próbáld újra: ");
                    szam = int.Parse(Console.ReadLine());

                } while (szam % 5 != 0 && szam % 3 != 0);
            }
            Console.WriteLine($"{szam / 3} osztva 3-al,{szam / 5} osztva 5-el. ");
        }
    }
}
