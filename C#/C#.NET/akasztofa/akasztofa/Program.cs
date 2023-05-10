using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akasztofa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();

            Console.WriteLine("\n");
        }

        static List<string> filmek = new List<string>();
        static List<int> ascii = new List<int>();
        static List<char> szo = new List<char>();
        static List<char> ism = new List<char>();

        static void KiirSzo()
        {
            foreach (var betuk in szo)
            {
                Console.Write(betuk + " ");
            }
        }

        static void Start()
        {
            Console.WriteLine("Akasztófa játék! ");

            StreamReader sr = new StreamReader("filmekangol.txt");
            while (!sr.EndOfStream)
            {
                filmek.Add(Convert.ToString(sr.ReadLine()));
            }

            Random rnd = new Random();
            int index = rnd.Next(filmek.Count);
            string randFilm = filmek[index];

            int elet = randFilm.Length;
            Console.WriteLine($"Össz élet: " + elet);

            foreach (var betu in randFilm)
            {
                ascii.Add((int)betu);
            }

            for (int i = 0; i < ascii.Count; i++)
            {
                if ((ascii[i] >= 48 && ascii[i] <= 57) || (ascii[i] >= 65 && ascii[i] <= 90) || (ascii[i] >= 97 && ascii[i] <= 122))
                {
                    szo.Add('_');
                }
                else
                {
                    szo.Add(Convert.ToChar(ascii[i]));
                }
            }

            KiirSzo();

            Console.WriteLine("\n(Ellenőrzéshez)" + randFilm);

            Console.WriteLine("\n\nBetű tipp: ");
            char tipp = Convert.ToChar(Console.ReadLine());

            while (elet != 0)
            {
                if (!randFilm.Contains(tipp))
                {
                    KiirSzo();

                    elet -= 1;
                    Console.WriteLine("Maradék élet: " + elet);

                    Console.WriteLine("\nÚj tipp: ");
                    tipp = Convert.ToChar(Console.ReadLine());
                }

                if (randFilm.Contains(tipp))
                {
                    do
                    {
                        for (int i = 0; i < randFilm.Length; i++)
                        {
                            ism.Add(randFilm[i]);
                        }

                        for (int i = 0; i < randFilm.Length; i++)
                        {
                            if (randFilm[i] == tipp)
                            {
                                szo[i] = tipp;
                            }
                        }

                        KiirSzo();

                        Console.WriteLine("\nÚj tipp: ");
                        tipp = Convert.ToChar(Console.ReadLine());

                    } while (szo.Contains('_'));
                }
            }
            Console.WriteLine("GRATULÁLOK!");
        }
    }
}//elnézést, de egyedül eddig jutottam egyelőre
