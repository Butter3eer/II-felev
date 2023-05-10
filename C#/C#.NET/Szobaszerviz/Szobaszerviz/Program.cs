using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szobaszerviz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szoba> szobak = new List<Szoba>();
            for (int i = 0; i < 20; i++)
            {
                szobak.Add(new Szoba(i));
            }
            List<SzobaSzervíz> szobaszervizek = new List<SzobaSzervíz>();
            szobaszervizek.Add(new SzobaSzervíz(false, false));
            szobaszervizek.Add(new SzobaSzervíz(false, true));
            szobaszervizek.Add(new SzobaSzervíz(true, false));
            szobaszervizek.Add(new SzobaSzervíz(true, true));

            Hotel hungesHotel = new Hotel(szobak);

            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int veletlen = r.Next(0, 4);
                szobak[i].Foglalas(szobaszervizek[veletlen]);
            }

            Console.WriteLine($"A vendégektől származó ősszbevétel: {hungesHotel.Kifizetesek()}");
            Console.WriteLine("A szabad szobák: ");
            foreach (var item in hungesHotel.SzabadSzobak())
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
