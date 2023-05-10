using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntelligensLetformakFeladat;

namespace IntelligensLetformak
{
    internal class DullTherapist : IntelligensLetforma
    {
        private List<string> valaszok = new List<string>() { "Kérem, folytassa", "Biztos ebben?", "Csakugyan?", "Nem tudom. Talán így van. Ön mit gondol erről?" };

        public void Kommunikacio(string szoveg)
        {
            Random index = new Random();
            Console.WriteLine(valaszok[index.Next(0, valaszok.Count)]);
        }
    }
}
