using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labda
{
    internal class Focilabda : Labda
    {
        public Focilabda(string markanev) : base(markanev)
        {
        }

        public override string ToString()
        {
            return $"A focilabda márkája: {Markanev}, " + base.ToString();
        }
    }
}
