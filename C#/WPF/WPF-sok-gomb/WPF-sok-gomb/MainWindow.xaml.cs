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

namespace WPF_sok_gomb
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gombol(100);
        }

        private void gombol(int hany)
        {
            panel.Children.Clear();
            for (int i = 0; i < hany; i++)
            {
                Button b = new Button();
                b.Content = i + 1;
                b.Width = 20;
                b.Height = 20;
                b.Background = Brushes.OliveDrab;
                b.Margin = new Thickness(1);
                b.Click += megnyomtak;
                panel.Children.Add(b);
            }
        }

        private void megnyomtak(object sender, RoutedEventArgs e)
        {
            (sender as Button).Visibility = Visibility.Hidden;
        }

        private void pirul(object sender, RoutedEventArgs e)
        {
            foreach (Button item in panel.Children)
            {
                item.Background = Brushes.Red;
            }
        }
    }
}
