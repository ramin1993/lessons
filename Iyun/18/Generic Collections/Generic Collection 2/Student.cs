using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_2
{
   public sealed class Student:BaseClass,IGenericRepostroy<Student>
    {
        public double Point { get; set; }
        public string ColorEyes { get; set; }

        public void Add(Student data)
        {
            data.ColorEyes = "Green";
        }
        public void UpDate(Student data)
        {
            data.Point=90.1;
        }
        public void Delete (Student data)
        {
            data.Surname = null;
        }
        public void Get(Student data)
        {
                   Console.WriteLine("Id: " + data.Id + "\n" + "Ad: " + data.Name + "\n" +
                   "Soyad: " + data.Surname + "\n" + "Yas : " + data.Age + "\n" +
                  "Point: " + data.Point + "\n" + "Gozlerinin rengi: " + data.ColorEyes);

                  Console.WriteLine("-----------------------");
        }


    }
}
