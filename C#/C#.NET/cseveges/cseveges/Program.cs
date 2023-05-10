using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cseveges
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        private DateTime Atalakit(string s) 
        { 
            string[] datum = s.Split('-'); 
            string[] evhn = datum[0].Split('.'); 
            string[] opm = datum[1].Split(':'); 
            int ev = int.Parse(evhn[0] + 2000); 
            return new DateTime(ev, int.Parse(evhn[1]), int.Parse(evhn[2]), int.Parse(opm[0]), int.Parse(opm[1]), int.Parse(opm[2])); 
        }
    }
}
