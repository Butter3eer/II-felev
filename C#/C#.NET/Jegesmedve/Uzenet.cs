using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegesmedve
{
    public class Uzenet
    {
        private int nap;
        private int radioamator;
        private string szoveg = "";



        public Uzenet(int nap, int radioamator, string szoveg)
        {
            this.Nap = nap;
            this.Radioamator = radioamator;
            this.Szoveg = szoveg;
        }

        public int Nap { get => nap; set => nap = value; }

        public string Szoveg { get => szoveg; set => szoveg = value; }
        public int Radioamator { get => radioamator; set => radioamator = value; }
    }
}
