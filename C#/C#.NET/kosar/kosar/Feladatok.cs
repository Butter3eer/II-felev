using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace kosar
{
    internal class Feladatok
    {
        private List<Merkozes> lista;

        public Feladatok()
        {
            lista = new List<Merkozes>();
            Beolvasas();
            F3();
            F4();
            F5();
            F6();
            F7();
        }

        private void Beolvasas()
        {
            StreamReader r = new StreamReader("eredmenyek.csv");
            r.ReadLine();
            while (!r.EndOfStream)
            {
                string[] adatok = r.ReadLine().Split(';');
                Csapat h = new Csapat(adatok[0], Convert.ToInt32(adatok[2]));
                Csapat v = new Csapat(adatok[1], Convert.ToInt32(adatok[3]));
                string hsz = adatok[4];
                DateTime ido = Convert.ToDateTime(adatok[5]);
                Merkozes obj = new Merkozes(h, v, hsz, ido);
                lista.Add(obj);
            }
            foreach (var item in lista)
            {
                Console.WriteLine($"{item.Hazai.Nev} {item.Idegen.Nev} : {item.Ido.Year}");
            }
        }

        private void F3()
        {
            int hazaiDb = lista.Count(x => x.Hazai.Nev == "Real Madrid");
            int idegenDb = lista.Count(x => x.Idegen.Nev == "Real Madrid");
            Console.WriteLine($"hazai: {hazaiDb}\nidegen: {idegenDb}");
        }

        private void F4()
        {
            int db = lista.Count(x => x.Hazai.Pontszam == x.Idegen.Pontszam);
            Console.WriteLine(db == 0?"nem volt":"volt");
        }

        private void F5()
        {
            foreach (var item in lista)
            {
                if (item.Hazai.Nev.Contains("Barcelona"))
                {
                    Console.WriteLine(item.Hazai.Nev);
                    return;
                }
            }
        }

        private void F6()
        {
            List<Merkozes> merkozesek = lista.Where(x => x.Ido.Equals(new DateTime(2004, 11, 21))).ToList();
            foreach (var item in merkozesek)
            {
                Console.WriteLine($"{item.Hazai.Nev} {item.Idegen.Nev}: {item.Hazai.Pontszam}:{item.Idegen.Pontszam}");
            }
        }

        private void F7()
        {
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var item in lista)
            {
                string kulcs = item.Helyszin;
                if (!stat.ContainsKey(kulcs))
                {
                    stat.Add(kulcs, 0);
                }
                stat[kulcs]++;
            }

            foreach (var item in stat)
            {
                if (item.Value > 20)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
        }
    }
}
