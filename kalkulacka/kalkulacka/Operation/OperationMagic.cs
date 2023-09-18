using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulacka.Operation
{
    internal class OperationMagic : IOperation
    {
        public int execute(int a, int b)
        {
            return (a+b)* b;
        }
    }
}
