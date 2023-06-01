using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            /*
               Encapsulation-OOP nin fundamental prinsipidir.Data ve Metodlari  cagirilan 1 classda birlesdirir.
               Encapsulation OOP nin 4 strukturunnan biridir,Inheritance ,Polymorohism,Abstract.
              
              Encapsulation,obyekt məlumatlarının birbaşa manipulyasiyasının qarşısını almaq və
              dəqiq müəyyən edilmiş interfeys vasitəsilə girişi gücləndirməklə məlumatların bütövlüyünə,
              təhlükəsizliyinə və davamlılığına nail olmağa kömək edir.
              
              Encapsulation-public, private, protected ve internal access modifierlarla teyin olunur ,hansiki 
              gorunmeyi ve elcatanligi  class (field,metodlar, propertiler) vasitesi ile giris ede bilir.Default olaraq 
              class uzvleri private olur ve yalniz hemin klass daxilinde elcatan olur.
              
            */
            #endregion



            #region Homework
            /*
              Bir Student class'ınız olsun. Student class'ında ad, soyad, email private field'larınız olsun. 
              Ad və Soyad olaraq da iki dənə public property'ləriniz olsun. Main method'unda Student'in 
              instance'ını yaradıb birinci Ad property'sini set edəndə soyad, email field'ləri və Soyad 
              property'si null olsun. Sonra Soyad property'si set ediləndə surname field'ı da set edilsin.
              Birinci Soyad property'sini set edib sonra Ad property'sini set edəndə də əksi baş versin.
              İkinci hansı set edilsə o zaman email ad.soyad@gmail.com olaraq təyin edilsin.
              Məsələn orkhan.farajov@gmail.com

              Student student = new Student();
              student.Name = "Orkhan"; //email, soyad field'ları və Soyad property'si burada null olur)
              student.Surname = "Farajov"; //(email burada orkhan.farajov@gmail.com olaraq set olunur)

              Student student2 = new Student();
              student2.Surname = "Farajov"; //(email, ad field'ları və Ad property'si burada null olur)
              student2.Name = "Orkhan"; //(email burada orkhan.farajov@gmail.com olaraq set olunur)
             */
            Student student1 = new Student();
            student1.Surname = "Suleymanov";
            student1.Name = "Ramin";
            Console.WriteLine(student1.Name);      
            Console.WriteLine(student1.Surname);
            Console.WriteLine(student1.Email);     

            Student student2 = new Student();
            student2.Name = "Ramin";
            student2.Surname = "Suleymanov";
            Console.WriteLine(student2.Name);      
            Console.WriteLine(student2.Surname);   
            Console.WriteLine(student2.Email);     

            Console.ReadLine();


            #endregion
        }
    }
}
