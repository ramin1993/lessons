using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Document
    {
        private string DocumentSerial;
        private string DocumentNumber;

        

        private string DocSerial
        {
            set {
                int stringLength = 2;
                if (DocumentSerial.Length == stringLength)
                {
                    this.DocumentSerial = value;
                }
                else if (DocumentSerial is string)
                {
                    Console.WriteLine("Vesiqenin seriyasi sadece herflerden ibaret olmalidir!");
                }
                else if (DocumentSerial.Length ==8)
                {
                    Console.WriteLine("Vesiqenin seriya nomresi 8herfden ibaret olmalidir.");
                }
                else
                {
                    Console.WriteLine("Vesiqenin seriyasi 2 herf olmalidir.");
                }
                
             }
            get
            {
                return this.DocumentSerial;
            }
        }

        private string DocNumber
        {
            set
            {
                this.DocumentNumber = value;
            }
            get
            {
                return this.DocumentNumber;
            }
        }



    }
}
