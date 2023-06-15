using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraSeniorHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new char[] { 'r', 'e', 'd', ' ', 'b', 'l', 'u', 'e', ' ', 'y', 'o', 'u', ' ', 'm', 'e', ' ', 'c', 'a', 'l', 'l' };
            var test1 = new char[] { 'c', 'a', 'l', 'l', ' ', 'm', 'e', ' ', 'y', 'o', 'u', ' ', 'b', 'l', 'u', 'e', ' ', 'r', 'e', 'd' };
            string words = "";
            string words1 = "";

            for (int i = 0;i < test.Length;i++)
            {
                words += test[i];
            }
            Console.Write(words);

            for (int i = 0; i < test1.Length; i++)
            {
                words1 += test1[i];
            }
            Console.Write(words1);

        }
    }
}
