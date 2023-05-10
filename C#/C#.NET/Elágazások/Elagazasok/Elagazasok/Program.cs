using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elagazasok
{
    internal class Program
    {
        static void ertekel(int ertek)
        {
            if (ertek > 10)
            {
                Console.WriteLine("A vizsga sikerült");
            }
            else
            {
                Console.WriteLine("A vizgsa sajna nem sikerült");
            }
        }


        static void Main(string[] args)
        {
            ertekel(11);
            Console.ReadKey();
        }
    }
}
