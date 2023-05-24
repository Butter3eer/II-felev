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

namespace RGB_keprajzol
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<List<Pont>> lista = new List<List<Pont>>();
        public MainWindow()
        {
            InitializeComponent();
            Beolvas();
            Rajzol();
        }

        public void Beolvas()
        {
            StreamReader file = new StreamReader("kep.txt");
            while (!file.EndOfStream)
            {
                int hanyadik = 0;
                string[] reszek = file.ReadLine().Split(' ');
                List<Pont> sor = new List<Pont>();
                for (int i = 0; i < reszek.Length / 3; i++)
                {
                    Pont pont = new Pont(Convert.ToByte(reszek[hanyadik]), Convert.ToByte(reszek[hanyadik]), Convert.ToByte(reszek[hanyadik]));
                    sor.Add(pont);
                    hanyadik += 3;
                }
                lista.Add(sor);
            }
            file.Close();
        }

        public void Rajzol()
        {
            BitmapImage kep = new BitmapImage(new Uri("/kep.jpg", UriKind.Relative));
            vaszon.Source = kep;
            WriteableBitmap writeableBitmap = new WriteableBitmap(kep);
            int stride = (writeableBitmap.PixelWidth * writeableBitmap.Format.BitsPerPixel +7);
            byte[] pixelBuffer = new byte[writeableBitmap.PixelHeight * stride];
            writeableBitmap.CopyPixels(pixelBuffer, stride, 0);

            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < lista[i].Count; j++)
                {
                    int pixelIndex = i * stride + j * writeableBitmap.Format.BitsPerPixel / 8;
                    pixelBuffer[pixelIndex + 2] = lista[i][j].R;
                }
            }
            writeableBitmap.WritePixels(new Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight), pixelBuffer, stride, 0);
                vaszon.Source = writeableBitmap;
        }
    }
}
