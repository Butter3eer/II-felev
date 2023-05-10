using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helyzet helyzet1 = new Helyzet(4, 5);
            Helyzet helyzet2 = new Helyzet(5, 6);
            Harcos harcos1 = new Harcos("Kecske", helyzet1, "piros");
            Ijasz harcos2 = new Ijasz("Liba", helyzet2, "kék", 10);

            Csatater csatater = new Csatater();
            csatater.ListaHarcos(harcos1);
            csatater.ListaHarcos(harcos2);
            csatater.Harc(2);

            Console.WriteLine(harcos1);
            Console.WriteLine(harcos2);
        }
    }
}
