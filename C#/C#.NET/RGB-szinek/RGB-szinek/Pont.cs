using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_szinek
{
    internal class Pont
    {
        private int piros;
        private int zold;
        private int kek;

        public Pont(int piros, int zold, int kek)
        {
            this.piros = piros;
            this.zold = zold;
            this.kek = kek;
        }

        public int Piros { get => piros; set => piros = value; }
        public int Zold { get => zold; set => zold = value; }
        public int Kek { get => kek; set => kek = value; }

        public int OsszErtek
        {
            get
            {
                return piros + kek + zold;
            }
        }

        public bool VilagosE
        {
            get
            {
                return OsszErtek > 600;
            }
        }
    }
}
