using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar
{
    internal class Merkozes
    {
        private Csapat hazai;
        private Csapat idegen;
        private string helyszin;
        private DateTime ido;

        public Merkozes(Csapat hazai, Csapat idegen, string helyszin, DateTime ido)
        {
            this.hazai = hazai;
            this.idegen = idegen;
            this.helyszin = helyszin;
            this.ido = ido;
        }

        public string Helyszin { get => helyszin; set => helyszin = value; }
        public DateTime Ido { get => ido; set => ido = value; }
        internal Csapat Hazai { get => hazai; set => hazai = value; }
        internal Csapat Idegen { get => idegen; set => idegen = value; }
    }
}
