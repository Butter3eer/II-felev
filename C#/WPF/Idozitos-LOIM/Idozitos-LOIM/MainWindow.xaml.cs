using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using System.Windows.Threading;

namespace Idozitos_LOIM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Kerdesek> kerdesek = new List<Kerdesek>();
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timerSzin = new DispatcherTimer();
        int index = 0;
        public MainWindow()
        {
            InitializeComponent();
            Beolvas();
            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Game;
            timerSzin.Interval = TimeSpan.FromSeconds(2);
            timerSzin.Tick += Szinek;
        }

        private void Szinek(object? sender, EventArgs e)
        {
            A.Background = Brushes.Salmon;
            B.Background = Brushes.Salmon;
            C.Background = Brushes.Salmon;
            D.Background = Brushes.Salmon;
            Hatter();
            timerSzin.Stop();
        }

        private void Hatter()
        {
            A.Background = Brushes.White;
            B.Background = Brushes.White;
            C.Background = Brushes.White;
            D.Background = Brushes.White;
        }

        private void Game(object? sender, EventArgs e)
        {
            Idomegy.Text = "11";
            Idomegy.Text = (Convert.ToInt16(Idomegy.Text) - 1).ToString();
            Szovegek(index);
            if (Idomegy.Text == "3")
            {
                timerSzin.Start();
            }
            if (Idomegy.Text == "0")
            {
                timerSzin.Stop();
                index++;
                Szovegek(index);
            }
        }

        private void Beolvas()
        {
            kerdesek.Clear();
            StreamReader file = new StreamReader("kerdes.txt");
            while (!file.EndOfStream)
            {
                string[] reszek = file.ReadLine().Split(';');
                kerdesek.Add(new Kerdesek(int.Parse(reszek[0]), reszek[1], reszek[2], reszek[3], reszek[4], reszek[5], reszek[6], reszek[7]));
            }
            file.Close();
            timer.Start();
        }

        private void Szovegek(int index)
        {
            if (index < kerdesek.Count)
            {
                Kerdesek item = kerdesek[index];

                Kerdes.Text = item.Kerdes;
                A.Text = item.ValaszA;
                B.Text = item.ValaszB;
                C.Text = item.ValaszC;
                D.Text = item.ValaszD;
            }
            else { timer.Stop(); }
        }
    }
}
