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

namespace Idozitos_LOIM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Beolvas();
        }

        List<string> kerdesek = new List<string>();

        private void Beolvas()
        {
            kerdesek.Clear();
            StreamReader file = new StreamReader("kerdes.txt");
            while (!file.EndOfStream)
            {
                kerdesek.Add(file.ReadLine());
            }

            file.Close();
        }
    }
}
