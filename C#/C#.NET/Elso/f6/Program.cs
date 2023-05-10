using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alma = 10;

            Console.WriteLine(alma + "\nalma");
            Console.WriteLine(2 * alma);
            Console.WriteLine(alma - 2);
            Console.WriteLine(alma / 2);
            Console.WriteLine(alma * alma);
            Console.WriteLine($"{alma % 2}\n{alma % 3}\n{alma % 5}");

            Console.ReadKey();

        }
    }
}
