using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            // ask to 10 city name from users then write with commas
            var cityOne = Console.ReadLine();
            var cityTwo = Console.ReadLine();
            var cityThree = Console.ReadLine();
            var cityFour = Console.ReadLine();
            var cityFive = Console.ReadLine();
            var citySix = Console.ReadLine();
            var citySeven = Console.ReadLine();
            var cityEight = Console.ReadLine();
            var cityNine = Console.ReadLine();
            var cityTen = Console.ReadLine();

            Console.Write(cityOne + "," + cityTwo + "," + cityThree + "," + cityFour + "," + cityFive + "," +
                 citySix + "," + citySeven + "," + cityEight + "," + cityNine + "," + cityTen);


            //bu methodu proqram baglanmamasi ucun yazmisam
            Console.ReadLine();
            #endregion
        }
    }
}
