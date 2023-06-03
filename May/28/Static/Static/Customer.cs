using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
   public class Customer
    {

        private static ArrayList arrList;

        static Customer()
        {
            arrList = new ArrayList();
            
        }

        public static Array NewCustomer(Customer c)
        {
            arrList.Add(c);
            return arrList.ToArray();
        }

        private string Username;
        private string Password;
        public int id;
        private string name;
        private string surname;
        public string email;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public string Surname
        {
            set
            {
                surname = value;
            }
            get
            {
                return surname;
            }
        }

        public string Email
        {
            set
            {
                checkEmail(value);
                email = value;
            }
            get
            {
                return email;
            }
        }

        public bool checkEmail(string email)           
        {
            foreach (var item in arrList)
            {
                if (!arrList.Contains(email))
                {
                    Console.WriteLine("Elave etmek istediyiniz "+  email + " artiq sistemde movcuddur!");
                    return true;
                }                                                 
            }
            Console.WriteLine("Yeni musteri sisteme elave olundu!");
            return false;
        }

        public string UserName
        {
            set
            {

                CheckUsername(value);
                Username = value;

            }
            get
            {
                return Username;
            }
        }

        public bool CheckUsername(string username)
        {
            foreach(var item in arrList)
            {
                if (!arrList.Contains(username))
                {
                    Console.WriteLine("Elave etmek istediyiniz " + username + " artiq sistemde movcuddur!");
                    return true;
                }
            }
            return false;
        }

        public string PassWord
        {
            set
            {
                ValidationPassword(value);
                Password = value;
                
            }
            get
            {
                return Password;
            }
        }

        public bool ValidationPassword(string checkPassword)
        {

            if (ValidationPassword(checkPassword))
            {
                if (string.IsNullOrWhiteSpace(checkPassword))
                {
                    Console.WriteLine("Password bolmesi bos ola bilmez.");
                }
                else if (checkPassword.Length < 9 && checkPassword.Length > 20)
                {
                    Console.WriteLine("Sifre 8 simvoldan az olmalidir.");
                }
                else if (!checkPassword.Any(char.IsUpper))
                {
                    Console.WriteLine("Sifrede en az 1 boyuk herfden istifade etmelisiz.");
                }
                else if (!checkPassword.Any(char.IsDigit))
                {
                    Console.WriteLine("Sifrede en az 1 reqemden istifade edin.");
                }
                else
                {
                    Console.WriteLine("Sifre duzgun teyin olunub.");
                }
                return true;
            }
            return false;
        }

        public void Add(Customer customer)
        {
         if (customer == null ||
             string.IsNullOrEmpty(customer.Email) ||
             string.IsNullOrEmpty(customer.UserName))
            {
                Console.WriteLine("Obyekt bos ola bilmez.");
                return;
            }

        } 

    }
}
