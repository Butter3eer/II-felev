using System.Text.RegularExpressions;

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
            public ulong Egyenleg { get; set; }
        }
        private List<Szamla> szamlak = new List<Szamla>();
        /// <summary>
        /// Új számlát nyit a megadott névvel, számlaszámmal
        /// </summary>
        /// <param name="nev">A számla tulajdonosának neve</param>
        /// <param name="szamlaszam">A számla számlaszáma</param>
        public void UjSzamla(string nev, string szamlaszam)
        {
            if (nev == null)
            {
                throw new ArgumentNullException("A név nem lehet üres"
                    , nameof(nev));
            }
            if (String.IsNullOrEmpty(nev.Trim()))
            {
                throw new ArgumentException("A név nem lehet üres"
                    , nameof(nev));
            }
            if (Regex.IsMatch(nev, @"[^\w\s]"))
            {
                throw new ArgumentException("A név nem tartalmazhat speciális karaktert"
                    , nameof(nev));
            }

            try
            {
                SzamlaKeres(szamlaszam);
                throw new ArgumentException("A megadott számlaszámmal" +
                    " már létezik számla", nameof(szamlaszam));
            }
            catch (HibasSzamlaszamException)
            {
                szamlak.Add(new Szamla(nev, szamlaszam));
            }
        }

        // Lekérdezi az adott számlán lévő pénzösszeget
        public ulong Egyenleg(string szamlaszam)
        {
            Szamla szamla = SzamlaKeres(szamlaszam);
            return szamla.Egyenleg;
        }

        // Egy létező számlára pénzt helyez
        public void EgyenlegFeltolt(string szamlaszam, ulong osszeg)
        {
            if (osszeg == 0)
            {
                throw new ArgumentException("Az összeg nem lehet 0",
                    nameof(osszeg));
            }
            Szamla szamla = SzamlaKeres(szamlaszam);
            szamla.Egyenleg += osszeg;
        }


        // Két számla között utal.
        // Ha nincs elég pénz a forrás számlán, akkor false értékkel tér vissza
        public bool Utal(string honnan, string hova, ulong osszeg)
        {
            throw new NotImplementedException();
        }

        private Szamla SzamlaKeres(string szamlaszam)
        {
            if (szamlaszam == null)
            {
                throw new ArgumentNullException("A számlaszám nem lehet üres"
                    , nameof(szamlaszam));
            }
            if (String.IsNullOrEmpty(szamlaszam.Trim()))
            {
                throw new ArgumentException("A számlaszám nem lehet üres"
                    , nameof(szamlaszam));
            }
            if (Regex.IsMatch(szamlaszam, @"[^\d\s-]"))
            {
                throw new ArgumentException("A számlaszám csak számot tartalmazhat"
                    , nameof(szamlaszam));
            }

            int ind = 0;
            while (ind < szamlak.Count && szamlak[ind].Szamlaszam != szamlaszam)
            {
                ind++;
            }
            if (ind == szamlak.Count)
            {
                throw new HibasSzamlaszamException(szamlaszam);
            }
            return szamlak[ind];
        }
    }
}