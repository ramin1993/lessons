using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
   public class PlusOperation:Calculator
    {
        public override void DoCalculation(double a, double b)
        {
            Console.WriteLine("Cavab:" + (a + b));
        }
    }
}
