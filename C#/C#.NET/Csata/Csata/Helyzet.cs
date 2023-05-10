using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csata
{
    internal class Helyzet
    {
        private double x;
        private double y;

        public Helyzet(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public override string ToString()
        {
            return $"({this.x} : {this.y})";
        }
    }
}
