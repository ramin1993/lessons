using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    class Program
    {
       

        static void Main(string[] args)
        {
            #region Homework
            /*
            Homework 1:
            Customer class'ının Id, Name, Surname, Age property'ləri olsun. Birdə əlavə olaraq Address Class'ı yaradıb onu da
            inner type olaraq Customer'ə property kimi əlavə edin. Address'in bu property'ləri olacaq: Id, No, Building, Street,
            City, Country. City və Country'ni Address'in içində string olaraq verin əlavə Class'a çıxarmağa ehtiyyac yoxdur.
            2-3 dənə Customer və onların Address'lərini əlavə edib sonra Customer tipində bir listə yığın. Sizdən istədiyim odur
            ki, Foreach ilə (customers.Foreach()) aşağıdakı kimi dataları yazdırasınız:
               ID: 1
               Name: Cavid
               Surname: Cavidov
               Age: 20
               Address Info:
               ID: 100
               No: 10
               Building: Some Building
               Street: Some Street
               City: Some City
               Country: Some Country

               ID: 2
               Name: Hasan
               Surname: Hasanov
               Age: 32
               Address Info:
               ID: 100
               No: 10
               Building: Some Building
               Street: Some Street
               City: Some City
               Country: Some Country
            */
            

            Address address = new Address(
                     Id: 10,
                     No: 100,
                     Building: "N Building",
                     Street: "N Street",
                     City: "N City",
                     Country: "N Country"
              );
            Customer<string> cust = new Customer<string>(
                     Id: 1,
                     Name: "Ramin",
                     Surname: "Suleymanov",
                     Age: 30                
                );

            cust.Address = address;

            Address address1 = new Address(

                 Id: 20,
                 No: 200,
                 Building: "N Building",
                 Street: "N Street",
                 City: "N City",
                 Country: "N Country"
            );

            Customer<string> cust1 = new Customer<string>(
                Id: 2,
                Name: "Vusal",
                Surname: "Hesenov",
                Age: 20
                );

            cust1.Address = address1;

            Address address2 = new Address(

                Id: 30,
                No: 300,
                Building: "N Building",
                Street: "N Street",
                City: "N City",
                Country: "N Country"
              );

            Customer<string> cust2 = new Customer<string>(
                Id: 3,
                Name: "Seymur",
                Surname: "Memmedov",
                Age: 40
                );

            cust2.Address = address2;

            List<Customer<string>> custGen = new List<Customer<string>>();

            custGen.Add(cust);
            custGen.Add(cust1);
            custGen.Add(cust2);
  
            custGen.ForEach(cus => Console.WriteLine(
               "Id: " + cus.Id + "\n" +
               "Ad :" + cus.Name + "\n" + 
               "Soyad: " + cus.Surname  + "\n" + 
               "Yas: "+  cus.Age + "\n" + 
               "Address Id: "+ cus.Address.Id + "\n" +
               "Olke: " + cus.Address.Country + "\n" +
               "Seher: " + cus.Address.City + "\n" +
               "Kuce: " + cus.Address.Street + "\n" +
               "Bina: " + cus.Address.Building + "\n" +
               "Bina Nomresi: " +cus.Address.No +"\n"));


            #endregion

        }
    }
    }
