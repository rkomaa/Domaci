using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Domaci
{
    public class Pice
    {
        string id;
        string naziv;
        string cena;
        string proizvodjac;

        public Pice(string id,string naziv, string cena, string proizvodjac)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
            this.proizvodjac = proizvodjac;
        }
        public string Id { get => id; set => id = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Cena { get => cena; set => cena = value; }
        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }
    }
}