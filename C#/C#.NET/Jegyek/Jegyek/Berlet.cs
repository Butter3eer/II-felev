using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyek
{
    internal class Berlet : Jegy
    {
        protected DateTime lejarat;
        public Berlet(DateTime datum, int napokSzama)
        {
            lejarat = datum.AddDays(napokSzama);
            ar = napokSzama * Napiar;
            Datum = datum;
            NapokSzama = napokSzama;
        }

        public override bool Ervenyesit()
        {
            if (lejarat > DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public DateTime Datum { get; }
        public int NapokSzama { get; }
        public DateTime Lejarat { get { return lejarat; } }
    }
}
