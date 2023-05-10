using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int korte = 5;
            Console.WriteLine(korte);
            korte ++;
            Console.WriteLine(korte);
            korte += 5;
            Console.WriteLine(korte);
            korte -= 1;
            Console.WriteLine(korte);
            korte -= 3;
            Console.WriteLine(korte);
            korte *= 4;
            Console.WriteLine(korte);
            korte /= 2;
            Console.WriteLine(korte);
            korte %= 2;
            Console.WriteLine(korte);

            Console.ReadKey();
        }
    }
}
