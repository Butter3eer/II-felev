using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_telekocsi
{
    internal class Autok
    {
        private string indulas;
        private string cel;
        private string rendszam;
        private string telefonszam;
        private int ferohely;
        private string utvonal;

        public Autok(string indulas, string cel, string rendszam, string telefonszam, int ferohely, string utvonal)
        {
            this.indulas = indulas;
            this.cel = cel;
            this.rendszam = rendszam;
            this.telefonszam = telefonszam;
            this.ferohely = ferohely;
            this.utvonal = utvonal;
        }

        public string Indulas { get => indulas; set => indulas = value; }
        public string Cel { get => cel; set => cel = value; }
        public string Rendszam { get => rendszam; set => rendszam = value; }
        public string Telefonszam { get => telefonszam; set => telefonszam = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public string Utvonal { get => utvonal; set => utvonal = value; }
    }
}
