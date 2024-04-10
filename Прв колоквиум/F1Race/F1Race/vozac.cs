using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class vozac
    {
        public string ime;
        public int godini;
        public bool first;
        public List<krug> krugovi = new List<krug>();

        public vozac(string ime, int godini, bool first)
        {
            this.ime = ime;
            this.godini = godini;
            this.first = first;
        }

        public override string ToString()
        {
            if (first)
            {
                return $"{ime}({godini}) - F ";
            }
            else
            {
                return $"{ime}({godini}) - S ";
            }
            
        }
    }
}
