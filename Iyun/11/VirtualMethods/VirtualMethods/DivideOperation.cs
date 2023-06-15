using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class DivideOperation:Calculator
    {
        public override void DoCalculation(double a,double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Eded sifira bolunbe bilmez!");
            }
            else
            {
                Console.WriteLine("Cavab:" + a / b);
            }
        }
    }
}
