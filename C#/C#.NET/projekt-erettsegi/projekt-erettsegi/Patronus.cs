using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_erettsegi
{
    internal class Patronus
    {
        private string evszak;
        private string idojaras;
        private string erdoto;
        private string tamadved;
        private string vegpatronus;

        public Patronus(string evszak, string idojaras, string erdoto, string tamadved, string vegpatronus)
        {
            this.evszak = evszak;
            this.idojaras = idojaras;
            this.erdoto = erdoto;
            this.tamadved = tamadved;
            this.vegpatronus = vegpatronus;
        }

        public string Evszak { get => evszak; set => evszak = value; }
        public string Idojaras { get => idojaras; set => idojaras = value; }
        public string Erdoto { get => erdoto; set => erdoto = value; }
        public string Tamadved { get => tamadved; set => tamadved = value; }
        public string Vegpatronus { get => vegpatronus; set => vegpatronus = value; }

        public override string ToString()
        {
            return $"({this.vegpatronus})";
        }
    }
}
