using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utca
{
    internal class Program
    {
        static List<Haz> lista;
        static void Main(string[] args)
        {
            lista = new List<Haz>();
            Beolvas();
            F2();
            F3();
            F4();
            //F5();
            F6();
            Console.ReadKey();
        }

        static void Beolvas()
        {
            StreamReader file = new StreamReader("kerites.txt");
            while (!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(' ');
                lista.Add(new Haz(int.Parse(reszek[0]), int.Parse(reszek[1]), reszek[2]));
            }
            file.Close();
        }

        static void F2()
        {
            Console.WriteLine($"2. feladat:\nAz eladott telkek száma: {lista.Count}");
        }

        static void F3()
        {
            Console.WriteLine("\n3. feladat");
            var utolso = lista.Last();
            if (utolso.ParosParatlan)
            {
                Console.WriteLine("A páros oldalon adták el az utolsó telket.");
            }
            else
            { 
                Console.WriteLine("A páratlan oldalon adták el az utolsó telket.");
            }
            Console.WriteLine($"Az utolsó telek házszáma: {utolso.Hazszam(lista)}");
        }

        static void F4()
        {
            Console.WriteLine("\n4. feladat");
            List<int> hazszam = new List<int>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Festes != ":" && lista[i].Festes != "#")
                {
                    if (!lista[i].ParosParatlan)
                    {
                        if (lista[i].Festes == lista[i + 1].Festes || lista[i].Festes == lista[i - 1].Festes)
                        {
                            hazszam.Add(lista[i].Hazszam(lista));
                        }
                    }
                }
            }
            Console.WriteLine($"A szomszédossal egyezik a kerítés színe: {hazszam.First()}");
        }

        static void F5()
        {
            Console.WriteLine("\n5. feladat\nAdjon meg egy házszámot!");
            int hazszam = int.Parse(Console.ReadLine());
            var haz = lista.Find(x => x.Hazszam(lista) == hazszam);

            if (haz.Festes == ":")
            {
                Console.WriteLine("A kerítés színe / állapota: Nincs kész");
            }
            else if (haz.Festes == "#")
            {
                Console.WriteLine("A kerítés színe / állapota: Nincs festve");
            }
            else
            {
                Console.WriteLine($"A kerítés színe / állapota: {haz.Festes}");
            }

            string[] betuk = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z".Split(' ');
            Random rnd = new Random(betuk.Length);
            string randomSzin = betuk[rnd.Next(betuk.Length)];
            int index = lista.IndexOf(haz);

            while (randomSzin == lista[index].Festes || randomSzin == lista[index - 1].Festes || randomSzin == lista[index + 1].Festes)
            {
                randomSzin = betuk[rnd.Next(betuk.Length)];
            }
            Console.WriteLine($"Egy lehetséges festési szín: {randomSzin}");
        }

        static void F6()
        {
            Console.WriteLine("\n6. feladat:\nA szöveges állomány elkészült.");

            StreamWriter file = new StreamWriter("utcakep.txt");

            foreach (var item in lista)
            {
                if (!item.ParosParatlan)
                {
                    file.Write(new string(char.Parse(item.Festes), item.TelekSzelesseg));
                }
            }
            file.WriteLine();
            foreach (var item in lista)
            {
                if (!item.ParosParatlan)
                {
                    file.Write($"{item.Hazszam(lista)}" + new string(' ', item.TelekSzelesseg - 1));
                }
            }
            file.Close();
        }
    }
}
