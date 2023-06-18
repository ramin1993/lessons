using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInAbstractClasses
{
   public class Avakado:Fruit
    {
        public override string Name
        {
            get
            {
                return this.Name;
            }
            set
            {
                if (value.Length > 8)
                {
                    Name = "Avokado";
                }
                else
                {
                    Name = value;
                }
            }
        }
        public string Color { get; set; }
        public override void InThisCountry()
        {
            Console.WriteLine("Avakado Meksikada daha cox yetisir.");
        }
    }
}
