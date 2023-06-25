using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class Address
    {
        



        public Address(int Id, int No, string Building, string Street, string City, string Country)
        {
            
            this.Id = Id;
            this.No = No;
            this.Building = Building;
            this.Street = Street;
            this.City = City;
            this.Country = Country;
        }

        public int Id { set; get; }
        public int No { set; get; }
        public string Building { set; get; }
        public string Street { set; get; }
        public string City { set; get; }
        public string Country { set; get; }
        

    }
}
