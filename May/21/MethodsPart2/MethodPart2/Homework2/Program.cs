using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ref ve out keywordunu arasdirin.
            int val=10;
            RefKeyword(ref val);

            int val1;
            OutKeyword(out val1);
        }
        
        

        static void RefKeyword(ref int num1)
        {
            num1 = 20;
        }
        static void OutKeyword(out int num1)
        {
            num1 = 9;
        }
    }
}
