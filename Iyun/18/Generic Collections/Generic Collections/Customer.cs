using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
   public class Customer<T>
    {


        public Customer(int Id, T Name, T Surname, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.Age = Age;
        }

        //Id, Name, Surname, Age,Address
        public int Id { get; set; }
        public T Name { get; set; }
        public T Surname { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

    }
}
