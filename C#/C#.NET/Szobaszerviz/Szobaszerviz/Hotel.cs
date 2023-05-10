using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szobaszerviz
{
    internal class Hotel
    {
        private List<Szoba> szobak;

        public Hotel(List<Szoba> szobak)
        {
            this.szobak = szobak;
        }

        public void Foglalas(int szobaSzam, SzobaSzervíz szervíz)
        {
            Szoba sz = Kereses(szobaSzam);
            if (sz == null)
            {
                Console.WriteLine("Nincs ilyen szoba.");
            }
            else
            {
                sz.Foglalas(szervíz);
            }
        }

        private Szoba Kereses(int szobaSzam)
        {
            int db = 0;
            Szoba sz = null;
            while (db < szobak.Count && szobak[db].Szobaszam == szobaSzam)
            {
                db++;
            }
            if (db < szobak.Count)
            {
                sz = szobak[db];
            }

            return sz;
        }

        public List<int> SzabadSzobak()
        {
            List<int> szabadSzobak = new List<int>();

            foreach (var item in this.szobak)
            {
                if (!item.FoglaltE)
                {
                    szabadSzobak.Add(item.Szobaszam + 1);
                }
            }
            return szabadSzobak;
        }

        public long Kifizetesek()
        {
            long osszeg = 0;
            foreach (var item in this.szobak)
            {
                osszeg += 2 * (item.Fizetes());
            }
            return osszeg;
        }

        public bool SzabadLakosztaly()
        {
            foreach (var item in this.szobak)
            {
                if (item is Lakosztály)
                {
                    if ((item as Lakosztály).FoglaltE)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
