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

namespace menu
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

        private void Betesz()
        {
            if (tb1.Text.Length == 5)
            {
                lb1.Items.Add(tb1.Text);
                tb1.Clear();
                tb1.Focus();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Betesz();
        }

        private void tb1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Betesz();
            }
        }

        private void Valaszt()
        {
            Random r = new Random();
            int melyiket = r.Next(lb1.Items.Count);
            valasztottBlock.Text = lb1.Items[melyiket].ToString();
        }
    }
}
