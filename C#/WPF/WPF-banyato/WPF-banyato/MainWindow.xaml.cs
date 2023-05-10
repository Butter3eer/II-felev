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
using Microsoft.Win32;

namespace WPF_banyato
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[,] melysegekTomb; //melysegek[4,5] [sor, oszlop]
        List<List<int>> melysegek = new List<List<int>>(); //melysegek[4][5]
        int sorSzam;
        int oszlopSzam;

        private void Kirajzol()
        {
            gridTo.Children.Clear();
            int meret = 20;
            int bord = 4;
            int left, right, top, bottom;

            for (int i = 0; i < sorSzam; i++)
            {
                for (int j = 0; j < oszlopSzam; j++)
                {
                    left = 0;
                    right = 0;
                    top = 0;
                    bottom = 0;
                    int mely = melysegekTomb[i,j];
                    Button gomb = new Button();
                    gomb.Width = meret;
                    gomb.Height = meret;
                    gomb.Margin = new Thickness(j * meret, i * meret, 0, 0); //bal, fölső, jobb, alsó
                    gomb.VerticalAlignment = VerticalAlignment.Top;
                    gomb.HorizontalAlignment = HorizontalAlignment.Left;
                    gomb.Tag = mely;
                    gomb.MouseEnter += kiir;
                    gomb.MouseLeave += torol;

                    if (mely == 0)
                    {
                        gomb.Background = Brushes.Green;
                        gomb.BorderBrush = Brushes.Olive;
                    }
                    else
                    {
                        if (melysegekTomb[i, j - 1] == 0)
                        {
                            left = bord;
                        }
                        if (melysegekTomb[i, j + 1] == 0)
                        {
                            right = bord;
                        }
                        if (melysegekTomb[i + 1, j] == 0)
                        {
                            bottom = bord;
                        }
                        if (melysegekTomb[i - 1, j] == 0)
                        {
                            top = bord;
                        }
                        gomb.BorderBrush = Brushes.DarkBlue;
                        gomb.BorderThickness = new Thickness(left, top, right, bottom);
                        gomb.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(melysegekTomb[i,j] * 2), 0, 0, 255));
                    }
                    gridTo.Children.Add(gomb);
                }
            }
        }

        private void torol(object sender, MouseEventArgs e)
        {
            (sender as Button).Content = "";
        }

        private void kiir(object sender, MouseEventArgs e)
        {
            (sender as Button).Content = (sender as Button).Tag;
        }

        private void Atlagol()
        {
            int sum = 0;
            int meret = 0;
            for (int i = 0; i < sorSzam; i++)
            {
                for (int j = 0; j < oszlopSzam; j++)
                {
                    if (melysegekTomb[i, j] > 0)
                    {
                        meret++;
                        sum += melysegekTomb[i, j];
                    }
                }
            }
            double atlag = Math.Round((double)sum / meret, 2);
            labelAtlag.Content = "Az átlagos tó mélység: " + atlag.ToString();
            labelMeret.Content = "A tó területe: " + meret.ToString();
        }

        private void Minszinez()
        {
            int min = Minmely();
            foreach (Button item in gridTo.Children)
            {
                if (Convert.ToInt16(item.Tag) == min)
                {
                    item.Background = Brushes.Black;
                }
            }
        }

        private int Minmely()
        {
            int min = 0;
            for (int i = 0; i < sorSzam; i++)
            {
                for (int j = 0; j < oszlopSzam; j++)
                {
                    if (melysegekTomb[i,j] > min)
                    {
                        min = melysegekTomb[i, j];
                    }
                }
            }
            return min;
        }

        private void Beolvas(string file)
        {
            StreamReader fajl = new StreamReader(file);
            sorSzam = Convert.ToInt16(fajl.ReadLine());
            oszlopSzam = Convert.ToInt16(fajl.ReadLine());
            melysegekTomb = new int[sorSzam, oszlopSzam];

            int sorIndex = 0;
            while (!fajl.EndOfStream)
            {
                string[] sor = fajl.ReadLine().Split(' ');
                for (int i = 0; i < sor.Length; i++)
                {
                    melysegekTomb[sorIndex, i] = Convert.ToInt16(sor[i]);
                }
                sorIndex++;
            }
            fajl.Close();
            Kirajzol();
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                Beolvas(ofd.FileName);
                Atlagol();
                Minszinez();
            }
        }
    }
}
