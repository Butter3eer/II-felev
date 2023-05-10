using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace projekt_erettsegi
{
    internal class Program
    {
        static List<Karakter> lista;
        static List<string> palcafak;
        static int valasz = 0;

        static void Main(string[] args)
        {
            lista = new List<Karakter>();
            palcafak = new List<string>();
            
            MasodMenu();
        }

        static void ElsoMenu()
        {
            Console.Clear();
            Console.WriteLine("--- FŐMENÜ ---");
            Console.WriteLine("1. Karakter készítés\n");
            Console.WriteLine("--- Meglévő karakter esetén ---");
            Console.WriteLine("2. Teszlek süveg");
            Console.WriteLine("3. Pálca készítés");
            Console.WriteLine("4. Patrónus idézés");
            Console.WriteLine("5. Karakter lekérdezés\n");
            Console.WriteLine("--- Feladatok ---");
            Console.WriteLine("6. TXT feladat");
            Console.WriteLine("7. LISTA feladat");
            Console.WriteLine("8. Szortírozás feladat\n");
            valasz = Convert.ToInt32(Console.ReadLine());
        }

        static void MasodMenu()
        {
            ElsoMenu();
            switch (valasz)
            {
                case 1:
                    KarakterMenu();
                    MasodMenu();
                    break;
                case 2:
                    TeszlekSuveg();
                    MasodMenu();
                    break;
                case 3:
                    PalcaMenu();
                    MasodMenu();
                    break;
                case 4:
                    PatronusMenu();
                    MasodMenu();
                    break;
                case 5:
                    Lekerdezes();
                    MasodMenu();
                    break;
                case 6:
                    FeladatTxt();
                    MasodMenu();
                    break;
                case 7:
                    FeladatLista("Griffendél");
                    MasodMenu();
                    break;
                case 8:
                    FeladatSort("Egyszarvúszőr");
                    MasodMenu();
                    break;
                default:
                    MasodMenu();
                    break;
            }
        }
        static void KarakterMenu()
        {
            Console.Clear();
            Console.WriteLine("--- KARAKTER MENÜ ---\n");
            Console.WriteLine("-- Keresztnév: \n");
            string keresztnev = Console.ReadLine();

            Console.WriteLine("\n-- Vezetéknév: \n");
            string vezeteknev = Console.ReadLine();

            Console.WriteLine("\n-- Felhasználónév: \n");
            string felhasznalonev = Console.ReadLine();

            if (VaneNev(felhasznalonev) == false)
            {
                Console.WriteLine("\n-- Életkor: \n\t");
                int eletkor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n-- Bagolyposta címe: \n");
                string cim = Console.ReadLine();

                Karakter obj = new Karakter(keresztnev, vezeteknev, eletkor, cim, felhasznalonev);
                Veglegesites(obj);
            }
            else
            {
                Console.WriteLine("-- Már létezik ezzel a névvel egy felhasználó!");
                Console.ReadKey();
                Console.Clear();
                KarakterMenu();
            }
        }

        static void TeszlekSuveg()
        {
            Console.Clear();
            Console.WriteLine("--- TESZLEK SÜVEG ---\n");
            Console.WriteLine("-- Add meg a felhasználóneved: \n");
            string nev = Console.ReadLine();

            if (VaneNev(nev))
            {
                Console.WriteLine("\n-- A következő pár választási opciók segítenek majd kiválasztani a házadat.\nHallgass az első megérzésedre és próbálj meg minél hamarabb választani!\n");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("-- 1. Piros");
                Console.WriteLine("-- 2. Kék");
                Console.WriteLine("-- 3. Zöld");
                Console.WriteLine("-- 4. Sárga\n");
                int szinSzam = Convert.ToInt32(Console.ReadLine());
                string szin = "";
                switch (szinSzam) { case 1:  szin = "Piros"; break; case 2: szin = "Kék"; break; case 3: szin = "Zöld"; break; case 4: szin = "Sárga"; break; }
                Console.Clear();

                Console.WriteLine("-- 1. Szél");
                Console.WriteLine("-- 2. Tűz");
                Console.WriteLine("-- 3. Föld");
                Console.WriteLine("-- 4. Víz\n");
                int elementSzam = Convert.ToInt32(Console.ReadLine());
                string element = "";
                switch (elementSzam) { case 1: element = "Szél"; break; case 2: element = "Tűz"; break; case 3: element = "Föld"; break; case 4: element = "Víz"; break; }

                Console.Clear();

                Console.WriteLine("-- 1. Pirkadat");
                Console.WriteLine("-- 2. Dél");
                Console.WriteLine("-- 3. Alkonyat");
                Console.WriteLine("-- 4. Éjfél\n");
                int napszakSzam = Convert.ToInt32(Console.ReadLine());
                string napszak = "";
                switch (napszakSzam) { case 1: napszak = "Pirkadat"; break; case 2: napszak = "Dél"; break; case 3: napszak = "Alkonyat"; break; case 4: napszak = "Éjfél"; break; }

                Console.Clear();

                Console.WriteLine("-- 1. Többségért");
                Console.WriteLine("-- 2. Egyénért");
                Console.WriteLine("-- 3. Magadért");
                Console.WriteLine("-- 4. Senkiért\n");
                int segitsegSzam = Convert.ToInt32(Console.ReadLine());
                string segitseg = "";
                switch (segitsegSzam) { case 1: segitseg = "Többségért"; break; case 2: segitseg = "Egyénért"; break; case 3: segitseg = "Magadért"; break; case 4: segitseg = "Senkiért"; break; }
                Console.Clear();

                Console.WriteLine("-- 1. Hűség");
                Console.WriteLine("-- 2. Bölcsesség");
                Console.WriteLine("-- 3. Ambíció");
                Console.WriteLine("-- 4. Bátorság\n");
                int tudasvagySzam = Convert.ToInt32(Console.ReadLine());
                string tudasvagy = "";
                switch (tudasvagySzam) { case 1: tudasvagy = "Hűség"; break; case 2: tudasvagy = "Bölcsesség"; break; case 3: tudasvagy = "Ambíció"; break; case 4: tudasvagy = "Bátorság"; break; }

                Console.Clear();

                string haz = "";

                switch (tudasvagySzam)
                {
                    case 4:
                        haz = "Griffendél";
                        break;
                    case 1:
                        haz = "Hugrabug";
                        break;
                    case 2:
                        haz = "Hollóhát";
                        break;
                    case 3:
                        haz = "Mardekár";
                        break;
                }

                Console.WriteLine($"--- GRATULÁLOK! ---\n\nA házad a\n\t {haz.ToUpper()}!");
                Console.ReadKey();
                Haz obj = new Haz(szin, element, napszak, segitseg, tudasvagy, haz);
                Karakter karakter = lista.Find(x => x.FelhasznaloNev == nev);
                karakter.Haz = obj;
                Veglegesites(karakter);
            }
            else
            {
                Console.WriteLine("Hibás felhasználónév vagy nem hozott létre ilyen karaktert!");
                Console.ReadKey();
                MasodMenu();
            }
        }

        static void PalcaMenu()
        {     
            Console.WriteLine("-- Add meg a felhasználóneved: \n");
            string nev = Console.ReadLine();          

            if (VaneNev(nev))
            {
                string fa = FatipusValaszt();
                string hossz = PalcaHosszValaszt();
                string core = PalcaCore();
                string szin = PalcaSzin();

                Palca palca = new Palca(fa, hossz, core, szin);
                Karakter karakter = lista.Find(x => x.FelhasznaloNev == nev);
                karakter.Palca = palca;
                Veglegesites(karakter);
            }
            else
            {
                Console.WriteLine("Hibás felhasználónév vagy nem hozott létre ilyen karaktert!");
                Console.ReadKey();
                MasodMenu();
            }
        }
        static string FatipusValaszt()
        {
            TxtBeolvas();
            Console.WriteLine("--- FA TÍPUSA ---");
            Console.WriteLine("\n-- A következő választási lehetőségek ízléstől függenek, adj annyi gondolkodási időt amennyire szükséged van!");
            Console.ReadKey();

            for (int i = 0; i < palcafak.Count; i++)
            {
                Console.WriteLine($"-{i + 1}. {palcafak[i]}");
            }

            int fatipus = Convert.ToInt32(Console.ReadLine());
            return palcafak[fatipus - 1];
        }
        static string PalcaHosszValaszt()
        {
            Console.Clear();
            Console.WriteLine("--- PÁLCA HOSSZA ---\n");
            Console.WriteLine("9 1/2 inch-től egészen 14 1/2 inch-ig 1/4 inch-enként (pl: 10 3/4)");
            string hossz = Console.ReadLine();
            return hossz;
        }
        static string PalcaCore()
        {
            Console.Clear();
            Console.WriteLine("--- PÁLCA MAGJA ---\n");
            Console.WriteLine("-- A pálca magja adja meg a fő személyiségét a pálcának.\n");
            Console.ReadKey();
            Console.WriteLine("-- 1. Sárkány Szívizomhúr \n\t- nagyobb varázserőt tudnak produkálni");
            Console.ReadKey();
            Console.WriteLine("-- 2. Egyszarvúszőr \n\t- sziládr mágiát termel, nagyon nehezen inog meg.");
            Console.ReadKey();
            Console.WriteLine("-- 3. Főnix toll \n\t- legritkább, legválogatósabb pálcafajta\n\t- a legszélesebb variációkat tudja megteremteni mágiából.\n");
            int coreBevitel = Convert.ToInt16(Console.ReadLine());

            string core = "";
            switch (coreBevitel) { case 1: core = "Sárkány Szívizomhúr"; break; case 2: core = "Egyszarvúszőr"; break; case 3: core = "Főnix toll"; break; }
            return core;
        }
        static string PalcaSzin()
        {
            Console.Clear();
            Console.WriteLine("--- PÁLCA SZÍN ---\n");
            Console.WriteLine("-- A pálcáknál van lehetőség arra, hogy a fa típusa ellenére megváltoztassuk a színét fa lakk segítségével.\n");
            Console.ReadKey();
            Console.WriteLine("-- 1. fehér lakk");
            Console.WriteLine("-- 2. világos barna");
            Console.WriteLine("-- 3. sötét barna");
            Console.WriteLine("-- 4. fekete");
            Console.WriteLine("-- 5. kezeletlen fa\n");
            int szinSzam = Convert.ToInt16(Console.ReadLine());
            string szin = "";
            switch (szinSzam) { case 1: szin = "fehér"; break; case 2: szin = "világos barna"; break; case 3: szin = "sötét barna"; break; case 4: szin = "fekete"; break; case 5: szin = "kezeletlen fa"; break; }
            return szin;
        }

        static void PatronusMenu()
        {
            Console.Clear();
            Console.WriteLine("--- PATRÓNUS MENÜ ---\n");
            Console.WriteLine("-- Add meg a felhasználóneved: \n");
            string nev = Console.ReadLine();

            if (VaneNev(nev))
            {
                Console.WriteLine("\n-- A következő pár választási opciók segítenek majd kiválasztani a patrónusodat.\nHallgass az első megérzésedre és próbálj meg minél hamarabb választani!\n");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("-- 1. Tavasz");
                Console.WriteLine("-- 2. Tél\n");
                int evszakSzam = Convert.ToInt16(Console.ReadLine());
                string evszak = "";
                switch (evszakSzam) { case 1: evszak = "Tavasz"; break; case 2: evszak = "Tél"; break; }
                Console.Clear();

                Console.WriteLine("-- 1. Köd");
                Console.WriteLine("-- 2. Eső\n");
                int idojarasSzam = Convert.ToInt16(Console.ReadLine());
                string idojaras = "";
                switch (idojarasSzam) { case 1: idojaras = "Tavasz"; break; case 2: idojaras = "Tél"; break; }
                Console.Clear();

                Console.WriteLine("-- 1. Erdő");
                Console.WriteLine("-- 2. Tó\n");
                int erdoToSzam = Convert.ToInt16(Console.ReadLine());
                string erdoTo = "";
                switch (erdoToSzam) { case 1: erdoTo = "Tavasz"; break; case 2: erdoTo = "Tél"; break; }
                Console.Clear();

                Console.WriteLine("-- 1. Támad");
                Console.WriteLine("-- 2. Véd\n");
                int tamadVedSzam = Convert.ToInt16(Console.ReadLine());
                string tamadVed = "";
                switch (tamadVedSzam) { case 1: tamadVed = "Tavasz"; break; case 2: tamadVed = "Tél"; break; }
                Console.Clear();

                string allat = "";
                switch ($"{evszakSzam}{idojarasSzam}{erdoToSzam}{tamadVedSzam}")
                {
                    case "1111":
                        allat = "Róka";
                        break;
                    case "1112":
                        allat = "Őz";
                        break;
                    case "1121":
                        allat = "Macska";
                        break;
                    case "1122":
                        allat = "Béka";
                        break;
                    case "1211":
                        allat = "Vaddisznó";
                        break;
                    case "1212":
                        allat = "Kutya";
                        break;
                    case "1221":
                        allat = "Hal";
                        break;
                    case "1222":
                        allat = "Vizipók";
                        break;
                    case "2111":
                        allat = "Szarvas";
                        break;
                    case "2112":
                        allat = "Medve";
                        break;
                    case "2121":
                        allat = "Orka";
                        break;
                    case "2122":
                        allat = "Pingvin";
                        break;
                    case "2211":
                        allat = "Borz";
                        break;
                    case "2212":
                        allat = "Holló";
                        break;
                    case "2221":
                        allat = "Fóka";
                        break;
                    case "2222":
                        allat = "Jegesmedve";
                        break;
                }

                Console.WriteLine($"--- GRATULÁLOK! ---\n\nA patrónusod a(z)\n\t {allat.ToUpper()}!");
                Console.ReadKey();

                Patronus patronus = new Patronus(evszak, idojaras, erdoTo, tamadVed, allat);
                Karakter karakter = lista.Find(x => x.FelhasznaloNev == nev);
                karakter.Patronus = patronus;
                Veglegesites(karakter);
            }
            else
            {
                Console.WriteLine("\n-- Hibás felhasználónév vagy nem hozott létre ilyen karaktert!");
                Console.ReadKey();
                Console.Clear();
                MasodMenu();
            }
        }

        static void TxtBeolvas()
        {
            StreamReader file = new StreamReader("palcafa.txt");
            
            while (!file.EndOfStream)
            {
                 palcafak.Add(file.ReadLine());
            }
        }
        static void Veglegesites(Karakter karakter)
        {
            Console.Clear();
            Console.WriteLine("\n--- VÉGLEGESÍTÉS ---\n\n\t" + karakter.ToString());
            Console.WriteLine("\n-- Jóváhagyja? (I/N)");
            string igenNem = Console.ReadLine();

            if (igenNem == "I")
            {
                if (VaneNev(karakter.FelhasznaloNev))
                {
                    int index = lista.IndexOf(lista.Find(x => x.FelhasznaloNev == karakter.FelhasznaloNev));
                    lista[index] = karakter;
                    Console.WriteLine("\n--- Karaktere frissítve! :) ---");
                    Console.ReadKey();
                }
                else
                {
                    lista.Add(karakter);
                    Console.WriteLine("\n--- Karaktere hozzáadva! :) ---");
                    Console.ReadKey();
                }

                Console.WriteLine("\n" + karakter.ToString());
            }
            else
            {
                Console.WriteLine("\n-- Az enter lenyomása után visszakerül a FŐMENÜHÖZ.");
                Console.ReadKey();
                MasodMenu();
            }
        }
        static bool VaneNev(string nev)
        {
            if (lista.Any(x => x.FelhasznaloNev == nev))
            {
                return true;
            }

            return false;
        }
        static void Lekerdezes()
        {
            Console.Clear();
            Console.WriteLine("--- KARAKTER ---\n");
            Console.WriteLine("-- Adja meg a felhasználó nevét:\n");
            string nev = Console.ReadLine();

            if (nev != "")
            {
                Karakter karakter = lista.Find(x => x.FelhasznaloNev == nev);
                Console.WriteLine(karakter);
            }
            else
            {
                if (lista.Count == 0)
                {
                    Console.WriteLine("\n-- Még nem hozott létre karaktert! :c");
                    Console.WriteLine("-- Az enter lenyomása után visszairányítom a FŐMENÜRE!");
                    Console.ReadKey();
                    MasodMenu();
                }
                else
                {
                    Console.Clear() ;
                    Console.WriteLine("-- Nem ismert felhasználónév esetében lista az eddig létrehozott karakterekről:\n");
                    Console.ReadKey();
                    foreach (Karakter karakter in lista)
                    {
                        Console.WriteLine(karakter.ToString());
                    }
                    Console.ReadKey();
                }
            }
        }

        static void FeladatTxt()
        {
            Console.Clear();
            Console.WriteLine("-- Adatok txt fájlban tárolása megtörtént");
            StreamWriter file = new StreamWriter("varazslok.txt");
            foreach (var item in lista)
            {
                file.WriteLine($"{item.KeresztNev} {item.VezetekNev} ({item.FelhasznaloNev}): {item.Eletkor} - ({item.Cim}) - {item.Haz} - {item.Palca} - {item.Patronus}");
            }
            file.Close();
        }

        static void FeladatLista(string haz)
        {
            Console.Clear();
            List<Karakter> listaFindall = lista.FindAll(x => x.Haz.Vegleges == haz);
            Console.WriteLine("-- A ház alapú lista elkészült.");
            foreach (Karakter item in listaFindall)
            {
                Console.Write(item + " | ");
            }
        }

        static void FeladatSort(string core)
        {
            Console.Clear();
            Console.WriteLine("-- Írjuk ki az összes felhasználó nevét, akik pálcája egyszarvúszőrt tartalmaznak.");
            lista.FindAll(x => x.Palca.Core == core).ForEach(x => Console.WriteLine(x.FelhasznaloNev));
        }
    }
}
