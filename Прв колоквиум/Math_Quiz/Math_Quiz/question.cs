using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Quiz
{
    public class question
    {

        public int operand1;
        public int operand2;
        public string operation;
        public string tocnost;
        public int points=0;

        public question(int operand1, int operand2, string operation)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.operation = operation;
        }

        public override string ToString()
        {
            return $"{operand1} {operation} {operand2} {tocnost} {points} poeni";
                
        }

    }
}
