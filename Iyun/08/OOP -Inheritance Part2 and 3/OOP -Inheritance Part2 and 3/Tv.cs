using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__Inheritance_Part2_and_3
{
   sealed class Tv:Base
   {
        public bool IsSmartTv { set; get; }
        public bool HasHDMI { set; get; }
        public double Resolution { set; get; }

   }
}
