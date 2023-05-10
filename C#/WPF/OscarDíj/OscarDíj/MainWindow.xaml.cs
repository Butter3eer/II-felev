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

using System.IO;
using Microsoft.Win32;


namespace OscarDíj
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>

	public partial class MainWindow : Window
	{
	    List<Film>filmek=new List<Film>();
		List<Kapocs> kapcsok=new List<Kapocs>();
		List<Keszito> keszitok=new List<Keszito>();
		private void beolvas(string f)
		{
			StreamReader sr=new StreamReader(f);
			sr.ReadLine();
			while (!sr.EndOfStream)
			{
				string[]temp=sr.ReadLine().Split('\t');
				Film film = new Film(int.Parse(temp[0]), int.Parse(temp[1]),Convert.ToBoolean(Convert.ToInt32(temp[2])), temp[3], temp[4], temp[5]);
				filmek.Add(film);
			}
			sr.Close();
			sr=new StreamReader(Path.GetDirectoryName(f)+"\\keszito.txt");
			sr.ReadLine();
			while (!sr.EndOfStream)
			{
				string[] temp = sr.ReadLine().Split('\t');
				Keszito k = new Keszito(int.Parse(temp[0]), temp[1] );
				keszitok.Add(k);
			}
			
			sr.Close();
			sr = new StreamReader(Path.GetDirectoryName(f) + "\\kapcsolat.txt");
			sr.ReadLine();
			while (!sr.EndOfStream)
			{
				string[] temp = sr.ReadLine().Split('\t');
				Kapocs k = new Kapocs(int.Parse(temp[0]),int.Parse(temp[1]));
				kapcsok.Add(k);
			}
			sr.Close();

			dgrid.ItemsSource = filmek;
			comboEv.ItemsSource = filmek.Select(x => x.Ev).Distinct().OrderByDescending(x=>x);
		}
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MenuMegnyit_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			if (ofd.ShowDialog()==true)
			{
				beolvas(ofd.FileName);
			}
		}

		private string producer(int filmId)
		{
			int keszitoId = kapcsok.Find(x => x.FilmId == filmId).KeszitoId;
			return keszitok.Find(x => x.Id == keszitoId).Nev;
		}
		private void Combokatt(object sender, SelectionChangedEventArgs e)
		{
			dgrid.ItemsSource = filmek.Where(x => x.Ev == Convert.ToInt32(comboEv.SelectedItem.ToString()));
		}

		private void ButonProducer_click(object sender, RoutedEventArgs e)
		{
			if (dgrid.SelectedItems.Count>0)
			{
				if (dgrid.SelectedItems.Count > 1)
				{
					MessageBox.Show("Mivel többet is kijelöltél, csak az elsőnek adom meg a producerét","Producer");
				}
				MessageBox.Show(producer((dgrid.SelectedItem as Film).Id), "Producer");
			}
			else
			{
				MessageBox.Show("nem jelöltél ki filmet!","Hiba");
			}
				
		}

		private void ButtonUjAblak_click(object sender, RoutedEventArgs e)
		{
			Window1 uw = new Window1(filmek);
			uw.ShowDialog();
		}
	}
}
