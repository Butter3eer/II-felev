using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Palack
    {
        private string nev;
        private int maxUrtartalom;
        private int jelenlegi;

        public Palack(string nev, int maxUrtartalom, int jelenlegi)
        {
            this.nev = nev;
            this.maxUrtartalom = maxUrtartalom;
            Jelenlegi = jelenlegi;
        }

        public Palack(string nev, int maxUrtartalom)
        {
            this.nev = nev;
            this.maxUrtartalom = maxUrtartalom;
            this.jelenlegi = 1;
        }
        public string Nev { get => nev; set => nev = value; }
        public int MaxUrtartalom { get => maxUrtartalom; set => maxUrtartalom = value; }
        public int Jelenlegi
        {
            get => jelenlegi;
            set
            {
                if (value > this.maxUrtartalom)
                {
                    this.jelenlegi = maxUrtartalom;
                }
                else if (value <= 0)
                {
                    this.jelenlegi = 0;
                    this.nev = null;
                }
                else
                {
                    jelenlegi = value;
                }
            }
        }

        public double Suly()
        {
            return this.maxUrtartalom / 35 + this.jelenlegi;
        }

        public bool Equals(Palack p)
        {
            if (p.nev == this.nev && p.maxUrtartalom == this.maxUrtartalom && p.jelenlegi == this.jelenlegi)
            {
                return true;
            }
            return false;
        }

        public void Hozzaont(Palack p)
        {
            if (this.nev == p.nev)
            {
                Jelenlegi += p.jelenlegi;
                p.Jelenlegi = 0;
            }
            else if (this.nev != p.nev)
            {
                this.nev = "Keverek";
                Jelenlegi += p.jelenlegi;
                p.Jelenlegi = 0;
            }
            if (this.nev == null)
            {
                this.nev = p.nev;
                Jelenlegi = p.jelenlegi;
            }
        }

        public override string ToString()
        {
            return $"{this.nev} {this.maxUrtartalom} {this.jelenlegi}";
        }
    }
}
