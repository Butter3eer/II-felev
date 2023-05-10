using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUtazas
{
	internal class Utasok
	{
		public int MegHely { get; }
		public DateTime FelDatum { get; }
		public int Kartya { get; }
		public string Tipus { get; }
		public int Darab { get; }
		public DateTime Erveny {
			get
			{
				if (Darab > 10)
				{
					string db = Darab.ToString();
                    return new DateTime(int.Parse(db.Substring(0, 4)), int.Parse(db.Substring(4, 2)), int.Parse(db.Substring(6, 2)));
				}
				else
				{
					return new DateTime(1848, 3, 14);
				}
			}
		}

		public bool kedvezmenyes
		{
			get
			{
				List<string> kedvezmenyes = new List<string>() {"TAB", "NYB"};

                if (kedvezmenyes.Contains(Tipus))
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

        public bool Ingyenes
        {
            get
            {
                List<string> Ingyenes = new List<string>() { "NYP", "RVS", "GYK" };

                if (Ingyenes.Contains(Tipus))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool Ervenyes
		{
			get
			{
				if (Darab == 0)
				{
					return false;
				}
				else if (Erveny < FelDatum)

                {
                    return false;
                }
				else
				{
					return true;
				}
			}
		}

		public Utasok(string sor)
		{
			string[] reszek = sor.Split(' ');
			
			this.MegHely = int.Parse(reszek[0]);

            int ev = int.Parse(reszek[1].Substring(0, 4));
            int ho = int.Parse(reszek[1].Substring(4, 2));
            int nap = int.Parse(reszek[1].Substring(6, 2));
            int ora = int.Parse(reszek[1].Substring(9, 2));
            int perc = int.Parse(reszek[1].Substring(11, 2));


            this.FelDatum = new DateTime(ev, ho, nap, ora, perc, 0);
			this.Kartya = int.Parse(reszek[2]);
			this.Tipus = reszek[3];
			this.Darab = int.Parse(reszek[4]);
		}

		public override string ToString()
		{
			return $"{MegHely} {FelDatum.Date} {Kartya} {Tipus} {Darab} {Erveny.Date}";
		}
	}
}
