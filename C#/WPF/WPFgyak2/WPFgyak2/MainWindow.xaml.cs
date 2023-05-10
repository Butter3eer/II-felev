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

namespace WPFgyak2
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

        public void BeleIr()
        {
            TB1.Text = "Megnyomtak.";
        }

        public void BeleIr2()
        {
            TB1.Text = "Engem is megnyomtak.";
        }

        private bool Kattintott = false;
        private bool Kattintott2 = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Kattintott = true;
            if (Kattintott)
            {
                BeleIr();
            }
            if (Kattintott2)
            {
                Kattintott = false;
                BeleIr2();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Kattintott2 = true;
            if (Kattintott2)
            {
                BeleIr();
            }
            if (Kattintott)
            {
                Kattintott2 = false;
                BeleIr2();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            TB2.Text = (Convert.ToInt16(TB2.Text)-1).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            TB2.Text = (Convert.ToInt16(TB2.Text) + 1).ToString();
        }
    }
}
