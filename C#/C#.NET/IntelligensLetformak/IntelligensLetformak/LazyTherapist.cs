using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IntelligensLetformakFeladat;

namespace IntelligensLetformak
{
    internal class LazyTherapist : IntelligensLetforma
    {
        private List<string> kerdes = new List<string> { "Biztos ön ebben?", "Miért gondolja ezt?", "El tudja képzelni ennek az ellenkezőjét is?", "Nem tudom. Talán így van. Ön mit gondol erről?" };
        private List<string> felkialto = new List<string> { "Most dühös lett?", "Mit érez miközben ezt mondja?", "Feszült lett attól, amiről beszélünk?" };
        private List<string> egyeb = new List<string> { "Kérem, folytassa", "Biztos ebben?", "Csakugyan?", "Hmm.Ez érdekes.Kérem fejtse ki bővebben!" };
        public void Kommunikacio(string szoveg)
        {
            Random index = new Random();

            switch (szoveg.Last())
            {
                case '?':
                    Console.WriteLine(kerdes[index.Next(0, kerdes.Count - 1)]);
                    break;
                case '!':
                    Console.WriteLine(felkialto[index.Next(0, felkialto.Count - 1)]);
                    break;
                default:
                    Console.WriteLine(egyeb[index.Next(0, egyeb.Count - 1)]);
                    break;
            }
        }
    }
}
