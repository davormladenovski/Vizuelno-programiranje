using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class krug
    {
        public int minuti;
        public int sekundi;

        public krug(int minuti, int sekundi)
        {
            this.minuti = minuti;
            this.sekundi = sekundi;
        }

        public override string ToString()
        {
            return $"{minuti}:{sekundi}";
        }

    }
}
