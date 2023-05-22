using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirintus
{
    internal class LabSim
    {
        private List<string> Adatsorok;
        private char[,] Lab;

        public LabSim(string fileName)
        {
            Adatsorok = new List<string>();
            BeolvasAdatsorok(fileName);
            Lab = new char[SorokSzama, OszlopokSzama];
            FeltoltLab();
        }

        private void BeolvasAdatsorok(string forras)
        {
            StreamReader file = new StreamReader(forras);
            while (!file.EndOfStream)
            {
                Adatsorok.Add(file.ReadLine());
            }
            file.Close();
        }

        public int OszlopokSzama
        {
            get
            {
                return Adatsorok[0].Length;
            }
        }

        public int SorokSzama
        {
            get
            {
                return Adatsorok.Count;
            }
        }

        private void FeltoltLab()
        {
            for (int i = 0; i < SorokSzama; i++)
            {
                for (int j = 0; j < OszlopokSzama; j++)
                {
                    Lab[i, j] = Adatsorok[i].ToCharArray()[j];
                }
            }
        }

        public void KiirLab()
        {
            for (int i = 0; i < SorokSzama; i++)
            {
                for (int j = 0; j < OszlopokSzama; j++)
                {
                    Console.Write(Lab[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void Utkereses()
        {
            KeresesKesz = false;
            NincsMegoldas = false;
            int r = 1;
            int c = 0;
            while (!KeresesKesz && !NincsMegoldas)
            {
                Lab[r, c] = 'O';
                if (Lab[r, c + 1] == ' ')
                {
                    c++;
                }
                else if (Lab[r + 1, c] == ' ')
                {
                    r++;
                }
                else
                {
                    Lab[r, c] = '-';
                    if (Lab[r, c - 1] == 'O')
                    {
                        c--;
                    }
                    else
                    {
                        r--;
                    }
                }

                KeresesKesz = r == KijaratSorIndex && c == KijaratOszlopIndex;

                if (KeresesKesz)
                {
                    Lab[r, c] = 'O';
                }

                NincsMegoldas = r == 1 && c == 0;
                KiirLab();
                Console.ReadKey();
            }
        }
        public bool KeresesKesz { get; set; }

        public int KijaratOszlopIndex
        {
            get
            {
                return Lab.GetLength(1) - 2;
            }
        }

        public int KijaratSorIndex
        {
            get
            {
                return Lab.GetLength(0) - 2;
            }
        }

        public bool NincsMegoldas { get; set; }
    }
}
