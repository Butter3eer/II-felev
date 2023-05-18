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
            //F11();
            //F12();
            //F13();
            //F14();
            //F15();
            //F16();
            //F17();
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
            var honapok = new List<int>();
            var db = new List<int>();
            foreach (var item in lista)
            {
                if (int.Parse(item.VegsoHonap) < int.Parse(item.KezdoHonap))
                {
                    for (int i = int.Parse(item.KezdoHonap); i < 13; i++)
                    {
                        honapok.Add(i);
                    }

                    for (int i = 1; i < int.Parse(item.VegsoHonap) + 1; i++)
                    {
                        honapok.Add(i);
                    }
                }
                else
                {
                    for (int i = int.Parse(item.KezdoHonap); i < int.Parse(item.VegsoHonap) + 1; i++)
                    {
                        honapok.Add(i);
                    }
                }                
            }

            for (int i = 1; i < 13; i++)
            {
                int szamok = honapok.FindAll(x => x == i).Count();
                db.Add(szamok);
            }

            if (db.Contains(0))
            {
                foreach (var item in db)
                {
                    if (item == 0)
                    {
                        int honap = db.IndexOf(item) + 1;
                        Console.Write($"{honap}, ");
                    }
                }
                Console.WriteLine(" hónap(ok)ban nem szedtek semmit. ");
            }
            else
            {
                Console.WriteLine("Nincs olyan hónap amikor nem szednének semmit. ");
            }
        }

        private static void F13()
        {
            Console.WriteLine("\n\n13. feladat:");
            var honapok = new List<int>();
            var db = new List<int>();
            foreach (var item in lista)
            {
                if (int.Parse(item.VegsoHonap) < int.Parse(item.KezdoHonap))
                {
                    for (int i = int.Parse(item.KezdoHonap); i < 13; i++)
                    {
                        honapok.Add(i);
                    }

                    for (int i = 1; i < int.Parse(item.VegsoHonap) + 1; i++)
                    {
                        honapok.Add(i);
                    }
                }
                else
                {
                    for (int i = int.Parse(item.KezdoHonap); i < int.Parse(item.VegsoHonap) + 1; i++)
                    {
                        honapok.Add(i);
                    }
                }                
            }

            for (int i = 1; i < 13; i++)
            {
                int szamok = honapok.FindAll(x => x == i).Count();
                db.Add(szamok);
            }

            var itemek = db.FindAll(x => x == db.Max());
            foreach (var item in itemek)
            {
                int honap = db.IndexOf(item) + 1;
                Console.Write($"{honap}, ");
            }
            Console.WriteLine(" hónap(ok)ban szedték a legtöbb fajta virágot. ");
        }

        private static void F14()
        {
            Console.WriteLine("\n\n14.feladat: Növények kezdőhónapjaik alapján rendezve:");
            var sortLista = lista.OrderBy(x => int.Parse(x.KezdoHonap));
            foreach (var item in sortLista)
            {
                Console.Write($"{item.Nev} / {item.KezdoHonap} :: ");
            }
        }

        private static void F15()
        {
            Console.WriteLine("\n\n15. feladat: Növények a szedési idejükkel párban:");
            foreach (var item in lista)
            {
                Console.Write($"{item.Nev} / {item.ElteltIdo} :: ");
            }
        }

        private static void F16()
        {
            Console.WriteLine("\n\n16. feladat:\n\tA fájlba írás megtörtént.");
            StreamWriter file = new StreamWriter("gyujtendok.txt");
            var sortLista = lista.OrderBy(x => x.Resz);
            foreach (var item in sortLista)
            {
                file.WriteLine($"{item.Nev} / {item.Resz} - {item.KezdoHonap} - {item.VegsoHonap}");
            }
            file.Close();
        }

        private static void F17()
        {
            Console.WriteLine("\n\n17. feladat:\n\tA fájlba írás megtörtént.");
            StreamWriter file = new StreamWriter("gyogynovenyidoszak.txt");
            var sortLista = lista.OrderBy(x => x.Nev).OrderBy(x => x.ElteltIdo);
            foreach (var item in sortLista)
            {
                file.WriteLine($"{item.ElteltIdo}:{item.Nev} / {item.Resz} - {item.KezdoHonap} - {item.VegsoHonap}");
            }
            file.Close();
        }
    }
}
