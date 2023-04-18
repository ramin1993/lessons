using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
            
           //  Ask name,lastname and city of users and keep these on the variable.
             
            Console.WriteLine("Name : ");
            var name = Console.ReadLine();
            Console.WriteLine("Lastname : ");
            var lastName = Console.ReadLine();
            Console.WriteLine("City : ");
            var city = Console.ReadLine();
            Console.WriteLine(city);
            Console.WriteLine(name + " " + lastName + " " + city);



            //Bu methodu proqram baglanmamasi ucun yazmisam.
            Console.ReadLine();

            #endregion

        }
    }
}
