using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repulo_oroklodes
{
    internal class Repülő : RepJegy
    {
        private int maxSuly;
        List<Utas> utasok;

        public Repülő(string celVaros, DateTime indulIdo, int maxSuly) : base(celVaros, indulIdo)
        {
            this.maxSuly = maxSuly;
            this.utasok = new List<Utas>();
        }
        public int MaxSuly { get => maxSuly; set => maxSuly = value; }

        public void utasFelszáll(Utas utas)
        {
            bool felszallhat = true;
            if (DateTime.Now < utas.BoardingTime())
            {
                felszallhat = false;
            }
            else if (utas.jegy.CelVaros != CelVaros)
            {
                felszallhat = false;
            }
            else if (utas.Suly > maxSuly)
            {
                felszallhat = false;
            }
            else if (utas is ElsőbbségiUtas && (utas as ElsőbbségiUtas).PluszSuly > maxSuly)
            {
                felszallhat = false;
            }

            if (felszallhat)
            {
                utasok.Add(utas);
            }
        }

        public void maxBorond()
        {
            int osszes = 0;
            foreach (Utas utas in utasok)
            {
                osszes += utas.Suly;
                if (utas is ElsőbbségiUtas)
                {
                    osszes += (utas as ElsőbbségiUtas).PluszSuly;
                }
            }
        }

        public void dict()
        {
            Dictionary<string, int> utasDarab = new Dictionary<string, int>
            {
                {"utas", 0},
                {"elsobbsegiUtas", 0}
            };

            foreach (Utas utas in utasok)
            {
                if (utas is ElsőbbségiUtas)
                {
                    utasDarab["elsobbsegiUtas"] += 1;
                }
                else
                {
                    utasDarab["utas"] += 1;
                }
            }
        }
    }
}
