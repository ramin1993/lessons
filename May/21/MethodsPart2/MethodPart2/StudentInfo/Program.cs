using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            void ClassStudents(params string [] students) {
                Console.WriteLine(" {0} Telebe adi yazin:", students.Length);
                for (int i = 0; i < students.Length; i++)
                {
                    Console.Clear();
                    Console.WriteLine("Telebe {0} : ", i + 1);
                    students[i] = Convert.ToString(Console.ReadLine());
                }

            }

            void ShowClassInfo(string className1, string headClass1, Func<string[], string> showAllInfo)
            {

                string student1 = "", student2 = "", student3 = "",
                       student4 = "", student5 = "", student6 = "",
                       student7 = "", student8 = "", student9 = "", student10 = "";

                ClassStudents(student1, student2, student3, student4, student5,
                student6, student7, student8, student9, student10);

                string[] students = {student1, student2, student3, student4, student5,
                student6, student7, student8, student9, student10};

                string allInfo = showAllInfo(students);

                Console.WriteLine("Sinif Haqqinda melumat:");
                Console.WriteLine("Sinif adi: " + className1);
                Console.WriteLine("Sinif rehberinin adi: " + headClass1);
                Console.WriteLine(allInfo);
            }

            string className, headClass;

            Console.WriteLine("Sinifin adin qeyd edin.");
            className = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Sinif rehberinin adin qeyd edin");
            headClass = Convert.ToString(Console.ReadLine());

            ShowClassInfo(className, headClass, (students) =>
            {
                string allInfo = "Class information based on students: ";
                for (int i = 0; i < students.Length; i++)
                {
                    allInfo += students[i] + ", ";
                }
                return allInfo;
            });
        }
    }
}
