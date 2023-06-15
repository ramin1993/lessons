using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInAbstractClasses
{
    public abstract class Fruit
    {
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        public abstract void InThisCountry();
    }
}
