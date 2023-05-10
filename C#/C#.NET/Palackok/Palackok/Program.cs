using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Palack p1 = new Palack("Őszibarack", 200, 150);
            Palack p5 = new Palack("Őszibarack", 200, 150);
            Palack p2 = new Palack("Sárgabarack", 200);
            Palack p3 = new Palack("Kóla", 500, 600);
            Palack p4 = new Palack("Szőke kóla", 350, 0);
            Visszavalthato v1 = new Visszavalthato("Alma kubu", 200, 150, 25);
            Visszavalthato v2 = new Visszavalthato("Sárgabarack", 200, 200, 60);
            Visszavalthato v3 = new Visszavalthato("Pezsgő", 400, 150, 90);
            Visszavalthato v4 = new Visszavalthato("Alma kubu", 200, 150, 25);

            Console.WriteLine(p1.Suly());
            Console.WriteLine(p2.Suly());
            Console.WriteLine(v3.Suly());
            Console.WriteLine(v4.Suly());
            Console.WriteLine(p5.Suly());
            Console.WriteLine(v3.Palackdij);
            Console.WriteLine(v4.Palackdij);

            Rekesz r1 = new Rekesz(1500);
            r1.Uj_palack(p1);
            r1.Uj_palack(p2);
            r1.Uj_palack(v3);
            r1.Uj_palack(v4);
            r1.Uj_palack(p5);
            Console.WriteLine(r1.Suly2());
            Console.WriteLine(r1.Osszes_penz());
        }
    }
}
