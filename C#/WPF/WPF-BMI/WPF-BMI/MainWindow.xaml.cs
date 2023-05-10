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

namespace WPF_BMI
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

        private double BMI()
        {
            double suly = Convert.ToDouble(input2.Text);
            double magassag = Convert.ToDouble(input3.Text) / 100;
            double bmi = Math.Round(suly / Math.Pow(magassag, 2), 2);
            return bmi;
        }

        private void Kiszamol(object sender, RoutedEventArgs e)
        {

            eredmeny.Content = "BMI: " + BMI();

            if (BMI() >= 18.5 && BMI() < 25)
            {
                eredmeny.Foreground = Brushes.Green;
            }
            else if (BMI() < 18.5)
            {
                eredmeny.Foreground = Brushes.Red;
                nyil.Source = new BitmapImage(new Uri("E:\\STUDY\\Petrik\\II-felev\\C#\\WPF-BMI\\WPF-BMI\\Images\\downarrow.png"));
            }
            else
            {
                eredmeny.Foreground = Brushes.Red;
                nyil.Source = new BitmapImage(new Uri("E:\\STUDY\\Petrik\\II-felev\\C#\\WPF-BMI\\WPF-BMI\\Images\\uparrow.png"));
            }
        }

        private void Kilistaz(object sender, RoutedEventArgs e)
        {
            string nev = input1.Text;
            lista.Items.Add(nev + ": " + BMI());
        }
    }

}
