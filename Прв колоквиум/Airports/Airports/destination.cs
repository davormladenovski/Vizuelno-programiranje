using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airports
{
    public class destination
    {

        public string ime;
        public int dolzina;
        public int cena;

        public destination(string ime, int dolzina, int cena)
        {
            this.ime = ime;
            this.dolzina = dolzina;
            this.cena = cena;
        }

        public override string ToString()
        {
            return $"{ime}      {dolzina}km - {cena} EUR";
        }

    }
}
