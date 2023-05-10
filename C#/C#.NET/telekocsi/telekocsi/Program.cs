using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telekocsi
{
    internal class Program
    {
        static List<Autok> lista;
        static List<Igenyek> igenyLista;
        static void Main(string[] args)
        {
            lista = new List<Autok>();
            igenyLista = new List<Igenyek>();
            Beolvas();
            IgenyBeolvas();
            F1();
            F2();
            F3();
            F4();
            //F5();
            F6();
        }

        static void Beolvas()
        {
            StreamReader file = new StreamReader("autok.csv");
            file.ReadLine();
            while (!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(';');
                string ind = reszek[0];
                string cel = reszek[1];
                string rendsz = reszek[2];
                string tel = reszek[3];
                int ferohely = Convert.ToInt32(reszek[4]);
                string utvonal = $"{reszek[0]} - {reszek[1]}";
                Autok obj = new Autok(ind, cel, rendsz, tel, ferohely, utvonal);
                lista.Add(obj);
            }
            file.Close();
        }

        static void F1()
        {
            Console.WriteLine("1. feladat: A beolvasás megtörtént. ");
        }

        static void F2()
        {
            Console.WriteLine($"2. feladat:\n\t{lista.Count} autós hirdet fuvart. ");
        }

        static void F3()
        {
            int db = 0;
            foreach (var item in lista)
            {
                if (item.Ind == "Budapest" && item.Cel == "Miskolc")
                {
                    db += item.Ferohely;
                }
            }
            Console.WriteLine($"3. feladat\n\tÖsszesen {db} férőhelyet hirdettek az autósok Budapestről Miskolcra. ");
        }

        static void F4()
        {
            List<string> legtobbferohely = new List<string>();
            lista.GroupBy(x => x.Utvonal, x => x.Ferohely).OrderByDescending(x => x.Sum()).ToList().ForEach(x => legtobbferohely.Add("(" + x.Sum().ToString() + ") " + x.Key));
            Console.WriteLine("4. feladat\n\tA legtöbb férőhelyet {0} útvonalon ajánlottak fel", legtobbferohely.First());
        }

        static void F5()
        {
            List<string> kiir = new List<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < igenyLista.Count; j++)
                {
                    if (lista[i].Utvonal == igenyLista[j].Igenyutvonal && lista[i].Ferohely >= igenyLista[j].Szemelyek)
                    {
                        kiir.Add($"{igenyLista[j].Azonosito} => {lista[i].Rendsz}");
                    }
                }
            }
            foreach (var item in kiir)
            {
                Console.WriteLine(item);
            }
        }

        static void IgenyBeolvas()
        {
            StreamReader file = new StreamReader("igenyek.csv");
            file.ReadLine();

            while (!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(';');
                string azon = reszek[0];
                string ind = reszek[1];
                string cel = reszek[2];
                int szemelyek = Convert.ToInt32(reszek[3]);
                string utvonal = $"{reszek[1]} - {reszek[2]}";
                Igenyek obj = new Igenyek(azon, ind, cel, szemelyek, utvonal);
                igenyLista.Add(obj);
            }
            file.Close();
        }

        static void F6()
        {
            List<string> kiir = new List<string>();

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < igenyLista.Count; j++)
                {
                    if (lista[i].Utvonal == igenyLista[j].Igenyutvonal && lista[i].Ferohely >= igenyLista[j].Szemelyek)
                    {
                        kiir.Add($"{igenyLista[j].Azonosito}: Rendszám: {lista[i].Rendsz}, Telefonszám: {lista[i].Tel}");
                    }
                    else
                    {
                        kiir.Add($"{igenyLista[j].Azonosito}: Sajnos nem sikerült autót találni");
                    }
                }
            }

            foreach (var item in kiir)
            {
                Console.WriteLine(item);
            }
        }
    }
}
