using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KarakterDekodolo
{
    internal class Feladatok
    {
        private List<Karakter> bank;
        private List<Karakter> dekodol;
        private char bekertAdat;

        public Feladatok()
        {
            bank = Beolvas("bank.txt");
            dekodol = Beolvas("dekodol.txt");
            Console.WriteLine("Bank: ");
            Kiir(bank);
            Console.WriteLine("Dekódol: ");
            Kiir(dekodol);
            F6();
            F7();
            F9();
        }

        private List<Karakter> Beolvas(string fileName)
        {
            List<Karakter> lista = new List<Karakter>();
            StreamReader file = new StreamReader(fileName);

            while (!file.EndOfStream)
            {
                char karakter = file.ReadLine()[0];
                int[,] matrix = new int[7, 4];
                for (int i = 0; i < 7; i++)
                {
                    char[] adatok = file.ReadLine().ToCharArray();
                    for (int j = 0; j < adatok.Length; j++)
                    {
                        matrix[i, j] = int.Parse("" + adatok[j]);
                    }
                }
                lista.Add(new Karakter(karakter, matrix));
            }
            return lista;
        }

        private void Kiir(List<Karakter> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        private void F6()
        {
            do
            {
                Console.WriteLine("6. feladat: Kérem adjon meg egy betűt: ");
                bekertAdat = Console.ReadLine()[0];
            } while (!HelyesE(bekertAdat));
        }

        private bool HelyesE(char bekertAdat)
        {
            if (bekertAdat < 'A' || bekertAdat > 'Z')
            {
                return false;
            }
            else
            {
                return true;
            }            
        }

        private void F7()
        {
            bool megvan = false;
            foreach (var item in bank)
            {
                if (item.Betu == bekertAdat)
                {
                    Console.WriteLine(item);
                    megvan = true;
                    break;
                }
            }

            if (!megvan)
            {
                Console.WriteLine("Nincs ilyen karakter.");
            }
        }

        private void F9()
        {
            foreach (var masik in dekodol)
            {
                bool van = false;
                foreach (var item in bank)
                {
                    if (item.Felismer(masik))
                    {
                        Console.Write(item.Betu);
                        van = true;
                    }
                }
                if (!van)
                {
                    Console.Write("?");
                }
            }
        }
    }
}
