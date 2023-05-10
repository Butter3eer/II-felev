using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUtazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Utasok> lista = Beolvas();
            F1(lista);
            F2(lista);
            F3(lista);
            F4(lista);
            F5(lista);
            F6(lista);
            F7(lista);
        }

        static List<Utasok> Beolvas()
        {
            List<Utasok> lista = new List<Utasok>();
            StreamReader file = new StreamReader("utasadat.txt");
            while (!file.EndOfStream)
            {
                lista.Add(new Utasok(file.ReadLine()));   
            }

            file.Close();
            return lista;
        }

        static void F1(List<Utasok> lista)
        {
            Console.WriteLine("1. feladat: A fájl beolvasása megtörtént.");
        }

        static void F2(List<Utasok> lista)
        {
            Console.WriteLine($"2. feladat:\nA buszra {lista.Count} utas akart felszállni. ");
        }

        static void F3(List<Utasok> lista)
        {
            Console.WriteLine("3. feladat:");
            int db = 0;

            foreach (Utasok item in lista)
            {
                if (item.Ervenyes == false)
                {
                    db += 1;
                }
            }

            Console.WriteLine($"A buszra {db} utas nem szállhatott fel.");
        }

        static void F4(List<Utasok> lista)
        {
            Console.WriteLine("4. feladat: ");
            var dupli = lista.GroupBy(item => item.MegHely)
                .ToDictionary(keySelector: g => g.Key, elementSelector: g => g.Count());

            var sorted = dupli.OrderBy(x => x.Value);

            List<int> kiir = new List<int>();

            foreach (var item in sorted)
            {
                kiir.Add(item.Value);
            }


            foreach (var item in sorted)
            {
                if (item.Value == kiir.Max())
                {
                    Console.WriteLine($"A legtöbb utas({item.Value} fő) a {item.Key}.megállóban próbált felszállni.");
                    return;
                }
            }
        }

        static void F5(List<Utasok> lista)
        {
            Console.WriteLine("5. feladat: ");
            int ingyenDb = 0;
            int kedvezmenyDb = 0;
            foreach (var item in lista)
            {
                if (item.Ervenyes == true)
                {
                    if (item.kedvezmenyes == true)
                    {
                        kedvezmenyDb += 1;
                    }
                    if (item.Ingyenes == true)
                    {
                        ingyenDb += 1;
                    }
                }
            }
            Console.WriteLine("Ingyenesen utazók száma: " + ingyenDb);
            Console.WriteLine("A kedvezményesen utazók száma:  " + kedvezmenyDb);
        }

        static void F6(List<Utasok> lista)
        {
            Console.WriteLine("6. feladat: ");
        }
        static int napokszama(int e1, int h1, int n1, int e2, int h2, int n2)
        {
            h1 = (h1 + 9) % 12;
            e1 = e1 - h1 / 10;
            int d1 = 365 * e1 + e1 / 4 - e1 / 100 + e1 / 400 + (h1 * 306 + 5) / 10 + n1 - 1;
            h2 = (h2 + 9) % 12;
            e2 = e2 - h2 / 10;
            int d2 = 365 * e2 + e2 / 4 - e2 / 100 + e2 / 400 + (h2 * 306 + 5) / 10 + n2 - 1;
            int napokszama = d2 - d1;
            return napokszama;
        }

        static void F7(List<Utasok> lista)
        {
            Console.WriteLine("7. feladat: A fájl létrejött.");
            StreamWriter file = new StreamWriter("figyelmeztetes.txt");
            foreach (var item in lista)
            {
                if (item.Ervenyes == true)
                {
                    int napok = napokszama(item.FelDatum.Year, item.FelDatum.Month, item.FelDatum.Day, item.Erveny.Year, item.Erveny.Month, item.Erveny.Day);
                    if (napok <= 3)
                    {
                        file.WriteLine($"{item.Kartya} {item.Erveny.Year}-{item.Erveny.Month}-{item.Erveny.Day}");
                    }
                }
            }
            file.Close();
        }
    }
}
