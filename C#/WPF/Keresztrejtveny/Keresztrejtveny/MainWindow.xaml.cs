using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Keresztrejtveny
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

        public List<string> szavak = new List<string>();
        public EasyQuestions easyWindow = new EasyQuestions();
        public MediumQuestions mediumWindow = new MediumQuestions();
        public HardQuestions hardWindow = new HardQuestions();
        public Popup popup = new Popup();

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                Beolvas(ofd.FileName);
            }
        }

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

        //---------MENÜ------------//
        private void Easy_click(object sender, RoutedEventArgs e)
        {
            MainPage.Visibility = Visibility.Collapsed;
            EasyJatek.Visibility = Visibility.Visible;
            MediumJatek.Visibility = Visibility.Collapsed;
            HardJatek.Visibility = Visibility.Collapsed;
            easyWindow.Owner = this;
            easyWindow.Show();
            if (mediumWindow.IsVisible)
            {
                mediumWindow.Visibility = Visibility.Collapsed;
            }
            if (hardWindow.IsVisible)
            {
                hardWindow.Visibility = Visibility.Collapsed;
            }
        }

        private void Medium_click(object sender, RoutedEventArgs e)
        {
            MainPage.Visibility = Visibility.Collapsed;
            EasyJatek.Visibility = Visibility.Collapsed;
            MediumJatek.Visibility = Visibility.Visible;
            HardJatek.Visibility = Visibility.Collapsed;
            mediumWindow.Owner = this;
            mediumWindow.Show();

            if (easyWindow.IsVisible)
            {
                easyWindow.Visibility = Visibility.Collapsed;
            }
            if (hardWindow.IsVisible)
            {
                hardWindow.Visibility = Visibility.Collapsed;
            }
        }

        private void Hard_click(object sender, RoutedEventArgs e)
        {
            MainPage.Visibility = Visibility.Collapsed;
            EasyJatek.Visibility = Visibility.Collapsed;
            MediumJatek.Visibility = Visibility.Collapsed;
            HardJatek.Visibility = Visibility.Visible;
            hardWindow.Owner = this;
            hardWindow.Show();

            if (easyWindow.IsVisible)
            {
                easyWindow.Visibility = Visibility.Collapsed;
            }
            if (mediumWindow.IsVisible)
            {
                mediumWindow.Visibility = Visibility.Collapsed;
            }
        }

        private void Menu_click(object sender, RoutedEventArgs e)
        {
            MainPage.Visibility = Visibility.Visible;
            EasyJatek.Visibility = Visibility.Collapsed;
            MediumJatek.Visibility = Visibility.Collapsed;
            HardJatek.Visibility = Visibility.Collapsed;
            if (easyWindow.IsVisible)
            {
                easyWindow.Visibility = Visibility.Collapsed;
            }
            if (mediumWindow.IsVisible)
            {
                mediumWindow.Visibility = Visibility.Collapsed;
            }
            if (hardWindow.IsVisible)
            {
                hardWindow.Visibility = Visibility.Collapsed;
            }
        }

        //--------METÓDUSOK------------//
        public void FocusbolKiEasy(string textblockNev)
        {
            TextBlock textblock = (TextBlock)easyWindow.FindName(textblockNev);
            textblock.Background = Brushes.Transparent;
        }

        public void FocusbolKiMedium(string textblockNev)
        {
            TextBlock textblock = (TextBlock)mediumWindow.FindName(textblockNev);
            textblock.Background = Brushes.Transparent;
        }

        public void FocusbolKiHard(string textblockNev)
        {
            TextBlock textblock = (TextBlock)hardWindow.FindName(textblockNev);
            textblock.Background = Brushes.Transparent;
        }

        //---------EASY-------------//
        private void hogwartsFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes1 = (TextBlock)easyWindow.FindName("kerdes1");
            kerdes1.Background = Brushes.White;

            FocusbolKiEasy("kerdes2");
            FocusbolKiEasy("kerdes3");
            FocusbolKiEasy("kerdes4");
            FocusbolKiEasy("kerdes5");
        }

        private void norbertFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes2 = (TextBlock)easyWindow.FindName("kerdes2");
            kerdes2.Background = Brushes.White;
            FocusbolKiEasy("kerdes1");
            FocusbolKiEasy("kerdes3");
            FocusbolKiEasy("kerdes4");
            FocusbolKiEasy("kerdes5");
        }

        private void loveFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes3 = (TextBlock)easyWindow.FindName("kerdes3");
            kerdes3.Background = Brushes.White;
            FocusbolKiEasy("kerdes1");
            FocusbolKiEasy("kerdes2");
            FocusbolKiEasy("kerdes4");
            FocusbolKiEasy("kerdes5");
        }

        private void vajsorFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes4 = (TextBlock)easyWindow.FindName("kerdes4");
            kerdes4.Background = Brushes.White;
            FocusbolKiEasy("kerdes1");
            FocusbolKiEasy("kerdes2");
            FocusbolKiEasy("kerdes3");
            FocusbolKiEasy("kerdes5");
        }

        private void weasleyFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes5 = (TextBlock)easyWindow.FindName("kerdes5");
            kerdes5.Background = Brushes.White;
            FocusbolKiEasy("kerdes1");
            FocusbolKiEasy("kerdes2");
            FocusbolKiEasy("kerdes3");
            FocusbolKiEasy("kerdes4");
        }

        //-------------MEDIUM----------//
        private void csikocsorFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes1 = (TextBlock)mediumWindow.FindName("kerdes1");
            kerdes1.Background = Brushes.White;
            FocusbolKiMedium("kerdes2");
            FocusbolKiMedium("kerdes3");
            FocusbolKiMedium("kerdes4");
            FocusbolKiMedium("kerdes5");
            FocusbolKiMedium("kerdes6");
            FocusbolKiMedium("kerdes7");
        }

        private void griffendelFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes2 = (TextBlock)mediumWindow.FindName("kerdes2");
            kerdes2.Background = Brushes.White;
            FocusbolKiMedium("kerdes1");
            FocusbolKiMedium("kerdes3");
            FocusbolKiMedium("kerdes4");
            FocusbolKiMedium("kerdes5");
            FocusbolKiMedium("kerdes6");
            FocusbolKiMedium("kerdes7");
        }

        private void mirtillFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes3 = (TextBlock)mediumWindow.FindName("kerdes3");
            kerdes3.Background = Brushes.White;
            FocusbolKiMedium("kerdes1");
            FocusbolKiMedium("kerdes2");
            FocusbolKiMedium("kerdes4");
            FocusbolKiMedium("kerdes5");
            FocusbolKiMedium("kerdes6");
            FocusbolKiMedium("kerdes7");
        }

        private void alwaysFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes4 = (TextBlock)mediumWindow.FindName("kerdes4");
            kerdes4.Background = Brushes.White;
            FocusbolKiMedium("kerdes1");
            FocusbolKiMedium("kerdes2");
            FocusbolKiMedium("kerdes3");
            FocusbolKiMedium("kerdes5");
            FocusbolKiMedium("kerdes6");
            FocusbolKiMedium("kerdes7");
        }

        private void bolyhoskaFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes5 = (TextBlock)mediumWindow.FindName("kerdes5");
            kerdes5.Background = Brushes.White;
            FocusbolKiMedium("kerdes1");
            FocusbolKiMedium("kerdes2");
            FocusbolKiMedium("kerdes3");
            FocusbolKiMedium("kerdes4");
            FocusbolKiMedium("kerdes6");
            FocusbolKiMedium("kerdes7");
        }

        private void roxmortsFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes6 = (TextBlock)mediumWindow.FindName("kerdes6");
            kerdes6.Background = Brushes.White;
            FocusbolKiMedium("kerdes1");
            FocusbolKiMedium("kerdes2");
            FocusbolKiMedium("kerdes3");
            FocusbolKiMedium("kerdes4");
            FocusbolKiMedium("kerdes5");
            FocusbolKiMedium("kerdes7");
        }

        private void mumusFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes7 = (TextBlock)mediumWindow.FindName("kerdes7");
            kerdes7.Background = Brushes.White;
            FocusbolKiMedium("kerdes1");
            FocusbolKiMedium("kerdes2");
            FocusbolKiMedium("kerdes3");
            FocusbolKiMedium("kerdes4");
            FocusbolKiMedium("kerdes5");
            FocusbolKiMedium("kerdes6");
        }

        //-------HARD---------//
        private void zsupszkulcsFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes1 = (TextBlock)hardWindow.FindName("kerdes1");
            kerdes1.Background = Brushes.White;
            FocusbolKiHard("kerdes2");
            FocusbolKiHard("kerdes3");
            FocusbolKiHard("kerdes4");
            FocusbolKiHard("kerdes5");
            FocusbolKiHard("kerdes6");
            FocusbolKiHard("kerdes7");
            FocusbolKiHard("kerdes8");
            FocusbolKiHard("kerdes9");
        }

        private void varangydudvaFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes2 = (TextBlock)hardWindow.FindName("kerdes2");
            kerdes2.Background = Brushes.White;
            FocusbolKiHard("kerdes1");
            FocusbolKiHard("kerdes3");
            FocusbolKiHard("kerdes4");
            FocusbolKiHard("kerdes5");
            FocusbolKiHard("kerdes6");
            FocusbolKiHard("kerdes7");
            FocusbolKiHard("kerdes8");
            FocusbolKiHard("kerdes9");
        }

        private void comikulissimusFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes3 = (TextBlock)hardWindow.FindName("kerdes3");
            kerdes3.Background = Brushes.White;
            FocusbolKiHard("kerdes1");
            FocusbolKiHard("kerdes2");
            FocusbolKiHard("kerdes4");
            FocusbolKiHard("kerdes5");
            FocusbolKiHard("kerdes6");
            FocusbolKiHard("kerdes7");
            FocusbolKiHard("kerdes8");
            FocusbolKiHard("kerdes9");
        }

        private void tarantallegraFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes4 = (TextBlock)hardWindow.FindName("kerdes4");
            kerdes4.Background = Brushes.White;
            FocusbolKiHard("kerdes1");
            FocusbolKiHard("kerdes2");
            FocusbolKiHard("kerdes3");
            FocusbolKiHard("kerdes5");
            FocusbolKiHard("kerdes6");
            FocusbolKiHard("kerdes7");
            FocusbolKiHard("kerdes8");
            FocusbolKiHard("kerdes9");
        }

        private void sectumsempraFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes5 = (TextBlock)hardWindow.FindName("kerdes5");
            kerdes5.Background = Brushes.White;
            FocusbolKiHard("kerdes1");
            FocusbolKiHard("kerdes2");
            FocusbolKiHard("kerdes3");
            FocusbolKiHard("kerdes4");
            FocusbolKiHard("kerdes6");
            FocusbolKiHard("kerdes7");
            FocusbolKiHard("kerdes8");
            FocusbolKiHard("kerdes9");
        }

        private void incarcerandusFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes6 = (TextBlock)hardWindow.FindName("kerdes6");
            kerdes6.Background = Brushes.White;
            FocusbolKiHard("kerdes1");
            FocusbolKiHard("kerdes2");
            FocusbolKiHard("kerdes3");
            FocusbolKiHard("kerdes4");
            FocusbolKiHard("kerdes5");
            FocusbolKiHard("kerdes7");
            FocusbolKiHard("kerdes8");
            FocusbolKiHard("kerdes9");
        }

        private void padlasszornyFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes7 = (TextBlock)hardWindow.FindName("kerdes7");
            kerdes7.Background = Brushes.White;
            FocusbolKiHard("kerdes1");
            FocusbolKiHard("kerdes2");
            FocusbolKiHard("kerdes3");
            FocusbolKiHard("kerdes4");
            FocusbolKiHard("kerdes5");
            FocusbolKiHard("kerdes6");
            FocusbolKiHard("kerdes8");
            FocusbolKiHard("kerdes9");
        }

        private void aragogFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes8 = (TextBlock)hardWindow.FindName("kerdes8");
            kerdes8.Background = Brushes.White;
            FocusbolKiHard("kerdes1");
            FocusbolKiHard("kerdes2");
            FocusbolKiHard("kerdes3");
            FocusbolKiHard("kerdes4");
            FocusbolKiHard("kerdes5");
            FocusbolKiHard("kerdes6");
            FocusbolKiHard("kerdes7");
            FocusbolKiHard("kerdes9");
        }

        private void bumszalagborFocus(object sender, RoutedEventArgs e)
        {
            TextBlock kerdes9 = (TextBlock)hardWindow.FindName("kerdes9");
            kerdes9.Background = Brushes.White;
            FocusbolKiHard("kerdes1");
            FocusbolKiHard("kerdes2");
            FocusbolKiHard("kerdes3");
            FocusbolKiHard("kerdes4");
            FocusbolKiHard("kerdes5");
            FocusbolKiHard("kerdes6");
            FocusbolKiHard("kerdes7");
            FocusbolKiHard("kerdes8");
        }

        private void Ellenorzes(object sender, RoutedEventArgs e)
        {
            if (EasyJatek.Visibility == Visibility.Visible)
            {
                EllenMethod(EasyJatek, hogwarts, "HOGWARTS");
                EllenMethod(EasyJatek, norbert, "NORBERT");
                EllenMethod(EasyJatek, love, "LOVE");
                EllenMethod(EasyJatek, vajsor, "VAJSÖR");
                EllenMethod(EasyJatek, weasley, "WEASLEY");
            }
            if (MediumJatek.Visibility == Visibility.Visible)
            {
                EllenMethod(MediumJatek, csikocsor, "CSIKÓCSŐR");
                EllenMethod(MediumJatek, griffendel, "GRIFFENDÉL");
                EllenMethod(MediumJatek, mirtill, "MIRTILL");
                EllenMethod(MediumJatek, always, "ALWAYS");
                EllenMethod(MediumJatek, bolyhoska, "BOLYHOSKA");
                EllenMethod(MediumJatek, roxmorts, "ROXMORTS");
                EllenMethod(MediumJatek, mumus, "MUMUS");

            }
            if (HardJatek.Visibility == Visibility.Visible)
            {
                EllenMethod(HardJatek, zsupszkulcs, "ZSUBSZKULCS");
                EllenMethod(HardJatek, varangydudva, "VARANGYDUDVA");
                EllenMethod(HardJatek, tarantallegra, "TARANTALLEGRA");
                EllenMethod(HardJatek, sectumsempra, "SECTUMSEMPRA");
                EllenMethod(HardJatek, incarcerandus, "INCARCERANDUS");
                EllenMethod(HardJatek, comikulissimus, "COMIKULISSIMUS");
                EllenMethod(HardJatek, padlasszorny, "PADLÁSSZÖRNY");
                EllenMethod(HardJatek, aragog, "ARAGOG");
                EllenMethod(HardJatek, bumszalagbor, "BUMSZALAGBŐR");
            }
        }

        private void EllenMethod(Grid grid, Grid gridnev, string szo)
        {
            if (grid.Visibility == Visibility.Visible)
            {
                string tipp = "";
                foreach (UIElement child in gridnev.Children)
                {
                    if (child is TextBox)
                    {
                        if (((TextBox)child).Background != Brushes.Green)
                        {
                            tipp += ((TextBox)child).Text;
                        }
                    }
                }

                if (tipp.Length == szo.Length)
                {
                    if (tipp == szo)
                    {
                        foreach (UIElement child in gridnev.Children)
                        {
                            if (child is TextBox)
                            {
                                ((TextBox)child).Background = Brushes.Green;
                            }
                        }
                        //felugroText.Text = "Helyes! A nyeréshez tölts ki minden mezőt!";
                        //felugroText.Background = Brushes.DarkGreen;
                        //felugro.IsOpen = true;
                    }
                    else
                    {
                        foreach (UIElement child in gridnev.Children)
                        {
                            if (child is TextBox)
                            {
                                if (((TextBox)child).Text != "")
                                {
                                    ((TextBox)child).Background = Brushes.Red;
                                }
                            }
                        }
                        //felugroText.Text = "Hibás!";
                        //felugroText.Background = Brushes.DarkSalmon;
                        //felugro.IsOpen = true;
                    }
                }
            }
        }

        private void Popup_click(object sender, MouseButtonEventArgs e)
        {
            felugro.IsOpen = false;
        }
    }
}
