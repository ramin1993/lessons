using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Homework 2:
              Generic class yaradaraq (Repository) Add, Update, Get, Delete method'larını yazın. 
              Həmin repository'nin instance'ını Student, Customer, Techer və Book class'ları ilə 
              yaradıb hər bir method'u istifadə edə bilməlisiz. GenericRepository class'ı üçün 
              İnterface'də istifadə edin.
            */
            Teacher teacher = new Teacher();
            teacher.Id = 11;
            teacher.Name = "Ramin";
            teacher.Surname = "Suleymanov";
            teacher.Age = 30;
            teacher.Branch = 100;

            IGenericRepostroy<Teacher> iteacher = new Teacher();
            iteacher.UpDate(teacher);
            iteacher.Delete(teacher);
            iteacher.Add(teacher);
            iteacher.Get(teacher);

            Customer customer = new Customer();
            customer.Id = 21;
            customer.Name = "Rufet";
            customer.Surname = "Sultanov";
            customer.Age = 20;
            customer.Country = "Azerbaycan";

            IGenericRepostroy<Customer> icustomer= new Customer();
            icustomer.UpDate(customer);
            icustomer.Delete(customer);
            icustomer.Add(customer);
            icustomer.Get(customer);

            Student student = new Student();
            student.Id = 31;
            student.Name ="Nergiz";
            student.Surname = "Cemilova";
            student.Age = 19;
            student.Point = 88.5;

            IGenericRepostroy<Student> istudent = new Student();
            istudent.Add(student);
            istudent.Get(student);
            istudent.Delete(student);
            istudent.UpDate(student);

            Book book = new Book();
            book.Id = 1;
            book.Name = "Kitab adi";
            book.Author = "Muellif";
            book.CreateDate = new DateTime(2005,12,20);

            IGenericRepostroy<Book> ibook = new Book();
            ibook.Add(book);
            ibook.Get(book);
            ibook.Delete(book);
            ibook.UpDate(book);
        }
    }
}
