using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_telekocsi
{
    class Igenyek
    {
        private string azonosito;
        private string igenyindulas;
        private string igenycel;
        private int szemelyek;
        private string igenyutvonal;

        public Igenyek(string azonosito, string igenyindulas, string igenycel, int szemelyek, string igenyutvonal)
        {
            this.azonosito = azonosito;
            this.igenyindulas = igenyindulas;
            this.igenycel = igenycel;
            this.szemelyek = szemelyek;
            this.igenyutvonal = igenyutvonal;
        }

        public string Azonosito { get => azonosito; set => azonosito = value; }
        public string Igenyindulas { get => igenyindulas; set => igenyindulas = value; }
        public string Igenycel { get => igenycel; set => igenycel = value; }
        public int Szemelyek { get => szemelyek; set => szemelyek = value; }
        public string Igenyutvonal { get => igenyutvonal; set => igenyutvonal = value; }
    }
}
