using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInAbstractClasses
{
    public class Apple:Fruit
    {
        public override string Name {
            get
            {
                return this.Name;
            }
            set
            {
                if(value.Length > 5)
                {
                    Name = "Apple";
                }
            }
        }
        public string Color { get; set; }
        public override void InThisCountry() {
            Console.WriteLine("Alma daha cox Respublikamizin Simal Bolgesinde yetisir");
        }
    }
}
