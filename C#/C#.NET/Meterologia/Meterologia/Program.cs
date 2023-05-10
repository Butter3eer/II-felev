using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Meterologia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beolvas();
            //F1();
            //F2();
            //F3();
            F4();
            F5();
        }

        static List<Idojaras> lista = new List<Idojaras>();
        static List<string> varosok;

        static void Beolvas()
        {
            StreamReader file = new StreamReader("tavirathu13.txt");
            while (!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(' ');
                lista.Add(new Idojaras(reszek[0], $"{reszek[1].Substring(0, 2)}:{reszek[1].Substring(2, 2)}", reszek[2], int.Parse(reszek[3])));
            }
        }

        static void F1()
        {
            Console.WriteLine("1. feladat:\n\tVáros kódja:");
            string input = Console.ReadLine();

            string eredmeny = "";
            foreach (var item in lista)
            {
                if (item.Telepules == input)
                {
                    eredmeny = $"{item.Ido} az utolsó időpont.";
                }
            }
            Console.WriteLine(eredmeny);
        }

        static void F2()
        {
            Console.WriteLine("\n2. feladat:\n");
            var alacsony = lista.FirstOrDefault(x => x.Homerseklet == lista.Min(y => y.Homerseklet));

            var magas = lista.FirstOrDefault(x => x.Homerseklet == lista.Max(y => y.Homerseklet));

            string alacsonyKiir = $"{alacsony.Telepules} : {alacsony.Ido}/ {alacsony.Homerseklet} a legalacsonyabb."; ;
            string magasKiir = $"{magas.Telepules} : {magas.Ido}/ {magas.Homerseklet} a legmagasabb. "; ;

            Console.WriteLine(alacsonyKiir + "\n" + magasKiir);
        }

        static void F3()
        {
            Console.WriteLine("\n3. feladat:");

            foreach (var item in lista)
            {
                if (item.SzelIranyErosseg == "00000")
                {
                    Console.WriteLine($"{item.Telepules}: {item.Ido}");
                }
            }
        }

        static void F4()
        {
            Console.WriteLine("\n4. feladat:\n");
            varosok = new List<string>();
            List<Idojaras> ideiglenes = new List<Idojaras>();

            foreach (var item in lista)
            {
                if (!varosok.Contains(item.Telepules))
                {
                    varosok.Add(item.Telepules);
                }
            }
            int varosDb = 0;

            while (varosDb < varosok.Count)
            {
                foreach (var item in lista)
                {
                    if ((item).Telepules == varosok[varosDb])
                    {
                        ideiglenes.Add(item);
                    }
                }
                Console.WriteLine($"{varosok[varosDb]} {KozepHo(ideiglenes)} {Ingadozas(ideiglenes)}");
                ideiglenes.Clear();
                varosDb++;
            }
        }

        static string KozepHo(List<Idojaras> item)
        {
            List<string> idok = new List<string>();
            List<double> sum = new List<double>();
            string eredmeny = "";
            foreach (Idojaras i in item)
            {
                if (i.Ido.Substring(0, 2) == "01")
                {
                    sum.Add(i.Homerseklet);
                    idok.Add(i.Ido.Substring(0, 2));
                }
                if (i.Ido.Substring(0, 2) == "07")
                {
                    sum.Add(i.Homerseklet);
                    idok.Add(i.Ido.Substring(0,2));
                }
                if (i.Ido.Substring(0, 2) == "13")
                {
                    sum.Add(i.Homerseklet);
                    idok.Add(i.Ido.Substring(0,2));
                }
                if (i.Ido.Substring(0, 2) == "19")
                {
                    sum.Add(i.Homerseklet);
                    idok.Add(i.Ido.Substring(0,2));
                }
                eredmeny = $"Középhőmérséklet: {Math.Round(sum.Sum() / sum.Count())}; ";
            }
            if (!idok.Any(x => x == "01") || !idok.Any(x => x == "07") || !idok.Any(x => x == "13") || !idok.Any(x => x == "19"))
            {
                eredmeny = "NA";
            }
            return eredmeny;
        }

        static string Ingadozas(List<Idojaras> item)
        {
            var alacsony = item.First(x => x.Homerseklet == item.Min(y => y.Homerseklet));
            var magas = item.First(x => x.Homerseklet == item.Max(y => y.Homerseklet));
            int eredmeny = magas.Homerseklet - alacsony.Homerseklet;

            return $"Hőmérséklet-ingadozás: {eredmeny}";
        }

        static void F5()
        {
            Console.WriteLine("\n5. feladat:\nA fájlok létrehozása megtörtént.");
            foreach (var item in varosok)
            {
                StreamWriter file = new StreamWriter($"{item}.txt");
                file.WriteLine($"{item}");
                foreach (var i in lista)
                {
                    if (i.Telepules == item)
                    {
                        file.WriteLine($"{i.Ido} {new string('#', Convert.ToInt16(i.Szelerosseg))}");
                    }
                }
                file.Close();
            }
        }
    }
}
