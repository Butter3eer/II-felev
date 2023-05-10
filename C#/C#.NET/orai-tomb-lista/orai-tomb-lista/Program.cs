using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace orai_tomb_lista
{
    internal class Program
    {
        static List<int> szamok = new List<int>();
        static List<int> nagySzamok = new List<int>();

        static void Main(string[] args)
        {
            F1();
            F2();
            F3();
            F4();
            F5();
            F6();
            F7();
            F8();
        }

        static void F1()
        {
            StreamReader sr = new StreamReader("szamok.txt", true);

            while (!sr.EndOfStream)
            {
                szamok.Add(Convert.ToInt32(sr.ReadLine()));
            }
            sr.Close();
            Kiir(szamok);
        }

        static void Kiir(List<int> szamok)
        {
            Console.WriteLine("1. feladat: ");
            foreach (var item in szamok)
            {
                Console.WriteLine(item);
            }
        }

        static void F2()
        {
            Console.WriteLine("\n2. feladat: ");
            Console.WriteLine(szamok.Max());
        }

        static void F3()
        {
            Console.WriteLine("3. feladat: nagyok.txt");
            StreamWriter sw = new StreamWriter("nagyok.txt", true);
            nagySzamok = szamok.FindAll(x => x > 50);

            foreach (var item in nagySzamok)
            {
                sw.WriteLine(item);
            }

            sw.Close();
        }
        
        static void F4()
        {
            int ossz = 0;

            foreach (var item in szamok)
            {
                if (item < 50)
                {
                    ossz += item;
                }
            }

            Console.WriteLine("\n4. feladat:\n" + ossz);
        }

        static void F5()
        {
            Console.WriteLine("\n5. feladat:");
            int ossz2 = 0;

            foreach (var item in szamok)
            {
                ossz2 += item;
            }

            float eredmeny = ossz2 / szamok.Count();
            Console.WriteLine(eredmeny);
        }

        static void F6()
        {
            Console.WriteLine("\n6. feladat: ");
            List<int> harom = new List<int>();

            foreach (var item in szamok)
            {
                harom = szamok.FindAll(x => x % 3 == 0);
            }

            foreach (var item in harom)
            {
                Console.Write(item + ",");
            }

            Console.WriteLine("\nA hossza a 3-al osztható számos listának: " + harom.Count());
        }

        static void F7()
        {
            Console.WriteLine("\n7. feladat: ");
            List<int> szamok2 = szamok;

            for (int i = 0; i < szamok.Count(); i++)
            {
                if (szamok[i] == 0)
                {
                    szamok[i] = 1;
                }
            }

            foreach (var item in szamok2)
            {
                Console.WriteLine(item);
            }
        }

        static void F8()
        {
            Console.WriteLine("\n8. feladat: ");
            Console.WriteLine("Szám 1 - 100 között: ");
            int szam = int.Parse(Console.ReadLine());

            while (szam >= 100 || szam <= 1)
            {
                Console.WriteLine("Próbáld újra: ");
                szam = int.Parse(Console.ReadLine());
            }

            int db = szamok.Count(x => x == szam);
            Console.WriteLine("Megadott szám db: " + db);

            Console.WriteLine("Megadott szám indexei: ");
            for (int i = 0; i < szamok.Count(); i++)
            {
                if (szamok[i] == szam)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
