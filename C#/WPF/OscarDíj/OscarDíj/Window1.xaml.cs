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
using System.Windows.Shapes;

namespace OscarDíj
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		private void megjelenit(List<Film> films)
		{
			//DataGrid dagrid = new DataGrid();
			//dagrid.ItemsSource = films;
			//grid.Children.Add(dagrid);
			StackPanel sp = new StackPanel();
			sp.Orientation = Orientation.Vertical;
			grid.Children.Add(sp);
			foreach (var item in films)
			{
				StackPanel sp1 = new StackPanel();
				sp1.Orientation = Orientation.Horizontal;
				Button b = new Button();
				b.Content = item.Cim;
				b.Width = 150;
				sp1.Children.Add(b);
				TextBlock tb = new TextBlock();
				tb.Text = item.Ev.ToString();
				sp1.Children.Add(tb);
				
				sp.Children.Add(sp1);
			}
		}
		public Window1(List<Film> films)
		{
			InitializeComponent();
			megjelenit(films);
			
		}
	}
}
