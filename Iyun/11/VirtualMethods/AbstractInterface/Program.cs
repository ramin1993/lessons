using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Enginer enginer = new Enginer();
            enginer.Name = "Ramin";
            enginer.Surname = "Suleymanov";
            enginer.Specialist();
            enginer.Age(35);


            CarMechanic master = new CarMechanic();
            master.Name = "Zaur";
            master.Surname = "Hesenov";
            master.Specialist();
            master.Age(45);


            Doctor doctor = new Doctor();
            master.Name = "Adil";
            master.Surname = "Muradov";
            doctor.Specialist();
            doctor.Age(55);
        }
    }
}
