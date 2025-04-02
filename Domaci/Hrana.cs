using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domaci
{
    public class Hrana
    {
        private string id;
        private string naziv;
        private string cena;
        private string sastojci;

        public Hrana(string id,string naziv, string cena, string sastojci)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
            this.sastojci = sastojci;
        }

        public string Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Cena { get => cena; set => cena = value; }
        public string Sastojci { get => sastojci; set => sastojci = value; }



    }
}