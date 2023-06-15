using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
     public abstract class PersonsInfo
    {
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }

        public abstract void Specialist();
        public abstract void Age(int a);
       
    }
}
