using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtomobili
{
    public class car
    {
        public string model {  get; set; }  

        public int potrosuvacak {  get; set; }  

        public int cena {  get; set; }  

        public Marka marka { get; set; }

        public car(string model, int potrosuvacak, int cena, Marka marka)
        {
            this.model = model;
            this.potrosuvacak = potrosuvacak;
            this.cena = cena;
            this.marka = marka;
        }

        public override string ToString()
        {
            return $"{marka} {model} {potrosuvacak} {cena}";
        }
    }
}
