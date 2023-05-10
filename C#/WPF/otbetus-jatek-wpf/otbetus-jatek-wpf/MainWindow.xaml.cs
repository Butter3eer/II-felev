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

namespace otbetus_jatek_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> szavak = new List<string>();

        private void Beolvas(string file)
        {
            szavak.Clear();
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                szavak.Add(sr.ReadLine());
            }

            sr.Close();
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
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (szavak.Count > 0)
            {
                foreach (var item in szavak)
                {
                    szavakListBox.Items.Add(item);
                }
            }
        }
    }
}
