using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zenei_adok
{
    class Adas2
    {
        private int radio;
        private int perc;
        private int mp;
        private string eloado;
        private string cim;

        public string Eloado
        {
            get => eloado;
            set {
                if (value != "")
                {
                    eloado = value;
                }
                else
                {
                    Console.WriteLine("Nem lehet üres!!");
                }
            }
        }
        //public int Radio { get => radio; set => radio = value; }

        public int Hossz
        {
            get
            {
                return perc * 60 + mp;
            }
        }

        public int Hossz2()
        {
            return perc * 60 + mp;
        }

        public int Radio
        {
            get { return radio; }
        }

        public Adas2(int radio, int perc, int mp, string eloado, string cim)
        {
            this.radio = radio;
            this.perc = perc;
            this.mp = mp;
            this.eloado = eloado;
            this.cim = cim;
        }


        public override string ToString()
        {
            return this.eloado + " - " + cim + "(" + perc + ":" + mp + ")";
        }
    }
    class Adas
    {
        public int radio;
        public int perc;
        public int mp;
        public string eloado;
        public string cim;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Beolvas2();
            adasok2[0].Eloado = "Omega";
            Console.WriteLine(adasok2[0]);
        }

        static List<Adas> adasok = new List<Adas>();
        static List<Adas2> adasok2 = new List<Adas2>();

        static void Beolvas()
        {
            StreamReader file = new StreamReader("musor.txt");
            file.ReadLine();
            while (!file.EndOfStream)
            {
                string sor = file.ReadLine();
                string[] reszek = sor.Split(' ');
                Adas adas = new Adas();
                adas.radio = Convert.ToInt32(reszek[0]);
                adas.perc = Convert.ToInt32(reszek[1]);
                adas.mp = Convert.ToInt32(reszek[2]);

                string minden = "";
                for (int i = 3; i < reszek.Length; i++)
                {
                    minden += reszek[i] + " ";
                }

                adas.eloado = minden.Split(':')[0];
                adas.cim = minden.Split(':')[1];
                adasok.Add(adas);
            }

            file.Close();
        }

        static void Beolvas2()
        {
            StreamReader file = new StreamReader("musor.txt");
            file.ReadLine();
            while (!file.EndOfStream)
            {
                string sor = file.ReadLine();
                string[] reszek = sor.Split(' ');
                
                int radio = Convert.ToInt32(reszek[0]);
                int perc = Convert.ToInt32(reszek[1]);
                int mp = Convert.ToInt32(reszek[2]);

                string minden = "";
                for (int i = 3; i < reszek.Length; i++)
                {
                    minden += reszek[i] + " ";
                }

                string eloado = minden.Split(':')[0];
                string cim = minden.Split(':')[1];

                adasok2.Add(new Adas2(radio, perc, mp, eloado, cim));
            }

            file.Close();
        }
    }
}
