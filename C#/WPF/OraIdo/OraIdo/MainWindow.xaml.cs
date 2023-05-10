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
using System.Windows.Threading;

namespace OraIdo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer time = new DispatcherTimer();
        private void OraInit()
        {
            time.Interval = TimeSpan.FromSeconds(1);
            visszaBlock.Text = Tb.Text;
            time.Tick += Oramegy;
        }

        private void Oramegy(object? sender, EventArgs e)
        {
            visszaBlock.Text = (Convert.ToInt16(visszaBlock.Text) - 1).ToString();
            if (visszaBlock.Text == "0")
            {
                time.Stop();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            OraInit();
        }

        private void Indul_click(object sender, RoutedEventArgs e)
        {
            OraIndit();
        }

        private void OraIndit()
        {
            visszaBlock.Text = Tb.Text;
            time.Start();
        }
    }
}
