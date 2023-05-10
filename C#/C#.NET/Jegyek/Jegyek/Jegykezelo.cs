using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyek
{
    internal class Jegykezelo
    {
        static List<Jegy> lista = new List<Jegy>();
        static void Main(string[] args)
        {
            JegyekBeolvasasa("jegy.txt");
            Kiir();
            Jegyellenorzes();
        }

        static void JegyekBeolvasasa(string fajlUtvonal)
        {
            StreamReader file = new StreamReader(fajlUtvonal);
            while(!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(';');
                if (reszek[0] == "Berlet")
                {
                    lista.Add(new Berlet(DateTime.ParseExact(reszek[1], "yyyy/MM/dd", CultureInfo.CurrentCulture), int.Parse(reszek[2])));
                }
                if (reszek[0] == "Vonaljegy")
                {
                    lista.Add(new Vonaljegy(bool.Parse(reszek[1])));
                }
                if (reszek[0] == "Diakberlet")
                {
                    lista.Add(new Diakberlet(DateTime.ParseExact(reszek[1], "yyyy/MM/dd", CultureInfo.CurrentCulture), int.Parse(reszek[2]), reszek[3]));
                }
            }
            file.Close();
        }

        static void Jegyellenorzes()
        {
            int joDb = 0;
            int rosszDb = 0;
            foreach (Jegy jegy in lista)
            {
                if (jegy.Ervenyesit())
                {
                    joDb++;
                }
                else
                {
                    rosszDb++;
                }
            }
            Console.WriteLine($"{joDb} db érvényes jegy maradt, és {rosszDb} db érvénytelen jegy keletkezett. ");
        }

        static void Kiir()
        {
            StreamWriter fajl = new StreamWriter("jegyek.txt");
            foreach (Jegy jegy in lista)
            {
                if (jegy is Vonaljegy)
                {
                    fajl.WriteLine($"Vonaljegy - {(jegy as Vonaljegy).Ervenyesseg}");
                }
                if (jegy is Berlet)
                {
                    if (jegy is Diakberlet)
                    {
                        fajl.WriteLine("Diakberlet - " + (jegy as Diakberlet).Datum.ToString("yyyy/MM/ddFFFF") + " - " + (jegy as Diakberlet).NapokSzama + " - Érvényesség dátuma: " + (jegy as Diakberlet).Lejarat.ToString("yyyy/MM/ddFFFF") + " - " + (jegy as Diakberlet).Diakigazolvanyszam);
                    }
                    else
                    {
                        fajl.WriteLine("Berlet - " + (jegy as Berlet).Datum.ToString("yyyy/MM/ddFFFF") + " - " + (jegy as Berlet).NapokSzama + " - Érvényesség dátuma: " + (jegy as Berlet).Lejarat.ToString("yyyy/MM/ddFFFF"));
                    }
                }
            }
            fajl.Close();
        }
    }
}
