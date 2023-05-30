using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_szinek
{
    internal class Feladatok
    {
        int sorokSzama = 360;
        int oszlopokSzama = 640;
        Pont[,] matrix;

        public Feladatok()
        {
            matrix = new Pont[sorokSzama, oszlopokSzama];
            Beolvas();
            //F2();
            F3();
            F4();
            F6();
        }

        private void Beolvas()
        {
            StreamReader file = new StreamReader("kep.txt");

            for (int i = 0; i < sorokSzama; i++)
            {
                string[] adatok = file.ReadLine().Split(' ');
                int matrixIndex = 0;
                for (int j = 0; j < adatok.Length; j+=3)
                {
                    int piros = int.Parse(adatok[j]);
                    int zold = int.Parse(adatok[j + 1]);
                    int kek = int.Parse(adatok[j + 2]);

                    Pont pont = new Pont(piros, zold, kek);
                    matrix[i, matrixIndex] = pont;
                    matrixIndex++;
                }
            }
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write($"{matrix[i, j].Piros} - {matrix[i, j].Zold} - {matrix[i, j].Kek}\t");
            //    }
            //    Console.WriteLine();
            //}
        }

        private void F2()
        {
            Console.WriteLine("2. feladat:\nKérem egy képpont adatait!");

            Console.WriteLine("sor: ");
            int sor = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("oszlop: ");
            int oszlop = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine($"A képpont színe RGB({matrix[sor, oszlop].Piros},{matrix[sor, oszlop].Zold},{matrix[sor, oszlop].Kek})");
        }

        private void F3()
        {
            int db = 0;
            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    if (matrix[i, j].VilagosE)
                    {
                        db++;
                    }
                }
            }
            Console.WriteLine($"\n3. feladat:\nA világos képpontok száma: {db}");
        }

        private void F4()
        {
            Pont min = matrix[0, 0];

            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    if (min.OsszErtek > matrix[i, j].OsszErtek)
                    {
                        min = matrix[i, j];
                    }
                }
            }

            Console.WriteLine($"\n4. feladat:\nA legsötétebb pont RGB összege: {min.OsszErtek}\nA legsötétebb pixelek színe: ");

            for (int i = 0; i < sorokSzama; i++)
            {
                for (int j = 0; j < oszlopokSzama; j++)
                {
                    if (min.OsszErtek == matrix[i, j].OsszErtek)
                    {
                        Console.WriteLine($"RGB({matrix[i, j].Piros},{matrix[i, j].Zold},{matrix[i, j].Kek})");
                    }
                }
            }
        }

        private bool Hatar(int i, int kulombseg)
        {
            for (int j = 0; j < oszlopokSzama - 1; j++)
            {
                if (Math.Abs(matrix[i, j].Kek - matrix[i, j + 1].Kek) > kulombseg)
                {
                    return true;
                }
            }
            return false;
        }

        private void F6()
        {
            Console.WriteLine($"\n6. feladat:");
            for (int i = 0; i < sorokSzama; i++)
            {
                if (Hatar(i, 10))
                {
                    Console.WriteLine($"A felhő legfelső sora: {i + 1}");
                    i = sorokSzama;
                }
            }

            for (int i = sorokSzama - 1; i > 0; i--)
            {
                if (Hatar(i, 10))
                {
                    Console.WriteLine($"A felhő legalsó sora {i + 1}");
                    i = 0;
                }      
            }
        }
    }
}
