using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_2
{
    public sealed class Customer:BaseClass,IGenericRepostroy<Customer>
    {
        public string Country { get; set; }
        public string Interests { get; set; }

        public void Add(Customer data)
        {
            data.Interests = "Books";
        }
        public void UpDate(Customer data)
        {
            data.Surname = "Memmedov";
        }
        public void Delete(Customer data)
        {
            data.Age = 0;
        }
        public void Get(Customer data)
        {
            Console.WriteLine("Id: " + data.Id + "\n" + "Ad: " + data.Name + "\n" +
                  "Soyad: " + data.Surname + "\n" + "Yas : " + data.Age + "\n" +
                 "Maas: " + data.Country + "\n" + "Maraqlar: " + data.Interests);

            Console.WriteLine("-----------------------");
        }

    }
}
