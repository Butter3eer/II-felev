using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WPF_telekocsi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Autok> lista;
        static List<Igenyek> igenyLista;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                lista = new List<Autok>();
                igenyLista = new List<Igenyek>();
                Beolvas(ofd.FileName);
                IgenyBeolvas();
                F2();
                F3();
                F4();
                F5();
                F6();
            }
        }

        private void Beolvas(string file)
        {
            StreamReader fajl = new StreamReader(file);
            fajl.ReadLine();

            while (!fajl.EndOfStream)
            {
                string[] sor = fajl.ReadLine().Split(';');
                string indulas = sor[0];
                string cel = sor[1];
                string rendszam = sor[2];
                string telefonszam = sor[3];
                int ferohely = Convert.ToInt32(sor[4]);
                string utvonal = $"{sor[0]} - {sor[1]}";
                Autok obj = new Autok(indulas, cel, rendszam, telefonszam, ferohely, utvonal);
                lista.Add(obj);
            }
            fajl.Close();
        }

        private void F2()
        {
            feladat2.Text = "2. feladat\n\t" + lista.Count.ToString() + " autós hirdet fuvart.";
        }

        private void F3()
        {
            int db = 0;
            foreach (Autok item in lista)
            {
                if (item.Indulas == "Budapest" && item.Cel == "Miskolc")
                {
                    db += item.Ferohely;
                }
            }
            feladat3.Text = $"3. feladat\n\tÖsszesen {db} férőhelyet hirdettek az autósok Budapestről Miskolcra. ";
        }

        private void F4()
        {
            List<string> legtobbferohely = new List<string>();
            lista.GroupBy(x => x.Utvonal, x => x.Ferohely)
                .OrderByDescending(x => x.Sum())
                .ToList()
                .ForEach(x => legtobbferohely.Add("(" + x.Sum().ToString() + ") " + x.Key));
            feladat4.Text = $"4. feladat\n\tA legtöbb férőhelyet {legtobbferohely.First()} útvonalon ajánlottak fel";
        }

        private void F5()
        {
            List<string> kiir = new List<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < igenyLista.Count; j++)
                {
                    if (lista[i].Utvonal == igenyLista[j].Igenyutvonal && lista[i].Ferohely >= igenyLista[j].Szemelyek)
                    {
                        kiir.Add($"{igenyLista[j].Azonosito} => {lista[i].Rendszam}");
                    }
                }
            }
            foreach (var item in kiir)
            {
                feladat5.Text += item + " \n";
            }
        }

        private void IgenyBeolvas()
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

        private void F6()
        {
            StreamWriter file = new StreamWriter("utasuzenetek.txt");
            List<string> kiir = new List<string>();

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < igenyLista.Count; j++)
                {
                    if (lista[i].Utvonal == igenyLista[j].Igenyutvonal && lista[i].Ferohely >= igenyLista[j].Szemelyek)
                    {
                        kiir.Add($"{igenyLista[j].Azonosito}: Rendszám: {lista[i].Rendszam}, Telefonszám: {lista[i].Telefonszam}");
                    }
                    else
                    {
                        kiir.Add($"{igenyLista[j].Azonosito}: Sajnos nem sikerült autót találni");
                    }
                }
            }

            foreach (var item in kiir)
            {
                file.WriteLine(item);
            }

            feladat6.Text = "6. feladat\n\tA txt fájl létrejött.";

            file.Close();
        }
    }
}
