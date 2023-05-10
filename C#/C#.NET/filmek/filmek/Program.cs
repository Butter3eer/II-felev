using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filmek
{
    class Film
    {
        private string title;
        private string director;
        private List<string> stars = new List<string>();
        private List<string> genres = new List<string>();
        private int time;
        private int year;

        public string Title { get => title; }

        public Film(string title, string director, List<string> stars, List<string> genres, int time, int year)
        {
            this.title = title;
            this.director = director;
            this.stars = stars;
            this.genres = genres;
            this.time = time;
            this.year = year;
        }

        public Film(string title)
        {
            this.title = title;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Film f = new Film("K.O.");
            Console.WriteLine(f.Title);
        }
    }
}
