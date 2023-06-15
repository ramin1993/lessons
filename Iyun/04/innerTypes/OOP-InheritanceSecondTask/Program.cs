using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_InheritanceSecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework(Task2)
            /*
               Aşağıda yazdığım class'ların property'lərini base class'a çıxardıb inherit almaq lazımdır.
               Nəyi necə edəcəyinizə qarışmıram özünüz qərar verin...
               
               Employee: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking,
               RestDays, RegUser, RegDate, EditUser, EditDate,Deleted
               
               Teacher: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, DateOfStartWorking, DateOfEndWorking,
               RestDays, Branch, Level, RegUser, RegDate, EditUser, EditDate, Deleted
               
               Student: Id, ReferanceNumber, DocumentNumber, Name, Surname, Gender, Department, Level, 
               RegUser, RegDate, EditUser, EditDate, Deleted
            */
            Employee employee = new Employee();
            employee.Id = 100;
            employee.ReferanceNumber = 123456;
            employee.DocumentNumber = 223344;
            employee.DocumentNumber = 223344;
            employee.Name = "Ramin";
            employee.Surname = "Suleymanov";
            employee.Gender=1;
            employee.DateOfStartWorking = Convert.ToDateTime("12,12,2019");
            employee.DateOfEndWorking= Convert.ToDateTime("11,11,2020");
            employee.RestDays = "Thusday";
            employee.RegUser = "ramin93";
            employee.RegDate= Convert.ToDateTime("16,11,2020");
            employee.EditUser = null;
            employee.EditDate = null;
            employee.Deleted = false;


            Teacher teacher = new Teacher();
            teacher.Id = 200;
            teacher.ReferanceNumber = 456378;
            teacher.DocumentNumber = 555;
            teacher.Name ="Orxan";
            teacher.Surname ="Ferecov";
            teacher.Gender = 1;
            teacher.DateOfStartWorking = Convert.ToDateTime("12,12,2020");
            teacher.DateOfEndWorking = Convert.ToDateTime("12,12,2022");
            teacher.RestDays = "Wednsday";
            teacher.Branch = "Education";
            teacher.Level = 1;
            teacher.RegUser = "teacher123";
            teacher.RegDate = Convert.ToDateTime("13,11,2019");
            teacher.EditUser = null;
            teacher.EditDate = null;
            teacher.Deleted = false;

            Student student = new Student();
            student.Id = 300;
            student.ReferanceNumber = 963636;
            student.DocumentNumber = 452365;
            student.Name = "Tofiq";
            student.Surname = "Huseyinzade";
            student.Gender = 1;
            student.Department = "Study";
            student.Level = "Middle";
            student.RegUser = "th123";
            student.RegDate = Convert.ToDateTime("13,10,2021");
            student.EditUser = null;
            student.EditUser = null;
            student.Deleted = false;
            





            #endregion
        }
    }
}
