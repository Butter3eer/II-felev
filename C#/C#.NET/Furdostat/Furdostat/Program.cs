using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Furdostat
{
    internal class Program
    {
        static List<Vendegek> lista;
        static List<int> kulonVendeg;
        static void Main(string[] args)
        {
            lista = new List<Vendegek>();
            kulonVendeg = new List<int>();
            Beolvas();
            KulonVendegFeltolt();
            F2();
            F3();
            F4();
            F5();
            F6();
            F7();
        }
        private static void KulonVendegFeltolt()
        {
            foreach (var item in lista)
            {
                if (!kulonVendeg.Contains(item.VendegAzon))
                {
                    kulonVendeg.Add(item.VendegAzon);
                }
            }
        }

        private static void F7()
        {
            Console.WriteLine("\n7. feladat");

            int dbU = 0;
            int dbSz = 0;
            int dbGy = 0;
            int dbS = 0;

            foreach (var vendeg in kulonVendeg)
            {
                if (lista.Find(x => x.VendegAzon == vendeg && x.ReszlegAzon == 1 && x.beKiBool == true) != null)
                {
                    dbU++;
                }
                if (lista.Find(x => x.VendegAzon == vendeg && x.ReszlegAzon == 2 && x.beKiBool == true) != null)
                {
                    dbSz++;
                }
                if (lista.Find(x => x.VendegAzon == vendeg && x.ReszlegAzon == 3 && x.beKiBool == true) != null)
                {
                    dbGy++;
                }
                if (lista.Find(x => x.VendegAzon == vendeg && x.ReszlegAzon == 4 && x.beKiBool == true) != null)
                {
                    dbS++;
                }
            }
            Console.WriteLine($"Uszoda: {dbU}");
            Console.WriteLine($"Szaunák: {dbSz}");
            Console.WriteLine($"Gyógyvizes medencék: {dbGy}");
            Console.WriteLine($"Strand: {dbS}");
        }

        private static void F6()
        {
            Console.WriteLine("\n6. feladat\nA szöveges file elkészült.");
            StreamWriter file = new StreamWriter("szauna.txt");

            List<double> idotartamok = new List<double>();

            foreach (var item in kulonVendeg)
            {
                foreach (var person in lista)
                {
                    if (person.VendegAzon == item && person.beKiBool == true && person.ReszlegAzon == 2)
                    {
                        DateTime bemegy = person.Idopont;
                        DateTime kimegy = lista.FindLast(x => x.VendegAzon == item && x.ReszlegAzon == 2).Idopont;
                        TimeSpan eltelt = TimeSpan.FromSeconds(kimegy.Subtract(bemegy).TotalSeconds);
                        file.WriteLine($"{item} {eltelt}");
                    }
                }
            }
            file.Close();
        }

        private static void F5()
        {
            Console.WriteLine("\n 5. feladat");
            int db69 = 0;
            int db916 = 0;
            int db1620 = 0;

            foreach (var item in lista)
            {
                if (item.Idopont.Hour >= 6 && item.Idopont.Hour < 9 && item.beKiBool == false && item.ReszlegAzon == 0)
                {
                    db69++;
                }
                else if (item.Idopont.Hour >= 9 && item.Idopont.Hour < 16 && item.beKiBool == false && item.ReszlegAzon == 0)
                {
                    db916++;
                }
                else if (item.Idopont.Hour >= 16 && item.Idopont.Hour < 20 && item.beKiBool == false && item.ReszlegAzon == 0)
                {
                    db1620++;
                }
            }
            Console.WriteLine($"6-9 óra között {db69} vendég");
            Console.WriteLine($"9-16 óra között {db916} vendég");
            Console.WriteLine($"16-20 óra között {db1620} vendég");
        }

        private static void F4()
        {
            Console.WriteLine("\n4. feladat");

            List<double> idotartamok = new List<double>();

            foreach (var item in kulonVendeg)
            {
                DateTime bemegy = lista.Find(x => x.VendegAzon == item && x.ReszlegAzon == 0).Idopont;
                DateTime kimegy = lista.FindLast(x => x.VendegAzon == item && x.ReszlegAzon == 0).Idopont;
                idotartamok.Add(kimegy.Subtract(bemegy).TotalSeconds);
            }

            var legnagyobbAzon = kulonVendeg[idotartamok.IndexOf(idotartamok.Max())];
            TimeSpan eltelt = TimeSpan.FromSeconds(idotartamok.Max());
            Console.WriteLine($"A legtöbb időt eltöltő vendég:\n {legnagyobbAzon}. vendég {eltelt}");
        }

        private static void F3()
        {
            Console.WriteLine("\n3. feladat");
            int db = 0;

            foreach (var item in kulonVendeg)
            {
                List<Vendegek> ideiglenes = lista.FindAll(x => x.VendegAzon == item);
                if (ideiglenes.Count == 4)
                {
                    db++;
                }
                ideiglenes.Clear();
            }
            Console.WriteLine($"A fürdőben {db} vendég járt csak egy részlegen.");
        }

        private static void F2()
        {
            Console.WriteLine("2. feladat");
            var utolsoVendeg = lista.FindLast(x => x.ReszlegAzon == 0 && x.beKiBool == false);
            Console.WriteLine($"Az első vendég {lista.Find(x => x.beKiBool == false).Idopont} lépett ki az öltözőből.");
            Console.WriteLine($"Az utolsó vendég {utolsoVendeg.Idopont} lépett ki az öltözőből.");
        }

        static void Beolvas()
        {
            StreamReader file = new StreamReader("furdoadat.txt");
            while (!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(' ');
                lista.Add(new Vendegek(int.Parse(reszek[0]), int.Parse(reszek[1]), int.Parse(reszek[2]), double.Parse(reszek[3]), double.Parse(reszek[4]), double.Parse(reszek[5])));
            }
            file.Close();
        }
    }
}
