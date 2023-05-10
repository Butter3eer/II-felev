using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labda
{
    public class Ko : IRughato
    {
        public void Rug()
        {
            Console.WriteLine("Kő elrúgva");
        }

        public override string ToString()
        {
            return "Kő";
        }
    }
}
