namespace OscarDíj
{
    class Kapocs
    {
        private int fid;
        private int kid;

        public Kapocs(int fid, int kid)
        {
            this.fid = fid;
            this.kid = kid;
        }

        public int Fid { get => fid; set => fid = value; }
        public int Kid { get => kid; set => kid = value; }
    }
}
