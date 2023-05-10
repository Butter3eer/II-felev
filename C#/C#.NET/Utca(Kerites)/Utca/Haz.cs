using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utca
{
    internal class Haz
    {
        public List<Haz> lista;
        private int parosParatlan;
        private int telekSzelesseg;
        private string festes;
        private int hazszam = 0;

        public Haz(int parosParatlan, int telekSzelesseg, string festes)
        {
            this.parosParatlan = parosParatlan;
            this.telekSzelesseg = telekSzelesseg;
            this.festes = festes;
        }

        public bool ParosParatlan
        {
            get
            {
                if (parosParatlan == 0)
                {
                    return true;
                }
                return false;
            }
        }
        public int TelekSzelesseg { get => telekSzelesseg; set => telekSzelesseg = value; }
        public string Festes { get => festes; set => festes = value; }
        public int Hazszam(List<Haz> lista)
        {
            int index = lista.IndexOf(this);
            int parosdb = 0;
            int paratlandb = -1;

            if (lista.Contains(this))
            { 
                for (int i = 0; i < index + 1; i++)
                {
                    if (lista[i].ParosParatlan)
                    {
                        parosdb += 2;
                    }
                    else
                    {
                        paratlandb += 2;
                    }

                }              
                if (ParosParatlan)
                {
                    hazszam = parosdb;
                }
                else
                {
                    hazszam = paratlandb;
                }
            }
            return hazszam;
        }
    }
}
