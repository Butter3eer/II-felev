namespace BankProject
{
    public class Bank
    {
        private class Szamla
        {
            public Szamla(string nev, string szamlaszam)
            {
                Nev = nev;
                Szamlaszam = szamlaszam;
            }

            public string Nev { get; set; }
            public string Szamlaszam { get; set; }
        }
        private List<Szamla> szamlak = new List<Szamla>();
        /// <summary>
        /// Új számlát nyit a megadott névvel, számlaszámmal
        /// </summary>
        /// <param name="nev">A számla tulajdonosának neve</param>
        /// <param name="szamlaszam">A számla számlaszáma</param>
        public void UjSzamla(string nev, string szamlaszam)
        {
            foreach (var szamla in szamlak)
            {
                if (szamla.Szamlaszam == szamlaszam)
                {
                    throw new ArgumentException("A megadott számlaszámmal" +
                        " már létezik számla", nameof(szamlaszam));
                }
            }
            szamlak.Add(new Szamla(nev, szamlaszam));
        }

        // Lekérdezi az adott számlán lévő pénzösszeget
        public ulong Egyenleg(string szamlaszam)
        {
            throw new NotImplementedException();
        }

        // Egy létező számlára pénzt helyez
        public void EgyenlegFeltolt(string szamlaszam, ulong osszeg)
        {
            throw new NotImplementedException();
        }


        // Két számla között utal.
        // Ha nincs elég pénz a forrás számlán, akkor false értékkel tér vissza
        public bool Utal(string honnan, string hova, ulong osszeg)
        {
            throw new NotImplementedException();
        }
    }
}