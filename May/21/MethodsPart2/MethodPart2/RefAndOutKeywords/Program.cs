using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ref və Out keyword'larını araşdırın.
            /*
             *Ref açar sözü:
                 Parametr ref açar sözü ilə elan edildikdə, metoda ötürülən arqumentin metodu çağırmadan əvvəl
                 işə salınmalı olduğunu göstərir. Metod arqumentin dəyərini dəyişdirə bilər və metod daxilində 
                 parametrə edilən hər hansı dəyişiklik orijinal dəyişəndə əks olunacaq.Həm metodun teyininde, 
                 həm də metod çağırışı zamanı ref açar sözünü açıq şəkildə istifadə etmək tələb olunur.
               
            *Out açar sözü
                Parametr out açar sözü ilə elan edildikdə, metoda ötürülən arqumentin metodu çağırmadan əvvəl 
                işə salınmasına ehtiyac olmadığını göstərir.Metod return etməzdən əvvəl out parametrinə dəyər 
                təyin etməlidir.

            *Ref ve Outun ferqleri.
                Ref compile-ya obyektin funksiyaya daxil edilmezden evvel baslayacagini,out ise obyektin funksiya
                daxilinde ise salinacagini bildirir.
           */

            #region Ref
            int x =1;
            Ref(ref x);
            #endregion

            #region Out
            int y;
            Out(out y);
            #endregion

        }

        #region Ref
        static void Ref(ref int val)
        {
            val = 2;
            val++;
            Console.WriteLine(val);
        }
        #endregion

        #region Out
         
         public static void Out(out int val)
        {
            val = 10;
            Console.WriteLine(val);
        }
        #endregion

    }
}
