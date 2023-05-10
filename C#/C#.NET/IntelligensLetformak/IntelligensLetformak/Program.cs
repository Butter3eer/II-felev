using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligensLetformak;

namespace IntelligensLetformakFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntelligensLetforma AI1 = new DullTherapist();
            IntelligensLetforma AI2 = new LazyTherapist();
            IntelligensLetforma AI3 = new Parrot();

            Console.WriteLine("Írj valamit a DullTherapistnak:");
            string szoveg1 = Console.ReadLine();
            AI1.Kommunikacio(szoveg1);

            Console.WriteLine("\nÍrj valamit a LazyTherapistnak:");
            string szoveg2 = Console.ReadLine();
            AI2.Kommunikacio(szoveg2);

            Console.WriteLine("\nÍrj valamit a Parrotnak:");
            string szoveg3 = Console.ReadLine();
            AI3.Kommunikacio(szoveg3);
        }
    }
}
