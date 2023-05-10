using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyek
{
    internal class Diakberlet : Berlet
    {
        string diakigazolvanyszam;

        public Diakberlet(DateTime datum, int napokSzama, string diakigazolvanyszam) : base(datum, napokSzama)
        {
            this.diakigazolvanyszam = diakigazolvanyszam;
            ar = base.ar / 2;
        }

        public string Diakigazolvanyszam { get => diakigazolvanyszam; set => diakigazolvanyszam = value; }
    }
}
