using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WPF_nobel_dij
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

        private void mentesGomb(object sender, RoutedEventArgs e)
        {
            ellenorzes();
        }

        private void ellenorzes()
        {
            bool okay = true;

            if (ev.Text == "")
            {
                okay = false;
            }
            if (nev.Text == "")
            {
                okay = false;
            }
            if (szh.Text == "")
            {
                okay = false;
            }
            if (orszag.Text == "")
            {
                okay = false;
            }  

            if (okay == false)
            {
                MessageBox.Show("„Töltsön ki minden mezőt!");
            }

            else if (okay)
            {
                if (ellenorzes2())
                {
                    mentes();
                    kiir();
                    ev.Clear();
                    nev.Clear();
                    szh.Clear();
                    orszag.Clear();
                } 
            }
        }

        private bool ellenorzes2()
        {
            if (Convert.ToInt16(ev.Text) < 1989)
            {
                MessageBox.Show("Hiba! Az évszám nem megfelelő!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<string> lista = new List<string>();
        private void mentes()
        {
            try
            {
                int evszam = Convert.ToInt16(ev.Text);
                string neve = nev.Text;
                string szulhal = szh.Text;
                string orszaga = orszag.Text;
                lista.Add($"{evszam};{neve};{szulhal};{orszaga}");
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba az állomány írásánál!");
            }        
        }

        private void kiir()
        {
            try
            {
                StreamWriter file = new StreamWriter("uj_dijazott.txt");
                file.WriteLine("Év;Név;SzületésHalálozás;Országkód");
                foreach (var item in lista)
                {
                    file.WriteLine(item);
                }
                file.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Hiba az állomány írásánál!");
            }
        }
    }
}
