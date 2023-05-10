using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fogado_hazi
{
    internal class Fogado
    {
        private string veznev;
        private string utnev;
        private DateTime fogido;
        private DateTime rogido;

        public Fogado(string veznev, string utnev, DateTime fogido, DateTime rogido)
        {
            this.veznev = veznev;
            this.utnev = utnev;
            this.fogido = fogido;
            this.rogido = rogido;
        }

        public string Veznev { get => veznev; set => veznev = value; }
        public string Utnev { get => utnev; set => utnev = value; }
        public DateTime Fogido { get => fogido; set => fogido = value; }
        public DateTime Rogido { get => rogido; set => rogido = value; }

        public override string ToString()
        {
            return $"{this.Veznev} {this.Utnev} {this.Fogido.Date} {this.Rogido.Date}";
        }

        static void Main(string[] args)
        {
        }

        
    }
}
