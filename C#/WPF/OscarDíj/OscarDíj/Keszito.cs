namespace OscarDíj
{
    class Keszito
    {
        private int id;
        private string nev;

        public Keszito(int id, string nev)
        {
            this.id = id;
            this.nev = nev;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
    }
}
