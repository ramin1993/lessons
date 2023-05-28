using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework 2
            /*
               Satılacaq məhsulu yaradacaqsınız və onun bir neçə dənə constructor method'ları olacaq.
               Satılacaq məhsul dedikdə məsələn Vehicle class'ı ola bilər.

               Məhsul (item) Class'ında olacaq property'lər:
                 Marka
                 Model
                 İstehsal ili
                 Km
                 Yanacaq növü
                 Sürətlər qutusu
                 Alış qiyməti
                 Satış qiyməti
                 Max endirim məbləği
                 Qiymət (private olması mütləqdir!)

               Constructor overload'ları aşağıdakı kimi olmalıdır:
                 1. marka, model
                 2. marka, model, istehsal ili
                 3. marka, model, istehsal ili, km
                 4. bütün property'lər

               Əlavə olaraq iki methodunuz olacaq hansı ki, birinci method bütün məlumatları ekrana yazacaq və
               ikinci method isə müəyyən obyektin satış qiymətini təyin edəcək. Burda biraz baş işlətmək lazımdır.
               Təyin edilən qiymət, satış qiyməti - max endirim qiyməti qədər
               olmalıdır. Yəni, max endirim qiyməti qədər geriyə gedə bilməliyəm.

               Məsələn:
               Satış qiymətim 10 manatdırsa, maximum endirim qiymətim 2 manatdırsa, 
               mən bu məhsulu ən aşağı 8 manata sata bilməliyəm. 7 manata
               satmağa çalışsam xəta mesajı yazsın ekrana 
               (məs: Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!)
             */
            #endregion


            #region Task in Lesson 1
            /*
             * Vəsiqənin seriyası və vəsiqənin nömrəsi adlı iki xananız olacaq. DocumentSerial və DocumentNumber olaraq adlandıra bilərsiniz.            Hər biri üçün, getter və setteri olan bir property'si və private bir field'ı olacaq.            Validation və xəta mesajları:            Vəsiqənin seriyasını set edən zaman yoxlamalıdır ki, uzunluğu 2 hərfdir mi?            Deyilsə: "Vesiqenin seriyasinin uzunlugu 2 herf olmalidir!" xətası çıxmalıdır.            Eyni zamanda yoxlamalıdır ki, sadəcə hərflərdən mi ibarətdir?            Deyilsə: "Vesiqenin seriyasi sadece herflerden ibaret olmalidir!" xətası çıxmalıdır.            Eyni zamanda da, vəsiqənin nömrəsi set olunan zaman baxmalıdır ki, uzunluğu 8 ə bərabərdir mi?            Deyilsə: "Vesiqenin nomresinin uzunlugu 8 olmalidir!" xətası çıxmalıdır.            Birdə nömrənin rəqəmlərdən ibarət olub-olmaması yoxlanmalıdır.            Deyilsə: "Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!" xətası çıxacaq.            Bu validation'lara əlavə olaraq vəsiqənin nömrəsi get olan zaman ancaq ilk 3 rəqəm user'ə göstəriləcək. Digər rəqəmlər ulduz            simvolu olaraq çıxacaq. Orda elə etmək lazımdır ki, 3 və ulduz sayı dinamik olsun. Yəni mən 3 rəqəmini 4 edən zaman avtomatik            4 simvol görsənsin və geri qalan 4 simvol ulduz çıxsın. Əgər 3 rəqəmini 6 etsəm o zaman ilk 6 rəqəm görsənsin və 2 simvol ulduz            olaraq çıxsın.            Vaxt: 15 dəqiqə
             */
            #endregion

        }
    }
}
