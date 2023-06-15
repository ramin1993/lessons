using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inhertitance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework(Task1)
            /*
             OOP-Inheritance
             Aşağıdakı class'ları yaradın. 
             Nəzərə alın ki, inheritance'dan istifadə edərək property'ləri düzgün class içərisində yaratmalısız.

             Car:
                Id,
                Brand,
                Model,
                Km,
                Engine,
                Price,
                CreateDate,
                EditDate

             Phone:
                Id,
                Brand,
                Model,
                FastCharge,
                MadeInCountry,
                Price,
                CreateDate,
                EditDate

             Teacher:
                Id,
                Name,
                Surname,
                BirthDate,
                Gender,
                CreateDate,
                EditDate

             */
            
            Phone phone = new Phone();
            phone.Id = 100;
            phone.Brand = "Apple"; 
            phone.Model = "12pro";
            phone.FastCharge = "30 minutes";
            phone.MadeInCountry = "USA";
            phone.Price = "700$";
            phone.CreateDate = DateTime.Now;
            phone.EditDate = null;

            Car car = new Car();
            car.Id = 200;
            car.Brand = "Bmw";
            car.Model = "M5 F90";
            car.Engine = "800 Horsepower";
            phone.Price = "65000 $";
            phone.CreateDate = DateTime.Now;
            phone.EditDate = null;

            Student student = new Student();
            student.Id = 300;
            student.Name = "Ramin";
            student.Surname = "Suleymanov";
            student.BirthDate = Convert.ToDateTime("26,03,1993");
            student.Gender = 1;
            student.CreateDate = DateTime.Now;
            student.EditDate = null;

            Teacher teacher = new Teacher();
            student.Id = 400;
            student.Name = "Orxan";
            student.Surname = "Ferecov";
            student.BirthDate = Convert.ToDateTime("12,06,1997");
            student.Gender = 1;
            student.CreateDate = DateTime.Now;
            student.EditDate = null;

            #endregion
        }
    }
}
