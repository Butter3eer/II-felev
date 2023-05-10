using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OscarDíj
{
    internal class Film
    {
        private int id;
        private int ev;
        private bool nyert;
        private string magyar;
        private string cim;
        private string bemutato;

        public Film(int id, int ev, bool nyert, string magyar, string cim, string bemutato)
        {
            this.id = id;
            this.ev = ev;
            this.nyert = nyert;
            this.magyar = magyar;
            this.cim = cim;
            this.bemutato = bemutato;
        }

        public int Id { get => id; }
        public int Ev { get => ev; }
        public bool Nyert { get => nyert; }
        public string Magyar { get => magyar; }
        public string Cim { get => cim; }
        public string Bemutato { get => bemutato; }
    }
}
