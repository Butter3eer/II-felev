namespace Labda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRughato rughatoLabda = new Focilabda("márkanév");
            IPattinthato pattinthatoLabda = new Focilabda("márkanév");
            IRughato rughatoKo = new Ko();
            Labda labda = new Focilabda("márkanév");
            Focilabda focilabda = new Focilabda("márkanév");

            rughatoLabda.Rug();
            //rughatoLabda.Pattint(); Az IRughato Interface által létrehozott adat, és ez az inteface nem rendelkezik ezzel a metódussal
            Console.WriteLine(rughatoLabda.ToString());
            Console.WriteLine("---------------------");

            //pattinthatoLabda.Rug(); Az IPattinthato Interface által létrehozott adat, és ez az interface nem rendelkezik ezzel a metódussal
            pattinthatoLabda.Pattint();
            Console.WriteLine(pattinthatoLabda.ToString());
            Console.WriteLine("---------------------");

            rughatoKo.Rug();
            //rughatoKo.Pattint(); Az IRughato Interface által létrehozott adat, és ez az inteface nem rendelkezik ezzel a metódussal
            Console.WriteLine(rughatoKo.ToString());
            Console.WriteLine("---------------------");

            labda.Rug();
            labda.Pattint();
            Console.WriteLine(labda.ToString());
            Console.WriteLine("---------------------");

            focilabda.Rug();
            focilabda.Pattint();
            Console.WriteLine(focilabda.ToString());
        }
    }
}