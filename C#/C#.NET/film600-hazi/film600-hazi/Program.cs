using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace film600_hazi
{
    class Film
    {
        private string title;
        private int helyezes;
        private int year;
        private int hossz;
        private List<string> genres;
        private double imdbRate;
        private string content;
        private string director;
        private List<string> szereplok;

        public List<string> Genres
        {
            get { return genres; }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < szereplok.Count; i++)
            {
                if (i == szereplok.Count - 1)
                {
                    s += szereplok[i];
                }
                else
                {
                    s += szereplok[i] + ", ";
                }
            }

            return $"{title} Rendezte: {director} IMDB: {imdbRate} ({s})";
        }

        public Film(string sor)
        {
            string[] temp = sor.Split(';');
            title = temp[0];
            helyezes = Convert.ToInt32(temp[3].Replace(".", ""));
            year = Convert.ToInt32(temp[4]);
            hossz = Convert.ToInt32(temp[6].Replace(" min", ""));
            //genres = new List<string>();
            genres = temp[7].Split(',').ToList();
            imdbRate = Convert.ToDouble(temp[8].Replace(",", "."));
            content = temp[9];
            director = temp[11];
            szereplok = new List<string>();
            szereplok.Add(temp[13]);
            szereplok.Add(temp[15]);
            szereplok.Add(temp[17]);
            szereplok.Add(temp[19]);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Beolvas();
            Kiir();
        }

        static List<Film> filmek = new List<Film>();

        static void Beolvas()
        {
            StreamReader file = new StreamReader("filmek.csv");
            file.ReadLine();
            while (!file.EndOfStream)
            {
                filmek.Add(new Film(file.ReadLine()));
            }
            file.Close();
        }

        static void Kiir()
        {
            Console.WriteLine("Mit?");
            String mit = Console.ReadLine();

            foreach (var item in filmek)
            {
                if (item.Genres.Contains(mit))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
