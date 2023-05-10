namespace DolgozatProject
{
    public class Dolgozat
    {
        public List<int> pontok;

        public Dolgozat()
        {
            pontok = new List<int>();
        }

        public void PontFelvesz(int x)
        {
            if (x < -1 || x > 100)
            {
                throw new ArgumentException("Érvénytelen pontszám");
            }
            else
            {
                pontok.Add(x);
            }
        }

        public bool MindenkiMegirta()
        {
            if (pontok.Contains(-1))
            {
                return false;
            }
            return true;
        }

        public bool Gyanus(int kivalok)
        {
            if (kivalok <= 0)
            {
                throw new ArgumentException("Érvénytelen kiválók száma.");
            }
            else
            {
                if (Jeles > kivalok)
                {
                    return true;
                }
                return false;
            }
        }
        public int Bukas { get { return pontok.Count(x => x < 50 && x > -1); } }
        public int Elegseges { get { return pontok.Count(x => x <= 60 && x >= 50); } }
        public int Kozepes { get { return pontok.Count(x => x <= 70 && x >= 61); } }
        public int Jo { get { return pontok.Count(x => x <= 80 && x >= 71); } }
        public int Jeles { get { return pontok.Count(x => x >= 81); } }
        public bool Ervenytelen
        {
            get
            {
                if (pontok.Count * 0.5 < pontok.Count(x => x == -1))
                {
                    return true;
                }
                return false;
            }
        }
    }
}