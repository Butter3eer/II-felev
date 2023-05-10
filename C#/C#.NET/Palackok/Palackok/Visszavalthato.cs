using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palackok
{
    internal class Visszavalthato : Palack
    {
        private int palackdij;


        public Visszavalthato(string nev, int maxUrtartalom, int jelenlegi, int palackdij) : base(nev, maxUrtartalom, jelenlegi)
        {
            this.palackdij = palackdij;
        }

        public Visszavalthato(string nev, int maxUrtartalom, int jelenlegi) : base(nev, maxUrtartalom, jelenlegi)
        {
            this.palackdij = 25;
        }
        public int Palackdij { get => palackdij; set => palackdij = value; }

        public override string ToString()
        {
            return "Visszaváltható palack: " + base.ToString();
        }
    }
}
