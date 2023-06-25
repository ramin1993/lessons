using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_2
{
   public sealed class Teacher:BaseClass,IGenericRepostroy<Teacher>
    {
        public double Branch { get; set; }
        private double Salary { get; set; }

        
        public void Add(Teacher data)
        {
            data.Salary = 5000.7;
        }
        public void UpDate(Teacher data)
        {
            data.Name = "Tural";
        }
        public void Delete(Teacher data)
        {
            data.Surname = null;
        }
        public void Get(Teacher data)
        {
            Console.WriteLine("Id: "+ data.Id + "\n" + "Ad: "+data.Name + "\n" +
                              "Soyad: "+data.Surname + "\n" + "Yas : " + data.Age + "\n" +
                             "Maas: " + data.Salary+"\n"+ "Branch: "+data.Branch);

            Console.WriteLine("-----------------------");
        }
    }
}
