using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPart2
{
    class Employee
    {
        public string EmployeeInfo(string name, string surname)
        {
            
            return name + surname;
            
        }
        public DateTime  EmployeeInfo(DateTime birthday)
        {
            return birthday;
        }

        public double EmployeeInfo(double salary = 355.6)
        {        
            return salary;
        }

    }
}
