using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajlmuveletek
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static List<int> szamok = new List<int>();

        static void Feltolt(int n)
        {
            Random r = new Random();
            szamok.Clear();
            for (int i = 0; i < n; i++)
            {
                szamok.Add(r.Next(100));
            }
        }

        static void fajlbaIr(List<int> szamok)
        {
            StreamWriter sw = new StreamWriter("szamok.txt");

            foreach (int item in szamok)
            {
                sw.WriteLine(item);
            }

            sw.Close();
        }
    }
}
