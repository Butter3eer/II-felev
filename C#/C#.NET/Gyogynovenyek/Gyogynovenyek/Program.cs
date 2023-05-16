using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyogynovenyek
{
    internal class Program
    {
        private static List<Noveny> lista;
        private static Dictionary<string, int> items;
        static void Main(string[] args)
        {
            items = new Dictionary<string, int>();
            lista = new List<Noveny>();
            Beolvas();
            //F1("Gyongyvirag");
            //F2("level");
            //F3();
            //F4();
            //F5();
            //F6();
            //F7();
            //F8();
            //F9();
            //F10();
            F11();
            F12();
        }

        private static void Beolvas()
        {
            StreamReader file = new StreamReader("gyogynovenyek.txt");
            while (!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(';');
                lista.Add(new Noveny(reszek[0], reszek[1], reszek[2], reszek[3]));
            }
        }

        private static void F1(string nev)
        {
            Console.WriteLine("1. feladat: ");
            var item = lista.Find(x => x.Nev == nev);
            Console.WriteLine($"\tA {nev} virágnak a {item.Resz} részét gyűjtik.");
        }

        private static void F2(string resz)
        {
            Console.WriteLine("\n2. feladat:");
            var items = lista.FindAll(x => x.Resz == resz);
            Console.WriteLine($"\t{items.Count} db növénynek gyűjtik a {resz} részét.");
        }

        private static void F3()
        {
            Console.WriteLine("\n3. feladat: ");
            
            foreach (var noveny in lista)
            {
                if (items.ContainsKey(noveny.KezdoHonap))
                {
                    items[noveny.KezdoHonap]++;
                }
                else
                {
                    items[noveny.KezdoHonap] = 1;
                }
            }
            Console.WriteLine($"\t{items.Max(x => x.Key)} hónapban kezdik el gyűjteni a legtöbb növényt.");
        }

        private static void F4()
        {
            Console.WriteLine("\n4. feladat: ");
            var honapok = new List<string>();
            for (int i = 1; i < 13; i++)
            {
                if (!items.ContainsKey(i.ToString()) && !honapok.Contains(i.ToString()))
                {
                    honapok.Add(i.ToString());
                }
            }
            foreach (var i in honapok)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("hónapokban nem kezdenek gyűjteni semmit sem.");
        }

        private static void F5()
        {
            var db = lista.FindAll(x => !x.Nev.Contains(' '));
            Console.WriteLine($"\n5. feladat:\n\t{db.Count} db növénynek áll a neve egyetlen szóból.");
        }

        private static void F6()
        {
            Console.WriteLine("\n6. feladat:\n\tŐsszel szedendő virágok listája:");
            var items = lista.FindAll(x => x.KezdoHonap == "9" || x.KezdoHonap == "10" || x.KezdoHonap == "11");
            foreach (var item in items)
            {
                Console.Write($"{item.Nev}, ");
            }
        }

        private static void F7()
        {
            Console.WriteLine("\n\n7. feladat:\n\tNyártól szedendő virágok listája:");
            var items = lista.FindAll(x => x.KezdoHonap == "6" || x.KezdoHonap == "7" || x.KezdoHonap == "8");
            foreach (var item in items)
            {
                Console.Write($"{item.Nev}, ");
            }
        }

        private static void F8()
        {
            Console.WriteLine("\n\n8. feladat:\n\tA legtöbb ideig szedhető virág(ok) listája:");
            var items = lista.FindAll(x => x.ElteltIdo == lista.Max(y => y.ElteltIdo));
            foreach (var item in items)
            {
                Console.Write($"{item.Nev}, ");
            }
        }

        private static void F9()
        {
            Console.WriteLine("\n\n9. feladat:\n\tNövények, melyeket ugyan azon részéért gyűjtenek mint a csalánt:");
            var csalan = lista.Find(x => x.Nev == "Csalan");
            string resz = csalan.Resz;
            var items = lista.FindAll(x => x.Resz == resz && x.Nev != "Csalan");
            foreach (var item in items)
            {
                Console.Write($"{item.Nev}, ");
            }
        }

        private static void F10()
        {
            var items = lista.FindAll(x => x.Resz.Contains("virag"));
            Console.WriteLine($"\n\n10. feladat:\n\t{items.Count} db növényt szednek a virág féle részéért.");
        }

        private static void F11()
        {
            var items = new Dictionary<string, int>();
            foreach (var item in lista)
            {
                if (items.ContainsKey(item.Resz))
                {
                    items[item.Resz]++;
                }
                else
                {
                    items[item.Resz] = 1;
                }
            }
            Console.WriteLine($"\n\n11. feladat:\n\tA legtöbbet gyűjtött növény rész:\n\t{items.Max(x => x.Key)}");
        }

        private static void F12()
        {
            Console.WriteLine("\n\n12. feladat:");
            var items = new List<int>();
            foreach (var item in lista)
            {

            }

            if (items.Count == 0)
            {
                Console.WriteLine("Nincs olyan hónap ahol ne szednének ");
            }
        }
    }
}
