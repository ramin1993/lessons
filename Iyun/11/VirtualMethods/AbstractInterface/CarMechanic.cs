using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    public class CarMechanic:PersonsInfo
    {
        public override string Name { get; set; }
        public override string Surname { get; set; }
        public override void Specialist()
        {
            Console.WriteLine("Avtomobil ustasi");
        }
        public override void Age(int a)
        {
            Console.WriteLine(a);
        }
    }
}
