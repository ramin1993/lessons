using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 1
            /*
             Bir array'da rəqəmləri saxlayıb sonra bütün array'dakı rəqəmlərin toplamının ortalamasını tapacaqsınız.
             Bunun üçün öncə bütün elementlərin toplamını tapın sonra onu array'dakı element sayına bölün.
             Proqram açılanda istifadəçidən Array'ın neçə elementi olacağını soruşub həmin sayda elementi olacaq
             bir array yaradacaq. Arrayı yaratdıqdan sonra bütün elementlərinin dəyərlərini istifadəçidən soruşub array'ı 
             doldurun. Axırda da elementlərin toplamını və ortalama dəyərini ekrana yazdırın.
             Bunu həm for döngüsüylə edin həm də foreach.
            */
            //Console.WriteLine("Arrayda nece element olacaq?");
            //int trueInt;
            //bool numbers = int.TryParse(Console.ReadLine(), out trueInt);
            //int[] arr = new int[trueInt];
            //start:
            //int sum = 0;

            //int count = 0;
            //float avrg = 0.0f;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine((i + 1) + "-" + "ci elementi daxil edin.");
            //    int setNumber;
            //    bool checkNumber = int.TryParse(Console.ReadLine(), out setNumber);
            //    if (checkNumber != true)
            //    {
            //        Console.WriteLine("Herflerden istifade etmek olmaz!");
            //        goto start;


            //    }

            //    arr[i] = setNumber;
            //    //sum += arr[i]; //for ile                
            //}


            //foreach (var item in arr)
            //{
            //    sum += item;
            //    count++;
            //}

            //Console.WriteLine("Arrayda olan butun ededlerin cemi :" + " " + sum);

            //avrg = (float)sum / count;
            ////avrg = (float)sum / arr.Length;



            //Console.WriteLine("Arrayda olan ededlerin ceminin ortalama deyeri :" + " " + avrg);
            //Console.ReadLine();
            #endregion

            #region Homework 2
            /*
            int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 };
            bu arrayın içindəki elementləri kiçikdən böyüyə sıralayın. Ancaq bunu edərkən sort və reverse
            method'larından istifadə etmək olmaz :). Alqoritmasını özünüz düşünün.
            */


            //int[] numArr = { 20, 92, 100, 55, 98, 1, 18, 26, 75, 33, 12 };
            //for (int i = 0; i < numArr.Length - 1; i++)
            //{
            //    for (int e = 0; e < numArr.Length - 1; e++)
            //    {
            //        if (numArr[e] > numArr[e + 1])
            //        {
            //            int turnNumbr = numArr[e];
            //            numArr[e] = numArr[e + 1];
            //            numArr[e + 1] = turnNumbr;

            //        }

            //    }

            //}
            #endregion

            #region Homework 3
            /*
            Bir array'a Random() ilə 1-100000 arası 100 ədəd rəqəm yığın.
            Sonra həmin array'dakı ən kiçik və ən böyük rəqəmləri tapın. Əlavə olaraqda bütün rəqəmlərin
            toplamını ekrana yazdırın.
            */

            //Random rand = new Random();
            //int[] arr = new int[100];

            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int numb = rand.Next(1, 100000);
            //    arr[i] = numb;
            //    sum += arr[i];
            //}
            //int maxValue = arr.Max();
            //int minValue = arr.Min();
            //Console.WriteLine(sum);
            #endregion

            #region Homework 4
            /*
              Array'ın property və method'larını araşdırın, nə işə yarayır, necə istifadə edilir, 
              nə üçün istifadə edilir və s. Araşdırdığınız method və property'ləri
              mütləq praktika edin!
            */
            #endregion



        }
    }
}
