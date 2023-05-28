using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPart2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Homework1
            // Method overloading araşdırın.
            /*
             Method overloading eyni adda ve ferqli parametrler qebul ederek metodlarla islemeyimize imkan verir.
             Overload metodu cagirilarken compile zamani teqdim olunan arqumentler esasinda metodun uygun
             versiyasi secilir.
             */
            Console.WriteLine("Iscinin adini qeyd edin.");
            string employeeName = Console.ReadLine();

            Console.WriteLine("Iscinin Soyadini qeyd edin.");
            string employeeSurname = Console.ReadLine();

            Console.WriteLine("Iscinin dogum tarixin qeyd edin.");
            DateTime employeeBirthday = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Iscinin maasin qeyd  edin.");
            double employeeSalary = double.Parse(Console.ReadLine());

            Employee newEmployee = new Employee();

            newEmployee.EmployeeInfo(employeeName, employeeSurname);
            newEmployee.EmployeeInfo(employeeBirthday);
            newEmployee.EmployeeInfo(employeeSalary);

            Console.WriteLine("Iscinin adi:{0}" + "\n" + "Iscinin soyadi:{1}", employeeName, employeeSurname);
            Console.WriteLine("Iscinin dogum tarixi:", employeeBirthday);
            Console.WriteLine("Iscinin Maasi:", employeeSalary);
            Console.ReadLine();
            #endregion
        }

    }
}
