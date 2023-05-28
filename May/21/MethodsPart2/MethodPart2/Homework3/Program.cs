using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework3
            /*
                Local function'lar yaradaraq bir kalkulyator yaradın.
                Ümumi bir calculate methodu olmalıdır və o method'un içində də 
                Toplama, Çıxma, Vurma və Bölmə local function'ları olacaq.
                Ümumi Calculate method'unun overload'ları olmalıdır və iki decimal,
                iki int, iki string, string-decimal, decimal-int və 
                int-string parametrləri ilə işləməlidir.
                Nümunə: İki int, iki decimal dedikdə onu nəzərdə tuturam ki,
                Calculate(15, 15), Calculate(15.2M, 20.5M) qaydada istifadə ediləcək.
                Ancaq string-decimal dedikdə yəni parametrin biri string digəri decimal olacaq ("15", 20.2M) yada 
                int-string üçün (20, "15") belə. Bölmə zamanı divide zero exeption'dan qaçının.
                Birdə Calculator'un 2 variant faiz hesablama funksiyası da olacaq. 
                Birinci variant A parametrinin B parametr faizi neçədir?
                Yəni 100-ün 5 faizi neçədir? hesablayacaq. 
                İkinci variant isə A parametri B parametrinin neçə faizidir? Yəni 10 (a parametri),
                100-ün (b parametrinin) neçə faizidir?
             */

            #endregion
            Console.WriteLine("calc");
            Console.ReadLine();
            int Addition(int n1, int n2)
            {
                return n1 + n2;
            }
            int i1 = 5;
            int i2 = 10;
            int res = Addition(i1, i2);
            Console.WriteLine(res);



            void Subtraction(string n1 = "21", string n2 = "6")

            {

                int num1 = int.Parse(n1);
                int num2 = int.Parse(n2);
                int rs = SubtractionNumbs(num1, num2);
                string rsStr = rs.ToString();
                Console.WriteLine("Cavab:" + rsStr);
            }


            int SubtractionNumbs(int n1, int n2)
            {
                return n1 - n2;
            }
            

            decimal Divide(decimal n1, decimal n2)
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Sifira bolunme emeliyyati yoxdur.");
                }
                return n1 / n2;
            }
            decimal resDivide = Divide(22.1m, 12.9m);
            Console.WriteLine(resDivide);

            decimal Multiple(decimal n1, int n2)
            {
                return n1 * n2;

            }
            decimal resMultiple = Multiple(33.2m, 9);
            Console.WriteLine(resMultiple);

            double PersantForFirstParametr(double n1, double n2)
            {
                return (n2 * 100) / n1;
            }
            double resPersantFirst = PersantForFirstParametr(20, 5);
            Console.WriteLine(resPersantFirst);

            double PersantForSecondParametr(double n1, double n2 ) 
                                                                       
            {
                return (n1 * 100) / n2;

            }
            double resPersantSecond = PersantForSecondParametr(30, 5);
            Console.WriteLine(resPersantSecond);

        }

        public static void Calculator()
        {

        }

    }
}
