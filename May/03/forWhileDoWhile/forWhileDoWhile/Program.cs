using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forWhileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //95% düz yazmısan. Sadəcə mənfi dəyər daxil etdikdən sonra toplamı göstərib bitirməlidir. Yəni təkrar toplama etməli deyil.
            //Dəyişdirməyinə ehtiyyac yoxdur. Sadəcə əlavə funksionallıq yazmısan ))))
            #region Homework1
            //İstifadəçi mənfi dəyər daxil edənə qədər, 
            //daxil etdiyi bütün müsbət rəqəmləri toplayıb axırda nəticəni ekrana yazın.

            //Console.WriteLine("Toplama emeliyyati edin ");
            ////istifadecinin daxil etdiyi reqemler 
            //uint num;

            ////Bir deyisen yaradib topladigimiz reqemleri onda saxlayiriq 
            //uint tot = 0;

            ////daha sonra bir dongu yaradiriq menfi reqem daxil edene qeder donsun.
            //do
            //{
            //    // try parse methodu ile gelen deyeri integer olub olmadigin yoxlayiriq
            //    bool c = uint.TryParse(Console.ReadLine(), out num);

            //    //eger gelen deyer trudusa dongumuz islesin
            //    if (c == true)
            //    {
            //        //eger daxil edilen deyer sifir ve sifirdan boyukdurse hesablama isleri gorulsun
            //        if (num >= 0)
            //        {
            //            tot += num;
            //        }
            //        else
            //        {
            //            break;
            //        }

            //    }
            //    else //menfi deyer daxil etdiyi zaman altdaki mesaji verib neticeni ekrana yazdirirq.
            //    {
            //        Console.WriteLine("Zehmet olmasa musbet reqem daxil edin");
            //        Console.Write(tot);
            //        Console.ReadLine();
            //    }
            //} while (true);
            #endregion

            //Düzdür
            #region Homework2
            //İstifadəçidən bir rəqəm alın. 
            //While döngüsüylə istifadəçinin daxil etdiyi rəqəmdən 0 - a doğru geriyə sayın.

            //istifadeciden deyer alib deyerin integer olub olmamasini try parse methodu ile yoxlayiriq
            // int user;
            // bool dcrmt = int.TryParse(Console.ReadLine(), out user);

            //// daha sonra bir while dongusu yaradib decrement edirik ve geriye sayimi edirik.
            // while (dcrmt)
            // {
            //     user--;
            //     Console.Write(user);
            // }
            /*Console.ReadLine();*/ //Console.ReadLine()'i burada yazsan daha yaxşı olar ki, geri sayım tam bitəndən sonra gözləsin hər dəfə yoz.


            #endregion

            //Düzdür
            #region Homework3           
            /////* App'ın işləmə prinsipi:
            ////İlk öncə istifadəçidən "Texmin oyunu ucun en yuksek deyeri daxil edin: " yazısı ilə bir rəqəm
            ////alınmalıdır.Sonra 1 ilə bu rəqəm arasında random bir rəqəm generate edilməlidir və 
            ////istifadəçidən generate olunan rəqəmi tapmağı istənməlidir. 
            ////"1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " mesajı ilə istifadəçidən bir rəqəm soruşulur. 
            ////Hər səhv daxil edilən rəqəmdə eyni şey təkrar göstərilir.Sadəcə 2. 3. 4.deyə artır cəhd sayı.
            ////İstifadəçi düzgün rəqəmi tapdığı zaman "5. Cəhdinizdə düzgün rəqəmi tapdınız!" mesajı göstərilməlidir.*/

            // Console.OutputEncoding = Encoding.Unicode;
            // Console.InputEncoding = Encoding.Unicode;

            //// Oyun ucun bir reqem daxil etmesini isteyirik.
            // Console.Write("Texmin oyunu ucun en yuksek deyeri daxil edin:");

            // //Reqemi alib integer tipinde saxlayiriq
            // int getNumb;
            // bool checkNumb = int.TryParse(Console.ReadLine(), out getNumb);

            // //daxil etdiyi reqemden random bir generate edilir.
            // Random rand = new Random();
            // int randNumber = rand.Next(1, getNumb);

            // //istifadecinin duzgun bir cavab tapmasi ucun bir int deyiseni yaradiriq.
            // int correctAnswer = 0;

            // //Cehdleri saymaq ucun bir deyisen 
            // int counter = 1;

            // //istifadeciden bu reqemi tapmagi ucun bir dongu yaradiriq.

            // do
            // {
            //     Console.Write(counter + "." + "Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin:", correctAnswer);
            //     //cehdler zamani daxil etdiyi reqemleri int tipine cevirerek aliriq.
            //     bool correcAnswerTrue = int.TryParse(Console.ReadLine(), out correctAnswer);

            //     // Eger istifadecinin daxil etdiyi deyernen generetion olunmus deyer beraberdirse break etmesini isteyirem
            //     // Diger halda davam etsin

            //     if (randNumber == correctAnswer)
            //     {

            //         counter++;
            //         Console.Write(counter + "." + "Cehdinizde duzgun reqem tapdiniz!");
            //         Console.ReadLine();
            //         break;
            //     }
            //     else if (correctAnswer > getNumb)
            //     {
            //         break;
            //     }
            //     counter++;
            // } while (true);
            #endregion

            //Düzdür, halal olsun.
            #region HomeWork4
            /*  Belə bir vurma cədvəli çıxardın ekrana. İp ucu verim,
                Console.Write("1*2=2\t"); yazacaqsız. Orda \t sizə boşluqları
                təmin edəcək. Logic hissəsini isə özünüz fikirləşin.
                1*1=1   1*2=2   1*3=3   1*4=4   1*5=5   1*6=6   1*7=7   1*8=8   1*9=9
                2*1=2   2*2=4   2*3=6   2*4=8   2*5=10  2*6=12  2*7=14  2*8=16  2*9=18
                3*1=3   3*2=6   3*3=9   3*4=12  3*5=15  3*6=18  3*7=21  3*8=24  3*9=27
                4*1=4   4*2=8   4*3=12  4*4=16  4*5=20  4*6=24  4*7=28  4*8=32  4*9=36
                5*1=5   5*2=10  5*3=15  5*4=20  5*5=25  5*6=30  5*7=35  5*8=40  5*9=45
                6*1=6   6*2=12  6*3=18  6*4=24  6*5=30  6*6=36  6*7=42  6*8=48  6*9=54
                7*1=7   7*2=14  7*3=21  7*4=28  7*5=35  7*6=42  7*7=49  7*8=56  7*9=63
                8*1=8   8*2=16  8*3=24  8*4=32  8*5=40  8*6=48  8*7=56  8*8=64  8*9=72
                9*1=9   9*2=18  9*3=27  9*4=36  9*5=45  9*6=54  9*7=63  9*8=72  9*9=81
             */

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int e = 1; e <= 9; e++)
            //    {
            //        Console.Write(i + "*" + e + "=" + i * e + " \t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();


            #endregion





        }
    }
}
