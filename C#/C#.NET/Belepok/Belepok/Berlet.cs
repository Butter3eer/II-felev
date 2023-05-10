using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belepok
{
    internal class Berlet : Jegy
    {
        Jegy jegy;
        private int alkalmak;
        private int hasznaltAlkalmak;
        private int ervenyesHonapok;

        public Berlet(string tipus, string tobbszori, int alkalmak, int hasznaltAlkalmak, int ervenyesHonapok) : base(tipus, tobbszori)
        {
            this.alkalmak = alkalmak;
            this.hasznaltAlkalmak = hasznaltAlkalmak;
            this.ervenyesHonapok = ervenyesHonapok;
        }

        public int Alkalmak { get => alkalmak; set => alkalmak = value; }
        public int HasznaltAlkalmak { get => hasznaltAlkalmak; set => hasznaltAlkalmak = value; }
        public int ErvenyesHonapok { get => ervenyesHonapok; set => ervenyesHonapok = value; }

        public bool BerletHasznal()
        {
            if (this.alkalmak - this.hasznaltAlkalmak > 0)
            {
                this.hasznaltAlkalmak += 1;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int Ar()
        {
            double ar = 0;
        
            if (this.Tipus == "felnőtt")
            {
                ar = this.alkalmak * (4000 * 0.9);
            }
            else
            {
                ar = this.alkalmak * (2000 * 0.9);
            }
            return (int)ar;
        }

        public override string ToString()
        {
            return $"{this.jegy.Tipus}, {this.Ar()}Ft, {this.Tobbszori}, {this.alkalmak}/{this.hasznaltAlkalmak} alkalom, {this.ervenyesHonapok} hónap";
        }
    }
}
