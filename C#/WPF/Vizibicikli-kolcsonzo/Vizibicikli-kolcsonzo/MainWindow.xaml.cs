using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

namespace Vizibicikli_kolcsonzo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Kolcsonzes> lista = new List<Kolcsonzes>();

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                Beolvas(ofd.FileName);
            }
        }

        private void Beolvas(string file)
        {
            StreamReader sr = new StreamReader(file);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] reszek = sr.ReadLine().Split(';');
                lista.Add(new Kolcsonzes(reszek[0], reszek[1], int.Parse(reszek[2]), int.Parse(reszek[3]), int.Parse(reszek[4]), int.Parse(reszek[5])));
            }
            sr.Close();
        }

        private void Listazas_click(object sender, RoutedEventArgs e)
        {
            LDoboz.Items.Clear();
            foreach (var item in lista)
            {
                if (item.Nev == nevBox.Text)
                {
                    string szoveg = $"{item.Jazon}: {item.Eora}:{item.Eperc} - {item.Vora}:{item.Vperc}";
                    LDoboz.Items.Add(szoveg);
                }
            }
        }

        private void KeresIdo_click(object sender, RoutedEventArgs e)
        {
            LDoboz.Items.Clear();
            DateTime keresIdo = Convert.ToDateTime(idoBox.Text);
            foreach (var item in lista)
            {
                if (keresIdo > item.Elvitel && keresIdo <= item.Vissza)
                {
                    LDoboz.Items.Add($"{item.Nev} => {item.Jazon} - {item.Vissza.ToShortTimeString()}");
                }
            }
        }

        private void Bevetel_click(object sender, RoutedEventArgs e)
        {
            double bevetel = 0;
            foreach (var item in lista)
            {
                bevetel += Math.Ceiling((item.Vissza - item.Elvitel).TotalMinutes / 30) * 2400;
            }
            penzBox.Text = bevetel.ToString();
        }

        private void Rongalok_click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("F.txt");
            foreach (var item in lista)
            {
                if (item.Jazon == "F")
                {
                    sw.WriteLine($"{item.Elvitel.ToShortTimeString()}-{item.Vissza.ToShortTimeString()} : {item.Nev}");
                }
            }

            sw.Close();
        }

        private void Stat_click(object sender, RoutedEventArgs e)
        {
            Dictionary<string,int> dic = new Dictionary<string,int>();
            foreach (var item in lista)
            {
                if (dic.ContainsKey(item.Jazon))
                {
                    dic[item.Jazon]++;
                }
                else
                {
                    dic[item.Jazon] = 1;
                }
            }
            foreach (KeyValuePair<string, int> pair in dic)
            {
                StatDoboz.Items.Add($"{pair.Key} - {pair.Value}");
            }
        }
    }
}
