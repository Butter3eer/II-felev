using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton
{
    internal class Verseny
    {
        private string versenyzoNeve;
        private int rajtSzam;
        private string kategoria;
        private string elertIdo;
        private int befejezettTav;

        public Verseny(string versenyzoNeve, int rajtSzam, string kategoria, string elertIdo, int befejezettTav)
        {
            this.versenyzoNeve = versenyzoNeve;
            this.rajtSzam = rajtSzam;
            this.kategoria = kategoria;
            this.elertIdo = elertIdo;
            this.befejezettTav = befejezettTav;
        }

        public string VersenyzoNeve { get => versenyzoNeve; set => versenyzoNeve = value; }
        public int RajtSzam { get => rajtSzam; set => rajtSzam = value; }
        public string Kategoria { get => kategoria; set => kategoria = value; }
        public string ElertIdo { get => elertIdo; set => elertIdo = value; }
        public int BefejezettTav { get => befejezettTav; set => befejezettTav = value; }
        public double IdoOraban
        {
            get
            {
                string[] reszek = elertIdo.Split(':');
                double orak = Convert.ToDouble(reszek[0]);
                double percek = Convert.ToDouble(reszek[1]);
                double masodpercek = Convert.ToDouble(reszek[2]);
                orak += (percek / 60) + (masodpercek / 3600);
                return orak;
            }
        }
    }
}
