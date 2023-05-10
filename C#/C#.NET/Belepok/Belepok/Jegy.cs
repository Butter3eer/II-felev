using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belepok
{
    internal class Jegy
    {
        private string tipus;
        private string tobbszori;

        public Jegy(string tipus, string tobbszori)
        {
            this.tipus = tipus;
            this.tobbszori = tobbszori;
        }

        public virtual int Ar()
        {
            int ar = 0;
            if (this.tobbszori == "egyszeri")
            {
                if (this.tipus == "felnőtt")
                {
                    ar = 4000;
                }
                else
                {
                    ar = 2000;
                }
            }
            else
            {
                if (this.tipus == "felnőtt")
                {
                    ar = 4500;
                }
                else
                {
                    ar = 2500;
                }
            }
            return ar;
        }

        public string Tipus { get => tipus; set => tipus = value; }
        public string Tobbszori { get => tobbszori; set => tobbszori = value; }

        public override string ToString()
        {
            return $"{this.tipus}, {this.Ar()}Ft, {this.tobbszori}";
        }
    }
}
