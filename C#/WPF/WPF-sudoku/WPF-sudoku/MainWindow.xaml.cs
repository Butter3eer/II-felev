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

namespace WPF_sudoku
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

        private void minusz(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(tbmennyi.Text) > 4)
            {
                tbmennyi.Text = (Convert.ToInt16(tbmennyi.Text) - 1).ToString();
            }
        }

        private void plusz(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(tbmennyi.Text) < 9)
            {
                tbmennyi.Text = (Convert.ToInt16(tbmennyi.Text) + 1).ToString();
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            hosszLabel.Content = szamsor.Text.Length;
        }

        private void ellenoriz()
        {
            string szoveg = "Megfelelő hosszúságú!";
            if (Convert.ToInt16(tbmennyi.Text) == Convert.ToInt16(hosszLabel.Content))
            {
                MessageBox.Show(szoveg);
            }
            else if (Convert.ToInt16(tbmennyi.Text) < Convert.ToInt16(hosszLabel.Content))
            {
                szoveg = "Nem lehet hosszabb a megadottnál.";
                MessageBox.Show(szoveg);
            }
            else
            {
                szoveg = "Nem lehet rövidebb a megadottnál.";
                MessageBox.Show(szoveg);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ellenoriz();
        }
    }
}
