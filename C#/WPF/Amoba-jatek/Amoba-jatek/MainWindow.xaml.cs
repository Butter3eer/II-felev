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
        bool elso = true;
        
        int db;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void kicsi_click(object sender, RoutedEventArgs e)
        {
            Gombok(3);
        }
        private void kozepes_click(object sender, RoutedEventArgs e)
        {
            Gombok(4);
        }

        private void nagy_click(object sender, RoutedEventArgs e)
        {
            Gombok(5);
        }

        private void Gombok(int oldalak)
        {
            TB.Text = "Jelenlegi játékos: X";
            halo.Children.Clear();
            halo.ColumnDefinitions.Clear();
            halo.RowDefinitions.Clear();
            db = oldalak;
            int meret = 40;
            for (int i = 0; i < oldalak; i++)
            {
                RowDefinition row = new RowDefinition();
                ColumnDefinition column = new ColumnDefinition();
                halo.RowDefinitions.Add(row);
                halo.ColumnDefinitions.Add(column);
            }

            for (int i = 0; i < oldalak; i++)
            {
                for (int j = 0; j < oldalak; j++)
                {
                    Button b = new Button();
                    b.Width = meret;
                    b.Height = meret;
                    b.Content = "";
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
            Button kattTag = (Button)sender;
            if (elso)
            {
                TB.Text = "Jelenlegi játékos: O";
                kattTag.Content = "X";
                kattTag.IsEnabled = false;
            }
            else
            {
                TB.Text = "Jelenlegi játékos: X";
                kattTag.Content = "O";
                kattTag.IsEnabled = false;
            }
            Ellenorzes();
            elso = !elso;
        }

        private void Ellenorzes()
        {
            if (Oszlop() || Diagonal() || Sor())
            {
                MessageBox.Show("Nyertél! :D");
            }
            else
            {
                TeleVanE();
            }   
        }

        private bool Oszlop()
        {
            for (int i = 0; i < db; i++)
            {
                bool siker = true;
                string elsoElemSzoveg = (halo.Children[i] as Button).Content.ToString();
                if (elsoElemSzoveg != "")
                {
                    for (int j = 1; j < db; j++)
                    {
                        string AktivSzoveg = (halo.Children[j * db + i] as Button).Content.ToString();
                        if (AktivSzoveg != elsoElemSzoveg)
                        {
                            siker = false;
                            break;
                        }
                    }
                    if (siker)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void TeleVanE()
        {
            int db = 0;
            int teli = 0;
            foreach (UIElement item in halo.Children)
            {
                if (item is Button)
                {
                    if ((item as Button).Content != "")
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

        private bool Diagonal()
        {
            bool siker = true;
            string diagElsoSzoveg = (halo.Children[0] as Button).Content.ToString();
            string diagMasikSzoveg = (halo.Children[db - 1] as Button).Content.ToString();
            if (diagElsoSzoveg != "")
            {
                for (int i = 1; i < db; i++)
                {
                    string AktivSzoveg = (halo.Children[i * db + i] as Button).Content.ToString();
                    if (AktivSzoveg != diagElsoSzoveg)
                    {
                        siker = false;
                        break;
                    }
                }
                if (siker)
                {
                    return true;
                }
            }

            
            if (diagMasikSzoveg != "")
            {
                for (int i = db; i > 1; i--)
                {
                    string AktivSzoveg = (halo.Children[i * db - i] as Button).Content.ToString();
                    if (AktivSzoveg != diagMasikSzoveg)
                    {
                        siker = false;
                        break;
                    }
                }
                if (siker)
                {
                    return true;
                }
            }
            return false;
        }

        private bool Sor()
        {
            for (int i = 0; i < db; i++)
            {
                bool win = true;
                string sorElsoSzoveg = (halo.Children[i * db] as Button).Content.ToString();
                if (sorElsoSzoveg != "")
                {
                    for (int j = 1; j < db; j++)
                    {
                        string AktivSzoveg = (halo.Children[i * db + j] as Button).Content.ToString();
                        if (AktivSzoveg != sorElsoSzoveg)
                        {
                            win = false;
                            break;
                        }
                    }
                    if (win)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
