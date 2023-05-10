using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WPF_otbetus_jatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> szavak = new List<string>();
        public Random r = new Random();
        public string tipp;
        public string szo;
        private void Beolvas(string file)
        {
            szavak.Clear();
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                szavak.Add(sr.ReadLine());
            }
            
            int szoIndex = r.Next(0, szavak.Count + 1);
            szo = szavak[szoIndex];
            //teszt.Text = szo;

            sr.Close();
        }

        public MainWindow()
        {
            InitializeComponent();
            elet.Text = maradekelet.ToString();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                Beolvas(ofd.FileName);
            }
        }

        public int maradekelet = 15;
        public Popup meghalt = new Popup();
        public int jobetuk = 0;
        public int rosszbetuk = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Teszt())
            {
                Start();
            }
        }

        private bool Teszt()
        {
            tipp = tbinput.Text;
            if (tipp.Length != 5)
            {
                megoldas.Text = "A tipp legyen 5 betűs!";
                tbinput.Text = "";
                return false;
            }
            else
            {
                megoldas.Text = "";
                return true;
            }
        }

        private void Start()
        {
            jobetuk = 0;
            elet.Text = maradekelet.ToString();

            while (szo != tipp)
            {
                maradekelet -= 1;
                elet.Text = maradekelet.ToString();

                for (int i = 0; i < szo.Length; i++)
                {
                    if (szo[i] == tipp[i])
                    {
                        jobetuk += 1;
                    }
                    else
                    {
                        rosszbetuk += 1;
                    }   
                }
                megoldas.Text = jobetuk.ToString();
                break;
            }

            if (maradekelet <= 0)
            {
                gameovertext.Text = $"Game Over :c\nA megoldás {szo} volt.";
                gameover.IsOpen = true;
                maradekelet = 1;
            }

            if (szo == tipp)
            {
                elet.Text = "";
                megoldas.Text = "Gratulálunk!";
            }
        }
    }
}
