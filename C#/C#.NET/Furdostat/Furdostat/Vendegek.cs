using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furdostat
{
    internal class Vendegek
    {
        private int vendegAzon;
        private int reszlegAzon;
        private int beKi;
        private double ora;
        private double perc;
        private double masodperc;
        private DateTime idopont = DateTime.ParseExact($"00:00:00", "HH:mm:ss", CultureInfo.CurrentCulture);

        public Vendegek(int vendegAzon, int reszlegAzon, int beKi, double ora, double perc, double masodperc)
        {
            this.vendegAzon = vendegAzon;
            this.reszlegAzon = reszlegAzon;
            this.beKi = beKi;
            this.ora = ora;
            this.perc = perc;
            this.masodperc = masodperc;
            this.idopont = idopont.AddHours(ora).AddMinutes(perc).AddSeconds(masodperc);
        }

        public int VendegAzon { get => vendegAzon; set => vendegAzon = value; }
        public int ReszlegAzon { get => reszlegAzon; set => reszlegAzon = value; }
        public int BeKi { get => beKi; set => beKi = value; }
        public double Ora { get => ora; set => ora = value; }
        public double Perc { get => perc; set => perc = value; }
        public double Masodperc { get => masodperc; set => masodperc = value; }
        public string Reszleg
        {
            get
            {
                string eredmeny = "";
                switch (reszlegAzon)
                {
                    case 0:
                        eredmeny = "Öltöző";
                        break;
                    case 1:
                        eredmeny = "Uszoda";
                        break;
                    case 2:
                        eredmeny = "Szaunák";
                        break;
                    case 3:
                        eredmeny = "Gyógyvizes medencék";
                        break;
                    case 4:
                        eredmeny = "Strand";
                        break;
                }
                return eredmeny;
            }
        }
        public bool beKiBool
        {
            get
            {
                if (beKi == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public DateTime Idopont { get => idopont; set => idopont = value; }
    }
}
