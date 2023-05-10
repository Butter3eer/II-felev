using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pekseg
{
    internal class Pekseg
    {
        static List<Arlap> lista;
        static void Main(string[] args)
        {
            lista = new List<Arlap>();
            Console.WriteLine("Adja meg a fájl elérési útvonalát: ");
            string fajlUtvonal = Console.ReadLine();
            Vasarlok(fajlUtvonal);
            etelLeltar();
        }

        static void Vasarlok(string fajlUtvonal)
        {
            StreamReader file = new StreamReader(fajlUtvonal);

            while (!file.EndOfStream)
            {
                string[] sor = file.ReadLine().Split(' ');
                if (sor[0] == "Kave")
                {
                    if (sor[1] == "habos")
                    {
                        lista.Add(new Kave(true));
                    }
                    else
                    {
                        lista.Add(new Kave(false));
                    }
                }
                else
                {
                    lista.Add(new Pogacsa(float.Parse(sor[1]), float.Parse(sor[2])));
                }
            }
            file.Close();
        }

        static void etelLeltar()
        {
            StreamWriter file = new StreamWriter("leltar.txt");
            foreach (var item in lista)
            {
                if (item is Pogacsa)
                {
                    file.WriteLine(item.ToString());
                }
            }
            file.Close();
        }
    }
}
