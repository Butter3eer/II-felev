using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace Amoba_jatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Button> ideiglenes = new List<Button>();
        int[,] gombok;
        bool elso = true;
        Button kattTag;
        string jel = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void kicsi_click(object sender, RoutedEventArgs e)
        {
            Gombok(3, 3);
        }
        private void kozepes_click(object sender, RoutedEventArgs e)
        {
            Gombok(4, 4);
        }

        private void nagy_click(object sender, RoutedEventArgs e)
        {
            Gombok(5, 5);
        }

        private void Gombok(int oszlop, int sor)
        {
            halo.Children.Clear();
            halo.ColumnDefinitions.Clear();
            halo.RowDefinitions.Clear();
            gombok = new int[sor, oszlop];
            int meret = 35;
            for (int i = 0; i < sor; i++)
            {
                halo.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < oszlop; i++)
            {
                halo.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                { 
                    Button b = new Button();
                    b.Width = meret;
                    b.Height = meret;
                    b.Tag = gombok[i, j];
                    b.Background = Brushes.PapayaWhip;
                    b.Margin = new Thickness(meret * j, meret * i, meret * -j, meret * -i);
                    b.VerticalAlignment = VerticalAlignment.Center;
                    b.HorizontalAlignment = HorizontalAlignment.Center;
                    halo.Children.Add(b);
                    b.Click += GombClick;
                }
            }
        }

        private void GombClick(object sender, RoutedEventArgs e)
        {
            if (elso)
            {
                jel = "X";
                kattTag = (sender as Button);
                (sender as Button).Content = jel;
                Ellenorzes(kattTag);
                kattTag.IsEnabled = false;
            }
            else
            {
                jel = "O";
                kattTag = (sender as Button);
                kattTag.Content = jel;
                Ellenorzes(kattTag);
                kattTag.IsEnabled = false;
            }
            elso = !elso;
        }

        private void Ellenorzes(Button kattTag)
        {
            if (Oszlop(kattTag))
            {
                MessageBox.Show("Nyertél!");
            }
            TeleVanE();
        }

        private bool Oszlop(Button gomb)
        {
            int sorok = halo.RowDefinitions.Count;
            int oszlopok = halo.ColumnDefinitions.Count;
            bool helyes = false;
            
            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    if (gomb.Tag.ToString() == $"{i}{j}" && gomb.Content.ToString() == "X")
                    {
                        ideiglenes.Add(gomb);
                    }                        
                }
            }

            if (ideiglenes.Count() == 3)
            {
                helyes = true;
            }

            return helyes;
        }

        private void TeleVanE()
        {
            int db = 0;
            int teli = 0;
            foreach (UIElement item in halo.Children)
            {
                if (item is Button)
                {
                    if ((item as Button).Content != null)
                    {
                        teli++;
                        db++;
                    }
                    else
                    {
                        db++;
                    }
                }
            }
            if (db == teli)
            {
                MessageBox.Show("Nincs győztes, válassz új nehézséget!");
            }
        }
    }
}
