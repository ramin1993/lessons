using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class MinusOperation:Calculator
    {
        public override void DoCalculation(double a, double b)
        {
            Console.WriteLine("Cavab:" +( a - b));
        }

    }
}
