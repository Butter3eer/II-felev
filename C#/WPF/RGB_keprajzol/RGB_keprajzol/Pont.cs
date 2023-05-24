using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB_keprajzol
{
    internal class Pont
    {
        private byte r;
        private byte g;
        private byte b;

        public Pont(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public byte R { get => r; }
        public byte G { get => g; }
        public byte B { get => b; }
    }
}
