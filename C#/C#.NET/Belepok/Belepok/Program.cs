using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belepok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jegy j1 = new Jegy("délutáni", "egyszeri");
            Latogatok e1 = new Latogatok(j1);
            Console.WriteLine(e1.ToString());
        }
    }
}
