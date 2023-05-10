using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haziallatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Haziallat> lista = new List<Haziallat>
            {
                new Kutya("Bendzsi", 69),
                new Macska("Tomi", 42, 100),
                new Kutya("Detti", 36),
                new Macska("Garfield", 1, 420),
                new Macska("Macska", 70, 30)
            };
            foreach (var item in lista)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
