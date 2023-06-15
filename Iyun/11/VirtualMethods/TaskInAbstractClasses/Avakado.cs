using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInAbstractClasses
{
   public class Avakado:Fruit
    {
        public override string Name { get; set; }
        public override string Color { get; set; }
        public override void InThisCountry()
        {
            Console.WriteLine("Avakado Meksikada daha cox yetisir.");
        }
    }
}
