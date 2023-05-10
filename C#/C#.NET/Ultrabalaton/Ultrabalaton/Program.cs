using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Ultrabalaton
{
    internal class Program
    {
        static List<Verseny> lista;
        static void Main(string[] args)
        {
            lista = new List<Verseny>();
            Beolvas();
            F3();
            F4();
            //F5();
            F7();
            F8();
        }

        static void Beolvas()
        {
            StreamReader file = new StreamReader("ub2017egyeni.txt");
            file.ReadLine();
            while (!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(';');
                lista.Add(new Verseny(reszek[0], int.Parse(reszek[1]), reszek[2], reszek[3], int.Parse(reszek[4])));
            }
        }

        static void F3()
        {
            Console.WriteLine($"3. Feladat: Egyéni indulók: {lista.Count} fő");
        }

        static void F4()
        {
            int db = lista.Count(x => x.BefejezettTav == 100 && x.Kategoria == "Noi");
            Console.WriteLine($"4. feladat: Célba érkező női sportolók: {db} fő");
        }

        static void F5()
        {
            Console.WriteLine("5. feladat: Kérem a sportoló nevét: ");
            string valasz = Console.ReadLine();
            var versenyzo = lista.Find(x => x.VersenyzoNeve == valasz);
            string igenNem = "";

            if (versenyzo == null)
            {
                Console.WriteLine("\tIndult egyéniben a sportoló? Nem");
            }
            else
            {
                if (versenyzo.BefejezettTav == 100)
                {
                    igenNem = "Igen";
                }
                else
                {
                    igenNem = "Nem";
                }
                Console.WriteLine($"\tIndult egyéniben a sportoló? Igen\n\tTeljesítette az egész távot? {igenNem}");
            }
        }

        static void F7()
        {
            int db = 0;
            double sum = 0;
            foreach ( var item in lista )
            {
                if (item.Kategoria == "Ferfi" && item.BefejezettTav == 100)
                {
                    db++;
                    sum += item.IdoOraban;
                }
            }
            Console.WriteLine($"7. feladat: Átlagos idő: {sum / db} óra");
        }

        static void F8()
        {
            List<Verseny> listaSrotedNoi = lista.FindAll(x => x.BefejezettTav == 100 && x.Kategoria == "Noi");
            var minNoi = listaSrotedNoi.Min(y => y.IdoOraban);
            List<Verseny> listaSrotedFerfi = lista.FindAll(x => x.BefejezettTav == 100 && x.Kategoria == "Ferfi");
            var minFerfi = listaSrotedFerfi.Min(y => y.IdoOraban);

            var noiWin = lista.Find(x => x.Kategoria == "Noi" && x.BefejezettTav == 100 && x.IdoOraban == minNoi);
            var ferfiWin = lista.Find(x => x.Kategoria == "Ferfi" && x.BefejezettTav == 100 && x.IdoOraban == minFerfi);

            Console.WriteLine($"8. feladat: Verseny Győztesei\n\tNők: {noiWin.VersenyzoNeve} ({noiWin.RajtSzam}) - {noiWin.ElertIdo}");
            Console.WriteLine($"\tFérfiak: {ferfiWin.VersenyzoNeve} ({ferfiWin.RajtSzam}) - {ferfiWin.ElertIdo}");
        }
    }
}
