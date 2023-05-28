using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework4
            /*
                Bir dənə kiçik console app yazın. Bu app sizdən sinif adı soruşacaq. Məsələn 1A, 1B və s. daxil ediləcək.
                Sonra sinif rəhbərinin adı soruşulacaq. Axırda isə, 10 tələbə adı soruşulacaq. 
                Bu tələbələrin adlarını array'dan istifadə etmədən 10 ayrı string dəyişəndə
                saxlayın student1, student2, student3... və sonra sinif adı, müəllim adı, 
                tələbələrin adlarını göndərə biləcəyiniz bir method yazın.
                Method cəmi 3 parametr qəbul edə bilər. 3-dən artıq parametr istifadə etmək haqqınız yoxdur. 
                Axırda sinif haqqında məlumat yazısı və onun altında sinif adı, sinif rəhbərinin adı və
                tələbə adları alt-alta yazılsın. Tələbə adlarını da collection və ya list
                şəklində göndərmək haqqınız yoxdur. İp ucu verim dərsdə keçmişdik.
             */
            #endregion
            Console.WriteLine("Sinifin adin qeyd edin.");
            string className = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Sinif rehberinin adin qeyd edin");
            string headClass = Convert.ToString(Console.ReadLine());

            

            void ClassStudents(params string[] students)
            {

                Console.WriteLine(" {0} Telebe adi yazin:", students.Length);
                for (int i = 0; i < students.Length; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Telebe {0} : ", i + 1);
                    students[i] = Convert.ToString(Console.ReadLine());
                }


            }
            string student1="", student2="", student3="",
                student4="", student5="", student6="", 
                student7="", student8="", student9="", student10="";

             ClassStudents(student1, student2, student3, student4, student5,
             student6, student7, student8, student9, student10);


        }

        public static void ShowclassInfo()
        {
            
        }


    }
}
 