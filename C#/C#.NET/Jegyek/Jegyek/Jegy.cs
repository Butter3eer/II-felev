using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyek
{
    public abstract class Jegy
    {
        protected int ar;
        static int napiar = 350;


        public abstract bool Ervenyesit();
        public override string ToString()
        {
            return $"{ar} {napiar}";
        }
        public static int Napiar { get => napiar; set => napiar = value; }

    }
}
