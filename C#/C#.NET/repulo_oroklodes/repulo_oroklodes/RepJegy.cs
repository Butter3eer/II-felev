using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulo_oroklodes
{
    internal class RepJegy
    {
        private string celVaros;
        private DateTime indulIdo;

        public RepJegy(string celVaros, DateTime indulIdo)
        {
            this.celVaros = celVaros;
            this.indulIdo = indulIdo;
        }

        public string CelVaros { get => celVaros; set => celVaros = value; }
        public DateTime IndulIdo { get => indulIdo; set => indulIdo = value; }

        public override string ToString()
        {
            return $"{this.celVaros} {this.indulIdo.Year}-{this.indulIdo.Month}-{this.indulIdo.Day} {this.indulIdo.Hour}:{this.indulIdo.Minute}";
        }
    }
}
