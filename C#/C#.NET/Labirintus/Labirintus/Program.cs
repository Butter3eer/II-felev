using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirintus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LabSim obj = new LabSim("Lab1.txt");
            obj.KiirLab();
            Console.WriteLine("-------------------------------");
            obj.Utkereses();
        }
    }
}
