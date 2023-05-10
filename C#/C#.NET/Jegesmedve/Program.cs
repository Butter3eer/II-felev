namespace Jegesmedve
{
    public class Program
    {
        static List<Uzenet> uzenetek = new List<Uzenet>();
        static void Main(string[] args)
        {
            Beolvasas();
            Helyreallitas();
            JegesmedvekSzama();
        }
        static void Beolvasas()
        {
            //fájl beolvasása
            string fajlnev = "veetel.txt";
            StreamReader streamReader = new StreamReader(fajlnev);
            string sor;
            string[] darabolt;
            int nap;
            int rogzito;
            sor = streamReader.ReadLine();

            while (!streamReader.EndOfStream)
            {
                // Üzenetek létrehozása
                darabolt = sor.Split(" ");
                nap = int.Parse(darabolt[0]);
                rogzito = int.Parse(darabolt[1]);
                sor = streamReader.ReadLine();
                Uzenet uzenet = new Uzenet(nap, rogzito, sor);
                uzenetek.Add(uzenet);
                sor = streamReader.ReadLine();

            }
            streamReader.Close();
        }
        static void Helyreallitas()
        {
            
        }
        static void JegesmedvekSzama()
        {
            
        }
    }
}