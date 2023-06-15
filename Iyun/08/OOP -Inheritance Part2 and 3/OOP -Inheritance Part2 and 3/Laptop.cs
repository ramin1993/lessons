using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__Inheritance_Part2_and_3
{
   sealed class Laptop:Base
    {
        public string CPU { set; get; }
        public string Ram { set; get; }
        public string GraphicCard { set; get; }
    }
}
