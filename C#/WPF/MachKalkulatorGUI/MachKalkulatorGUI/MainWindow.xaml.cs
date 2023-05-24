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

namespace MachKalkulatorGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            grid.Background = Brushes.PeachPuff;
        }

        private void Szamol(object sender, RoutedEventArgs e)
        {
            try
            {
                double qc = Convert.ToDouble(QcInput.Text);
                double po = Convert.ToDouble(PoInput.Text);

                double ma = Math.Sqrt(5 * (Math.Pow(qc / po + 1, (double)2 / 7) - 1));
                if (ma < 1)
                {
                    listaBox.Items.Add($"qc = {qc} p0 = {po} Ma = {ma}");
                }

                QcInput.Text = "";
                PoInput.Text = "";
            }
            catch
            {
                MessageBox.Show("Nem megfelelő a bemeneti karakterlánc formátuma. ");
                QcInput.Text = "";
                PoInput.Text = "";
            } 
        }
    }
}
