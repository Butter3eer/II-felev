using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labda
{
    internal class Teniszlabda : Labda
    {
        public Teniszlabda(string markanev) : base(markanev)
        {
        }

        public override string ToString()
        {
            return $"A teniszlabda márkája: {Markanev}, " + base.ToString();
        }
    }
}
