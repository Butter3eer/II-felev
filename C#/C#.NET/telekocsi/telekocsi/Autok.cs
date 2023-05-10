using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace telekocsi
{
    internal class Autok
    {
        private string ind;
        private string cel;
        private string rendsz;
        private string tel;
        private int ferohely;
        private string utvonal;

        public Autok(string ind, string cel, string rendsz, string tel, int ferohely, string utvonal)
        {
            this.ind = ind;
            this.cel = cel;
            this.rendsz = rendsz;
            this.tel = tel;
            this.ferohely = ferohely;
            this.utvonal = utvonal;
        }

        public string Ind { get => ind; set => ind = value; }
        public string Cel { get => cel; set => cel = value; }
        public string Rendsz { get => rendsz; set => rendsz = value; }
        public string Tel { get => tel; set => tel = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public string Utvonal { get => utvonal; set => utvonal = value; }

        public override string ToString()
        {
            return $"{this.ind} {this.cel} {this.rendsz} {this.tel} {this.ferohely} {this.utvonal}";
        }
    }

}
