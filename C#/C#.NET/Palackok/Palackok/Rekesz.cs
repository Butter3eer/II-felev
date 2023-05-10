using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Rekesz
    {
        List<Palack> palackok;
        private double max_teherbiras;

        public Rekesz(double max_teherbiras)
        {
            this.max_teherbiras = max_teherbiras;
            palackok = new List<Palack>();
        }

        public double Suly2()
        {
            double suly = 0;
            if (palackok.Count != 0)
            {               
                foreach (Palack item in palackok)
                {
                    suly += item.Suly();
                }
                return suly;
            }
            else
            {
                suly = 0;
                return suly;
            }
        }

        public void Uj_palack(Palack p)
        {
            if ((Suly2() + p.Suly()) < this.max_teherbiras)
            {
                palackok.Add(p);
                
            }
        }

        public double Osszes_penz()
        {
            Visszavalthato i;
            double penz = 0;
            foreach (var item in palackok)
            {
                if (item is Visszavalthato)
                {
                    i = item as Visszavalthato;
                    penz += i.Palackdij;
                }
            }
            return penz;
        }

        public double Max_teherbiras { get => max_teherbiras; set => max_teherbiras = value; }
    }
}
