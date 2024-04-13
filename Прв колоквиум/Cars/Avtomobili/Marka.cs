using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtomobili
{
    public class Marka
    {
        public string name {  get; set; }

        public string sifra {  get; set; }

        public Marka(string name, string sifra)
        {
            this.name = name;
            this.sifra = sifra;
        }

        public override string ToString()
        {
            return $"{name} ({sifra})";
        }

    }
}
