using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUtazas
{
	internal class Utasok
	{
		private int megHely;
		private DateTime felDatum;
		private int kartya;
		private string tipus;
		private int darab;
		private DateTime erveny;

		public Utasok(int megHely, DateTime felDatum, int kartya, string tipus, int darab, DateTime erveny)
		{
			this.megHely = megHely;
			this.felDatum = felDatum;
			this.kartya = kartya;
			this.tipus = tipus;
			this.darab = darab;
			this.erveny = erveny;
		}

		public int megHely { get => megHely; }
		public DateTime felDatum { get => felDatum; }
		public int kartya { get => kartya; }
		public string tipus { get => tipus; }
		public int darab { get => darab; }
		public DateTime erveny { get => erveny; }

		public override string ToString()
		{
			return $"{megHely} {felDatum.Date} {kartya} {tipus} {darab} {erveny.Date}";
		}
	}
}
