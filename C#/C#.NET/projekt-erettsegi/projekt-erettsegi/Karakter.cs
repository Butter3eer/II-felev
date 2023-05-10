using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_erettsegi
{
    internal class Karakter
    {
        private Haz haz;
        private Patronus patronus;
        private Palca palca;
        private string keresztNev;
        private string vezetekNev;
        private string felhasznaloNev;
        private int eletkor;
        private string cim;

        public Karakter(string keresztNev, string vezetekNev, int eletkor, string cim, string felhasznaloNev)
        {
            this.keresztNev = keresztNev;
            this.vezetekNev = vezetekNev;
            this.eletkor = eletkor;
            this.cim = cim;
            this.felhasznaloNev = felhasznaloNev;
        }
        public void UjHaz(Haz haz)
        {
            this.haz = haz;
        }

        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string Cim { get => cim; set => cim = value; }
        public Haz Haz { get => haz; set => haz = value; }
        public Patronus Patronus { get => patronus; set => patronus = value; }
        public Palca Palca { get => palca; set => palca = value; }
        public string FelhasznaloNev { get => felhasznaloNev; set => felhasznaloNev = value; }
        public string KeresztNev { get => keresztNev; set => keresztNev = value; }
        public string VezetekNev { get => vezetekNev; set => vezetekNev = value; }

        public override string ToString()
        {
            string kiir = $"{this.keresztNev} {this.vezetekNev} ({this.felhasznaloNev}) : {this.eletkor} - {this.Cim}";
            if (this.palca != null)
            {
                kiir += $" - {this.palca}";
            }
            if (this.patronus != null)
            {
                kiir += $" - {this.patronus}";
            }
            if(this.haz != null)
            {
                kiir += $" - {this.haz}";
            }
            return kiir;
        }
    }
}
