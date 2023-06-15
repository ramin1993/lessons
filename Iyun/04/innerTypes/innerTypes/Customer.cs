using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace innerTypes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateDate { get; set; }
        private DateTime? EditDate;
        
        public DateTime? CheckEditDate
        {
            get{

                return EditDate;
            }
            set
            {
                EditDate = value;
                if (EditDate is null)
                {
                    Console.WriteLine("Data is not edited");
                }
                else
                {
                    Console.WriteLine("12.12.2022");
                }
            }
        }

        

        public void ShowOrders()
        {
            Customer customer = new Customer();
            customer.Orders[0] = new Orders()
            {
                Id = 1,
                OrderDetails = "Samsung S22",
                ShippingAddress = customer.Addresses[1],
                CreateDate = DateTime.Now,
                EditDate = CheckEditDate

            };
        }
        public void ShowAddresses()
        {
            Customer customer = new Customer();
            customer.Addresses[0] = new Addresses()
            {
                Id = 2,
                No = 40,
                Building = "Apartment",
                Street = "Cobanzade",
                Distinct = "Nefciler",
                CreateDate = DateTime.Now,
                EditDate = CheckEditDate
            };
        }
        public void ShowContacts()
        {
            Customer customer = new Customer();
            customer.Contacts[0] = new Contacts()
            {
                Id = 1,
                Email = "ramin@mail.com",
                PhoneNumber = "+9945550000",
                CreateDate = DateTime.Now,
                EditDate = CheckEditDate
            };
            customer.Contacts[1] = new Contacts()
            {
                Id = 2,
                Email = "ramin93@mail.com",
                PhoneNumber = "+994555562332",
                CreateDate = DateTime.Now,
                EditDate = new DateTime(2022, 12 , 12)
            };
                
            
        }
        public void ShowCustomer()
        {

            Console.WriteLine(this.Name);
            
        }

        public void ShowAllInfo()
        {
            ShowOrders();
            ShowAddresses();
            ShowContacts();
            ShowCustomer();
        }

        public Contacts[] Contacts;
        public Orders[] Orders;
        public Addresses[] Addresses;

        public Customer()
        {
            Contacts = new Contacts[100];
            Orders = new Orders[100];
            Addresses = new Addresses[100];
        }
    }
}
