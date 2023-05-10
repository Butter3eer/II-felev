using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    internal class Program
    {
        static List <int> szamok = new List <int> ();

        static void Feltolt(int n)
        {
            Random r = new Random ();
            for (int i = 0; i < n; i++)
            {
                szamok.Add(r.Next(100) + 1);
            }
        }

        static void Kiir(List <int> Lista)
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine(Lista[i]);
            }
        }

        static void Foreach(List<int> lista)
        {
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
        }

        static void Negyzetelo(int meddig)
        {
            for (int i = 1; i <= meddig; i++)
            {
                Console.WriteLine(i + "*" + i + "=" + i * i);
            }
        }

        static void Allotto()
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rnd.Next(10));
            }
        }

        static void Main(string[] args)
        {
            Negyzetelo(20);
            Allotto();
            Feltolt(20);
            Kiir(szamok);
        }
    }
}
