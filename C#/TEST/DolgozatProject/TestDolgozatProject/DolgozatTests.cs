using DolgozatProject;
using NUnit.Framework.Internal;

namespace TestDolgozatProject
{
    public class DolgozatTests
    {
        Dolgozat dolgozat;
        List<int> Pontok; 
        [SetUp]
        public void Setup()
        {
            dolgozat = new Dolgozat();
            dolgozat.pontok = new List<int>();
            Pontok = dolgozat.pontok;
            dolgozat.PontFelvesz(12);
        }

        [Test]
        public void PontFelvesz_kisebb()
        {
            Assert.Throws<ArgumentException>(() => {
                dolgozat.PontFelvesz(-2);
            });
        }

        [Test]
        public void PontFelvesz_Nagyobb()
        {
            Assert.Throws<ArgumentException>(() => {
                dolgozat.PontFelvesz(122);
            });
        }

        [Test]
        public void PontFelvesz_also()
        {
            Assert.DoesNotThrow(() => {
                dolgozat.PontFelvesz(-1);
            });
        }

        [Test]
        public void PontFelvesz_felso()
        {
            Assert.DoesNotThrow(() => {
                dolgozat.PontFelvesz(100);
            });
        }

        [Test]
        public void Gyanus_bevitelNegativ()
        {
            dolgozat.Gyanus(2);
            Assert.Throws<ArgumentException>(() =>
            {
                dolgozat.Gyanus(-2);
            });
        }

        [Test]
        public void PontFelvesz_tenylegFelveszE()
        {
            Assert.AreEqual(1, Pontok.Count);
        }

        [Test]
        public void PontFelvesz_tenylegFelveszPozitiv()
        {
            Assert.DoesNotThrow(() =>
            {
                dolgozat.PontFelvesz(25);
            });
        }

        [Test]
        public void PontFelvesz_tenylegAztVesziFel()
        {
            Assert.AreEqual(Pontok[0], 12);
        }

        [Test]
        public void Bukas_TenylegJotAdVisszaAlacsonyHatar()
        {
            Assert.AreEqual(1, dolgozat.Bukas);
            dolgozat.PontFelvesz(-1);
            Assert.AreEqual(1, dolgozat.Bukas);
        }

        [Test]
        public void Bukas_TenylegJotAdVisszaAlacsonyHatarAlatt()
        {
            Assert.AreEqual(1, dolgozat.Bukas);
            dolgozat.PontFelvesz(50);
            Assert.AreEqual(1, dolgozat.Bukas);
        }

        [Test]
        public void Bukas_TenylegJotAdVisszaMagasHatar()
        {
            Assert.AreEqual(1, dolgozat.Bukas);
            dolgozat.PontFelvesz(49);
            Assert.AreEqual(2, dolgozat.Bukas);
        }

        [Test]
        public void Bukas_TenylegJotAdVisszaMagasHatarFelett()
        {
            Assert.AreEqual(1, dolgozat.Bukas);
            dolgozat.PontFelvesz(50);
            Assert.AreEqual(1, dolgozat.Bukas);
        }

        [Test]
        public void Bukas_TenylegJolSzamol()
        {
            Assert.AreEqual(1, dolgozat.Bukas);
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(12);
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(50);
            Assert.AreEqual(3, dolgozat.Bukas);
        }

        [Test]
        public void Elegseges_TenylegJotAdVisszaAlacsonyHatar()
        {
            dolgozat.PontFelvesz(50);
            Assert.AreEqual(1, dolgozat.Elegseges);
        }

        [Test]
        public void Elegseges_TenylegJotAdVisszaMagasHatar()
        {
            dolgozat.PontFelvesz(60);
            Assert.AreEqual(1, dolgozat.Elegseges);
        }

        [Test]
        public void Kozepes_TenylegJotAdVisszaAlacsonyHatar()
        {
            dolgozat.PontFelvesz(61);
            Assert.AreEqual(1, dolgozat.Kozepes);
        }

        [Test]
        public void Kozepes_TenylegJotAdVisszaMagasHatar()
        {
            dolgozat.PontFelvesz(70);
            Assert.AreEqual(1, dolgozat.Kozepes);
        }

        [Test]
        public void Jo_TenylegJotAdVisszaAlacsonyHatar()
        {
            dolgozat.PontFelvesz(71);
            Assert.AreEqual(1, dolgozat.Jo);
        }

        [Test]
        public void Jo_TenylegJotAdVisszaMagasHatar()
        {
            dolgozat.PontFelvesz(80);
            Assert.AreEqual(1, dolgozat.Jo);
        }

        [Test]
        public void Jeles_TenylegJotAdVissza()
        {
            dolgozat.PontFelvesz(81);
            Assert.AreEqual(1, dolgozat.Jeles);
        }

        [Test]
        public void Ervenytelen_TenylegJotAdVisszaTrue()
        {
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            Assert.AreEqual(true, dolgozat.Ervenytelen);
        }

        [Test]
        public void Ervenytelen_TenylegJotAdVisszaFalse()
        {
            dolgozat.PontFelvesz(-1);
            Assert.AreEqual(false, dolgozat.Ervenytelen);
        }

        [Test]
        public void Gyanus_TenylegJotAdVisszaTrue()
        {
            dolgozat.PontFelvesz(90);
            dolgozat.PontFelvesz(85);
            Assert.AreEqual(true, dolgozat.Gyanus(1));
        }

        [Test]
        public void Gyanus_TenylegJotAdVisszaFalse()
        {
            dolgozat.PontFelvesz(90);
            Assert.AreEqual(false, dolgozat.Gyanus(1));
        }

        [Test]
        public void MindenkiMegirta_TenylegJotAdVisszaTrue()
        {
            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(15);
            dolgozat.PontFelvesz(80);
            Assert.IsTrue(dolgozat.MindenkiMegirta());
        }

        [Test]
        public void MindenkiMegirta_TenylegJotAdVisszaFalse()
        {
            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(80);
            Assert.IsFalse(dolgozat.MindenkiMegirta());
        }
    }
}