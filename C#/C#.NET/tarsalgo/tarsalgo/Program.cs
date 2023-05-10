using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace tarsalgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ajto> adatok = Beolvas();
            F1();
            F2(adatok);
            F3(adatok);
            F4(adatok);
            F5(adatok);
            int a = F6();
            F7(adatok, a);
            F8(adatok, a);
        }

        static List<Ajto> Beolvas()
        {
            List<Ajto> lista = new List<Ajto>();
            StreamReader file = new StreamReader("ajto-1.txt");
            while (!file.EndOfStream)
            {
                lista.Add(new Ajto(file.ReadLine()));
            }
            file.Close();
            return lista;
        }

        static void F1()
        {
            Console.WriteLine("1. feladat: A fájl beolvasása megtörtént.\n");
        }

        static void F2(List<Ajto> adatok)
        {
            var kicsi = adatok[0];
            foreach (var item in adatok)
            {
                if (item.bemegy == true && kicsi.ora > item.ora && kicsi.perc > item.perc)
                {
                    kicsi = item;
                    break;
                }
            }

            var nagy = adatok[0];
            foreach (var item in adatok)
            {
                if (item.bemegy == false && nagy.ora < item.ora || nagy.perc < item.perc)
                {
                    nagy = item;
                }
            }

            Console.WriteLine($"2. feladat:\nAz első belépő: {kicsi.azon}\nAz utolsó kilépő: {nagy.azon}\n");
        }

        static void F3(List<Ajto> adatok)
        {
            StreamWriter file = new StreamWriter("athaladas.txt");
            var dupli = adatok.GroupBy(item => item.azon)
                .ToDictionary(keySelector: g => g.Key, elementSelector: g => g.Count());

            var sorted = dupli.OrderBy(x => x.Key);

            foreach (var item in sorted)
            {
                file.WriteLine(item.Key + " " + item.Value);
            }

            file.Close();
            Console.WriteLine("3. feladat: A fájl létrehozása megtörtént.\n");
        }

        static void F4(List<Ajto> adatok)
        {
            Console.WriteLine("4. feladat:\t");
            List<int> benn = new List<int>();

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].bemegy == true && !benn.Contains(adatok[i].azon))
                {
                    benn.Add(adatok[i].azon);
                }
                if (adatok[i].bemegy == false)
                {
                    benn.Remove(adatok[i].azon);
                }
            }

            Console.Write("A végén a társalgóban voltak: ");

            foreach (var item in benn)
            {
                Console.Write(item + " ");
            }
        }

        static void F5(List<Ajto> adatok)
        {
            Console.WriteLine("\n\n5. feladat: ");
            List<int> beki = new List<int>();
            int be = 0;

            foreach (var item in adatok)
            {
                if (item.bemegy == true)
                {
                    be += 1;
                }
                else if (item.bemegy == false)
                {
                    be -= 1;
                }
                beki.Add(be);
            }

            for (int i = 0; i < beki.Count; i++)
            {
                if (beki[i] == beki.Max())
                {
                    Console.WriteLine($"Például {adatok[i].ido} - kor voltak a legtöbben a társalgóban.");
                }
            }
        }

        static int F6()
        {
            Console.WriteLine("\n6. feladat: \nAdja meg a személy azonosítóját! ");
            int azon = Convert.ToInt32(Console.ReadLine());
            return azon;
        }

        static void F7(List<Ajto> adatok, int a)
        {
            Console.WriteLine("\n7. feladat: ");
            
            foreach (var item in adatok)
            {
                if (item.azon == a)
                {
                    if (item.bemegy == true)
                    {
                        Console.Write($"{item.ido} - ");
                    }
                    if(item.bemegy == false)
                    {
                        Console.Write($"{item.ido}\n");
                    }
                }
            }
        }

        static void F8(List<Ajto> adatok, int a)
        {
            Console.WriteLine("\n\n8. feladat: ");

            int kezdet = 0;
            int vege = 0;
            int eltelt = 0;
            int utolso = adatok.Last().ora * 60 + adatok.Last().perc;
            int eredmeny = 0;

            foreach (Ajto item in adatok)
            {
                if (item.azon == a && item.bemegy == true)
                {
                    kezdet = item.ora * 60 + item.perc;
                }
                if (item.azon == a && item.bemegy == false)
                {
                    vege = item.ora * 60 + item.perc;
                    eltelt += vege - kezdet;
                }
            }

            int i = adatok.Count - 1;
            while (adatok[i].azon != a)
            {
                i--;
            }

            if (adatok[i].bemegy)
            {
                eredmeny = (utolso - kezdet + 1) + eltelt;
                Console.Write($"A(z) {a}. személy összesen {eredmeny} percet volt bent,");
                Console.Write(" a megfigyelés végén a társalgóban volt. \n");      
            }
            else
            {
                eredmeny = eltelt;
                Console.Write($"A(z) {a}. személy összesen {eredmeny} percet volt bent,");
                Console.Write(" a megfigyelés végén NEM a társalgóban volt. \n");
            }
        }
    }
}
