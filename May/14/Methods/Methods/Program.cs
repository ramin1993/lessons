using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            /*
              Homework 1:
              Main methodunda tələbənin ad, soyad, qiymət 1, qiymət 2 və
              qiymət 3 məlumatları alınıb hamısı bir method'a ötürüləcək.
              Əlavə olaraq bir Student class'ınız olsun. Bu class'da 3 method olacaq. 
              CalcAverage, RateAverage və bir dənə də CalcAverage'in overload'ı olacaq.
              Bunun üçün Method Overloading mövzusu araşdırılmalıdır. 
              CalcAverage ortalama qiyməti hesablayacaq. RateAverage isə ortalama qiymətə görə,
              tələbənin ortalamasının 45-dən yuxarı/aşağı olub-olmamasını check edəcək. 
              Əgər yuxarıdırsa keçib, aşağıdırsa kəsilib yazısını ekrana çıxardacaq.            
            */

            string name,surname;          
            double pointOne, pointTwo, pointThree;

          

            Console.WriteLine("Telebenin adin daxil edin:");
            name = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Telebenin soyadini daxil edin:");
            surname = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Telebenin 1-ci qiymetini qeyd edin ");

            pointOne = double.Parse(Console.ReadLine());
            

            Console.WriteLine("Telebenin 2-ci qiymetini qeyd edin ");
            pointTwo = double.Parse(Console.ReadLine());


            Console.WriteLine("Telebenin 3-cu qiymetini qeyd edin: ");
            pointThree = double.Parse(Console.ReadLine());


            Student studentInstance = new Student();

            double avrgPoint= studentInstance.calcAverage(pointOne, pointTwo, pointThree);
                  
            Console.WriteLine("Ortalama qiymeti : " +  avrgPoint);

            studentInstance.calcAverage(name, surname);
            Console.WriteLine("Telebenin adi: {0} soyadi: {1}", name, surname);

            studentInstance.rateAverage();

            Console.ReadLine();
            #endregion
        }
    }
}
