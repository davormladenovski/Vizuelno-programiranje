using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Airports
{
    public class airport
    {
        public string grad;
        public string ime;
        public string kratenka;
        public List<destination> destinations=new List<destination>();

        public airport(string grad, string ime, string kratenka)
        {
            this.grad = grad;
            this.ime = ime;
            this.kratenka = kratenka;
        }

        public override string ToString()
        {
            return $"{kratenka} - {ime} - {grad}";
        }

    }
}
