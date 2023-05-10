﻿using System;
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
        bool elso = true;
        Button kattTag;
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
            halo.Children.Clear();
            halo.ColumnDefinitions.Clear();
            halo.RowDefinitions.Clear();
            db = oldalak;
            int meret = 35;
            for (int i = 0; i < oldalak; i++)
            {
                halo.RowDefinitions.Add(new RowDefinition());
                halo.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < oldalak; i++)
            {
                for (int j = 0; j < oldalak; j++)
                {
                    Button b = new Button();
                    b.Width = meret;
                    b.Height = meret;
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
                kattTag = (sender as Button);
                (sender as Button).Content = "X";
                kattTag.IsEnabled = false;
            }
            else
            {
                kattTag = (sender as Button);
                kattTag.Content = "O";
                kattTag.IsEnabled = false;
            }
            Ellenorzes();
            elso = !elso;
        }

        private void Ellenorzes()
        {
            if (Oszlop())
            {
                MessageBox.Show("Nyertél!");
            }
            TeleVanE();
        }

        private bool Oszlop()
        {
            int sorok = halo.RowDefinitions.Count;
            int oszlopok = halo.ColumnDefinitions.Count;
            bool helyes = false;

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

        private bool Diagonal()
        {
            bool siker = true;
            string diagElso = (halo.Children[0] as Button).Content.ToString();
            string diagMasik = (halo.Children[db - 1] as Button).Content.ToString();
            if (diagElso != "")
            {
                for (int i = 1; i < db; i++)
                {
                    string currentElement = (halo.Children[i * db + i] as Button).Content.ToString();
                    if (currentElement != diagElso)
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

            
            if (diagMasik != "")
            {
                for (int i = 1; i < x; i++)
                {
                    string currentElement = (halo.Children[(db - i) * db + i] as Button).Content.ToString();
                    if (currentElement != diagMasik)
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
    }
}