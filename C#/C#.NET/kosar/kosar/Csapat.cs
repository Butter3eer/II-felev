﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar
{
    internal class Csapat
    {
        private string nev;
        private int pontszam;

        public Csapat(string nev, int pontszam)
        {
            this.nev = nev;
            this.pontszam = pontszam; 
        }

        public string Nev { get => nev; set => nev = value; }
        public int Pontszam { get => pontszam; set => pontszam = value; }
    }
}
