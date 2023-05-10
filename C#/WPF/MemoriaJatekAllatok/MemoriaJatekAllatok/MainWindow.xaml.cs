using System;
using System.Collections.Generic;
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

namespace MemoriaJatekAllatok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool elso = true;
        string kattTag = "";
        public List<int> szamok = new List<int>();
        int hany = 0;

        private void Reset()
        {
            foreach (Image item in grid.Children)
            {
                if (item.IsEnabled == true)
                {
                    string fileSource = Environment.CurrentDirectory + "\\Images\\hatter.jpg";
                    item.Source = new BitmapImage(new Uri(fileSource));       
                }
            }
        }
        private void Init(int sor, int oszlop)
        {
            szamok.Clear();
            grid.Children.Clear();
            hany = 0;
            grid.ColumnDefinitions.Clear();
            grid.RowDefinitions.Clear();
            elso = true;
            Random random = new Random();

            for (int i = 0; i < sor * oszlop / 2; i++)
            {
                szamok.Add(i);
                szamok.Add(i);
            }

            for (int i = 0; i < sor; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < oszlop; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    int veletlen = random.Next(szamok.Count);
                    Image kep = new Image();
                    kep.Tag = szamok[veletlen];
                    string fileSource = Environment.CurrentDirectory + "\\Images\\hatter.jpg";
                    kep.Source = new BitmapImage(new Uri(fileSource));
                    kep.Stretch = Stretch.Fill;
                    kep.Margin = new Thickness(5);
                    kep.HorizontalAlignment = HorizontalAlignment.Center;
                    Grid.SetColumn(kep, j);
                    Grid.SetRow(kep, i);
                    kep.MouseDown += Katt;
                    grid.Children.Add(kep);
                    Border border = new Border();
                    //grid.Children.Add(border);
                    Grid.SetColumn(border, j);
                    Grid.SetRow(border, i);
                    border.BorderBrush = Brushes.Black;
                    border.BorderThickness = new Thickness(5);
                    szamok.RemoveAt(veletlen);
                }
            }
        }

        private void Katt(object sender, MouseButtonEventArgs e)
        {
            if (elso == true)
            {
                Reset();
                string fileSource = Environment.CurrentDirectory + "\\Images\\" + (sender as Image).Tag + ".jpg";
                (sender as Image).Source = new BitmapImage(new Uri(fileSource));
                kattTag = (sender as Image).Tag.ToString();
                (sender as Image).IsEnabled = false;
            }
            else
            {
                string fileSource = Environment.CurrentDirectory + "\\Images\\" + (sender as Image).Tag + ".jpg";
                (sender as Image).Source = new BitmapImage(new Uri(fileSource));

                foreach (Image item in grid.Children)
                {
                    if (item.Tag.ToString() == kattTag)
                    {
                        item.IsEnabled = true;
                    }
                }
                if ((sender as Image).Tag.ToString() == kattTag)
                {
                    Torol();
                }
            }
            elso = !elso;
        }

        private void Torol()
        {
            foreach (Image item in grid.Children)
            {
                if (item.Tag.ToString() == kattTag)
                {
                    item.IsEnabled = false;
                    item.Opacity = 0.2;
                    hany++;
                }
            }
            if (hany == grid.Children.Count)
            {
                MessageBox.Show("Ügyes! :3");
                Init(4, 5);
            }
        }

        //private void Kepez(int sor, int oszlop)
        //{
        //    Image kep = new Image();
        //    string fileSource = Environment.CurrentDirectory + "\\Images\\1.jpg";
        //    this.Title = fileSource;
        //    kep.Source = new BitmapImage(new Uri(fileSource));
        //    grid.Children.Add(kep);
        //}

        public MainWindow()
        {
            InitializeComponent();
            Init(4,5);
            //Kepez(4, 4);
        }
    }
}
