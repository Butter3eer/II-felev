namespace Interfacek
{
    interface INyomtato
    {
        void Nyomtat();
        void Tisztit();
    }
    interface ISzkenner
    {
        void Szkennel();
        void Tisztit();
    }

    public class UjNyomtato : INyomtato, ISzkenner
    {
        public void Nyomtat()
        {
            Console.WriteLine("Új nyomtató nyomtat");
        }

        public void Szkennel()
        {
            Console.WriteLine("Új nyomtató szkennel");
        }

        void INyomtato.Tisztit()
        {
            throw new NotImplementedException();
        }

        void ISzkenner.Tisztit()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            UjNyomtato nyomtato = new UjNyomtato();
            nyomtato.Nyomtat();
            nyomtato.Szkennel();
            INyomtato nyomtatoA = new UjNyomtato();
            nyomtatoA.Nyomtat();
        }
    }
}