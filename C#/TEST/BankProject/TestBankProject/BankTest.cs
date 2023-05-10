using System.IO.Compression;
using System.Text.RegularExpressions;
using BankProject;

namespace TestBankProject
{
    public class BankTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void UjSzamla_LetezoSzamlaszammal()
        {
            Bank b = new Bank();
            b.UjSzamla("Gipsz Jakab", "1234");
            Assert.Throws<ArgumentException>(() =>
            {
                b.UjSzamla("Teszt Elek", "1234");
            });
        }

        [Test]
        public void UjSzamla_LetezoNevvel()
        {
            Bank b = new Bank();
            b.UjSzamla("Gipsz Jakab", "1234");
            Assert.DoesNotThrow(() =>
            {
                b.UjSzamla("Gipsz Jakab", "5678");
            });
        }

        [Test]
        public void UjSzamla_SzamlaszamBetuk()
        {
            Bank b = new Bank();
            string nev = "Jakab";
            string szam = "123A";
            b.UjSzamla(nev, szam);
            string pattern = "[a-zA-Z0-9 ]";
            Assert.That(Regex.IsMatch(szam, pattern) == true, "A bankszámlája betűket vagy speciális karaktereket tartalmaz.");
        }

        [Test]
        public void UjSzamla_NevSpecialis()
        {
            Bank b = new Bank();
            string nev = "Jakab!%";
            string szam = "1234";
            b.UjSzamla(nev, szam);
            string pattern = "[a-zA-Z0-9 ]";
            Assert.That(Regex.IsMatch(nev, pattern) == true, "A neve nem tartalmazhat speciális karaktereket.");
        }

        [Test]
        public void UjSzamla_UresAdat()
        {
            Bank b = new Bank();
            b.UjSzamla("Gipsz Jakab", "1234");
            Assert.Throws<ArgumentNullException>(() =>
            {
                b.UjSzamla("", "");
                b.UjSzamla("Gipsz Jakab", "");
                b.UjSzamla("", "1234");
            });
        }
        /*
         * Nem megfelelõ adatok
	     *  - számlaszámnál betûk
	     *  - Névben speciális karakterek
	     *  - Üres valamelyik adat / null
         */
    }
}