using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmek_feladat
{
    internal class Program
    {
        static List<Film> lista;
        static void Main(string[] args)
        {
            lista = new List<Film>();
            Beolvas();
            //F2();
            //F4();
            //F5();
            //F6();
            //F7();
            //F8();
            EVszamAlapajanFilm("2017");
            SzoAlapjanFilm("Pók");
            BevetelEvszammal("2019", 1000000);
        }

        static void Beolvas()
        {
            StreamReader file = new StreamReader("filmek.txt");
            while (!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(';');
                lista.Add(new Film(reszek[0], reszek[1], Convert.ToInt64(reszek[2])));
            }
        }

        static void F2()
        {
            Film nagyBevetel = lista.Find(x => x.Bevetel == lista.Max(y => y.Bevetel));
            Console.WriteLine($"A legnagyobb bevételű film:\n {nagyBevetel.Cim} : {nagyBevetel.KiadEv}, {nagyBevetel.Bevetel}");
        }

        static void F4()
        {
            Console.WriteLine("\nAz összes 2019-ben megjelent film:");
            List<Film> egyEvFilmek = lista.FindAll(x => x.KiadEv == "2019");
            foreach (var item in egyEvFilmek)
            {
                Console.WriteLine("\t" + item.Cim);
            }
        }

        static void F5()
        {
            Console.WriteLine("\nAz összes film, ami címében szerepel a Harcos vagy Harcosok szó: ");
            List<Film> filmcimek = lista.FindAll(x => x.Cim.Contains("Harcos") || x.Cim.Contains("Harcosok"));
            foreach (var item in filmcimek)
            {
                Console.WriteLine("\t" + item.Cim);
            }
        }

        static void F6()
        {
            Console.WriteLine("\nAz összes film aminek bevétele legalább 1 milliárd: ");
            List<Film> egyMilliard = lista.FindAll(x => x.Bevetel >= 1000000000);
            foreach (var item in egyMilliard)
            {
                Console.WriteLine("\t" + item.Cim);
            }
        }

        static void F7()
        {
            Console.WriteLine("\nAz összes film aminek címe több mint 20 character: ");
            List<Film> filmcimek = lista.FindAll(x => x.Cim.Length > 20);
            foreach (var item in filmcimek)
            {
                Console.WriteLine("\t" + item.Cim);
            }
        }

        static void F8()
        {
            Film nagyBevetel = lista.Find(x => x.Bevetel == lista.Min(y => y.Bevetel));
            Console.WriteLine($"A legrosszabb bevételű film:\n {nagyBevetel.Cim} : {nagyBevetel.KiadEv}, {nagyBevetel.Bevetel}");
        }

        static void EVszamAlapajanFilm(string evszam)
        {
            Console.WriteLine($"\nAz összes {evszam}-ben megjelent film:");
            var filmek = lista.FindAll(x => x.KiadEv == evszam);
            foreach (var item in filmek)
            {
                Console.WriteLine("\t" + item.Cim);
            }
        }

        static void SzoAlapjanFilm(string szo)
        {
            Console.WriteLine($"\nAz összes film, ami címében szerepel a {szo} szó: ");
            List<Film> filmcimek = lista.FindAll(x => x.Cim.Contains(szo));
            foreach (var item in filmcimek)
            {
                Console.WriteLine("\t" + item.Cim);
            }
        }

        static void BevetelEvszammal(string evszam, int osszeg)
        {
            Console.WriteLine($"\nFilmek, melyek bevétele meghaladja a {osszeg} összeget {evszam} évben: ");
            List<Film> filmcimek = lista.FindAll(x => x.KiadEv == evszam && x.Bevetel > osszeg);
            foreach (var item in filmcimek)
            {
                Console.WriteLine("\t" + item.Cim);
            }
        }
    }
}
