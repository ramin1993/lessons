using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes_Part3_
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework1
            /*İstifadəçidən 2 dənə ayrı dəyər alın(rəqəm).
              Məsələn birincidə istifadəçi 20 daxil etdi onu a dəyişənində saxlayın. 
              İkincidə 50 daxil etdi onu da b dəyişənində saxlayın.Elə edin ki, 
              bu iki dəyişənin dəyərlərinin yerlərini dəyişdirin. 
              Yəni a 20, b 50 - dirsə elə edin ki, a olsun 50, b olsun 20.*/


            Console.Write("1 ci reqem daxil edin :");
            string a = Console.ReadLine();

            Console.Write("2 ci reqem daxil edin :");
            string b = Console.ReadLine();

            int getb = int.Parse(b.ToString());
            int geta = int.Parse(a.ToString());

            #endregion

            #region Homework2
            //İstifadəçidən 3 ayrı sətirdə 3 ayrı rəqəm alın.
            // İstifadəçi 3 - cü rəqəmi daxil etdikdən sonra ekrana belə bir yazı yazdırın Nəticə: 5 + 5 + 10 = 20.Bunu
            //çıxma, vurma və bölmə üçün də edin.

            //Toplama emeliyyati

            Console.Write("1 ci reqem daxil edin :");
            int firstPlus = int.Parse(Console.ReadLine());

            Console.Write("2 ci reqem daxil edin :");
            int secondPlus = int.Parse(Console.ReadLine());

            Console.Write("3 ci reqem daxil edin :");
            int ThirdPlus = int.Parse(Console.ReadLine());

            int sumPlus = firstPlus + secondPlus + ThirdPlus;

            Console.Write(sumPlus);
            Console.ReadLine();

            //Bolme emeliyyati

            Console.Write("1 ci reqemi daxil edin :");
            double firstDivide = double.Parse(Console.ReadLine());

            Console.Write("2 ci reqemi daxil edin :");
            double secondDivide = double.Parse(Console.ReadLine());

            Console.Write("3 cu reqemi daxil edin :");
            double thirdDvide = double.Parse(Console.ReadLine());

            double sumDivide = firstDivide / secondDivide / thirdDvide;
            Console.Write(sumDivide);
            Console.ReadLine();


            //Cixma Emeliyyati

            Console.Write("1 ci reqemi daxil edin :");
            int firstMinus = int.Parse(Console.ReadLine());

            Console.Write("2 ci reqemi daxil edin :");
            int secondMinus = int.Parse(Console.ReadLine());

            Console.Write("3 cu reqemi daxil edin :");
            int thirdMinus = int.Parse(Console.ReadLine());

            int sumMinus = firstMinus - secondMinus - thirdMinus;

            Console.WriteLine(sumMinus);
            Console.ReadLine();

            //Vurma Emeliyyati

            Console.Write("1 ci reqemi daxil edin :");
            int firstMulti = int.Parse(Console.ReadLine());

            Console.Write("2 ci reqemi daxil edin :");
            int secondMulti = int.Parse(Console.ReadLine());

            Console.Write("3 cu reqemi daxil edin :");
            int thirdMulti = int.Parse(Console.ReadLine());


            int sumMulti = firstMulti * secondMulti * thirdMulti;
            Console.WriteLine(sumMulti);
            Console.ReadLine();





            #endregion

            #region Homework3
            // İstifadəçidən 10 dənə fərqli rəqəm alıb bir dəyişəndə toplayın.
            //Bu taskı da çıxma, vurma və bölmə üçün də edin.Çıxmada və toplama əməliyyatlarında 10 - cu dəyər daxil
            // edildikdən sonra alınan nəticəyə 1 toplayacaq və ya çıxacaqsız. 
            //Vurmada bölmədə isə, alınan nəticəni 20'ə vurun və ya bölün.

            ////Toplama Emeliyyati(+1)
            Console.Write("1ci reqem daxil edin :");
            int firstNumPlus = int.Parse(Console.ReadLine());

            Console.Write("2 ci reqem daxil edin :");
            int secondNumPlus = int.Parse(Console.ReadLine());

            Console.Write("3 cu reqem daxil edin :");
            int thirdNumPlus = int.Parse(Console.ReadLine());
            ]
            Console.Write("4 cu reqem daxil edin :");
            int fourthNumPlus = int.Parse(Console.ReadLine());

            Console.Write("5 ci reqem daxil edin :");
            int fifthNumPlus = int.Parse(Console.ReadLine());

            Console.Write("6 ci reqem daxil edin :");
            int sixthNumPlus = int.Parse(Console.ReadLine());

            Console.Write("7 ci reqem daxil edin :");
            int seventhNumPlus = int.Parse(Console.ReadLine());

            Console.Write("8 ci reqem daxil edin :");
            int eighthNumPlus = int.Parse(Console.ReadLine());

            Console.Write("9 cu reqem daxil edin :");
            int ninethNumPlus = int.Parse(Console.ReadLine());

            Console.Write("10 cu reqem daxil edin :");
            int tenthNumPlus = int.Parse(Console.ReadLine());

            int sumPlusResult = firstNumPlus + secondNumPlus + thirdNumPlus + fourthNumPlus +
                       fifthNumPlus + sixthNumPlus + seventhNumPlus +
                       eighthNumPlus + ninethNumPlus + ninethNumPlus + 5;


            Console.WriteLine(sumPlusResult);
            Console.ReadLine();

            //Cixma emeliyyati(-1)

            Console.Write("1 ci reqem daxil edin :");
            int firstNumMinus = int.Parse(Console.ReadLine());

            Console.Write("2 ci reqem daxil edin :");
            int secondNumMinus = int.Parse(Console.ReadLine());

            Console.Write("3 cu reqem daxil edin :");
            int thirdNumMinus = int.Parse(Console.ReadLine());

            Console.Write("4 cu reqem daxil edin :");
            int forthNumMinus = int.Parse(Console.ReadLine());

            Console.Write("5 ci reqem daxil edin :");
            int fifthNumMinus = int.Parse(Console.ReadLine());

            Console.Write("6 ci reqem daxil edin :");
            int sixthNumMinus = int.Parse(Console.ReadLine());

            Console.Write("7 ci reqem daxil edin: ");
            int seventhNumMinus = int.Parse(Console.ReadLine());

            Console.Write("8 ci reqem daxil edin: ");
            int eighthNumMinus = int.Parse(Console.ReadLine());

            Console.Write("9 cu reqem daxil edin: ");
            int ninethNumMinus = int.Parse(Console.ReadLine());

            Console.Write("10 cu reqem daxil edin: ");
            int tenthNumMinus = int.Parse(Console.ReadLine());

            int sumMinusResult = firstNumMinus - secondNumMinus - thirdNumMinus -
                                 forthNumMinus - fifthNumMinus - sixthNumMinus -
                                 seventhNumMinus - eighthNumMinus - ninethNumMinus -
                                 tenthNumMinus - 1;

            Console.Write(sumMinusResult);
            Console.ReadLine();

            //Bolme Emeliyyati(/20);

            Console.Write("1 ci reqem daxil edin: ");
            double firstDvd = double.Parse(Console.ReadLine());

            Console.Write("2 ci reqem daxil edin: ");
            double secondDvd = double.Parse(Console.ReadLine());

            Console.Write("3 cu reqem daxil edin: ");
            double thirdDvd = double.Parse(Console.ReadLine());

            Console.Write("4 cu reqem daxil edin: ");
            double fourthDvd = double.Parse(Console.ReadLine());

            Console.Write("5 ci reqem daxil edin: ");
            double fifthDvd = double.Parse(Console.ReadLine());

            Console.Write("6 ci reqem daxil edin: ");
            double sixthDvd = double.Parse(Console.ReadLine());

            Console.Write("7 ci reqem daxil edin: ");
            double seventhDvd = double.Parse(Console.ReadLine());

            Console.Write("8 ci reqem daxil edin: ");
            double eighthDvd = double.Parse(Console.ReadLine());

            Console.Write("9 cu reqem daxil adin: ");
            double ninethDvd = double.Parse(Console.ReadLine());

            Console.Write("10 cu reqem daxil edin: ");
            double tenthDvd = double.Parse(Console.ReadLine());

            double resDvd = (firstDvd / secondDvd / thirdDvd /
                            fourthDvd / fifthDvd / sixthDvd /
                            seventhDvd / eighthDvd / ninethDvd /
                            tenthDvd) / 20;
            Console.WriteLine(resDvd);
            Console.ReadLine();


            //Vurma Emeliyyati(*20)
            Console.Write("1 ci reqem daxil edin: ");
            long firstMul = long.Parse(Console.ReadLine());

            Console.Write("2 ci reqem daxil edin: ");
            long secondMul = long.Parse(Console.ReadLine());
            long res = firstMul * secondMul * 20;

            Console.Write("3 cu reqem daxil edin: ");
            long thirdMul = long.Parse(Console.ReadLine());

            Console.Write("4 cu reqem daxil edin: ");
            long fourthMul = long.Parse(Console.ReadLine());

            Console.Write("5 ci reqem daxil edin: ");
            long fifthMul = long.Parse(Console.ReadLine());

            Console.Write("6 ci reqem daxil edin: ");
            long sixthMul = long.Parse(Console.ReadLine());

            Console.Write("7 ci reqem daxil edin: ");
            long seventhMul = long.Parse(Console.ReadLine());

            Console.Write("8 ci reqem daxil edin: ");
            long eighthMul = long.Parse(Console.ReadLine());

            Console.Write("9 cu reqem daxil edin: ");
            long ninethMul = long.Parse(Console.ReadLine());

            Console.Write("10 cu reqem daxil edin: ");
            long tenthMul = long.Parse(Console.ReadLine());

            long resMul = firstMul * secondMul * thirdMul *
                           fourthMul * fifthMul * sixthMul *
                           seventhMul * eighthMul * ninethMul *
                           tenthMul * 20;

            Console.WriteLine(resMul);
            Console.ReadLine();


            #endregion

            #region Homework4
            //İstifadəçidən qeyd etdiyim tiplərdə dəyər alıb onları uyğun tipdə dəyişənlərə çevirəcəksiz.
            // bool, string, short, long, int, char, datetime.

            Console.Write("Adinizi qeyd edin: ");
            string userName = Console.ReadLine();

            Console.Write("1km nece metrdir?: ");
            int userAge = int.Parse(Console.ReadLine());

            Console.Write("Dogum tarixinizi qeyd edin: ");
            DateTime userBirth = DateTime.Parse(Console.ReadLine());

            Console.Write("Cins K ve ya Q :");
            char userGender = char.Parse(Console.ReadLine());

            Console.Write("10 milyardi reqemlerle yazin: ");
            long writeLongNumber = long.Parse(Console.ReadLine());


            Console.WriteLine("Heftenin nece gunu var ?");
            string daysOfWeek = "7";
            int resultOfAnswer;
            bool succesVal = int.TryParse(daysOfWeek, out resultOfAnswer);

            Console.Write("15000 * 2 = ?");
            short userAnswer = short.Parse(Console.ReadLine());

            #endregion

        }
    }
}
