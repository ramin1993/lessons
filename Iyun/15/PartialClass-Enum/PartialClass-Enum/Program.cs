using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            /*
              Bir dənə kitabxana app'ı yazacaqsınız. İlk öncə mən bir neçə müəllif əlavə edəcəyəm və sonra da
              müəlliflərin kitablarını əlavə edəcəyəm. Nəzərə alın ki, müəllifləri əlavə edəndən sonra birinci müəllif
              məlumatlarını ekranda görməliyəm ki, kitab'ı əlavə edəndə müəllifin Id dəyərinə görə əlavə edəcəm.
              Bura qədər bildiyiniz hər şeydən istifadə edərək bu app'ı yazmağa çalışın. Müəllif və kitabları əlavə
              etmək, silmək, hamısını görmək, Ad'a görə axtarmaq kimi seçim olacaq. Bacarsanız editləmək funksiyasını
              da yazın.
            */
            #endregion

            Console.WriteLine("1. Muellif elave et.");
            Console.WriteLine("2. Butun muellifleri gor");
            Console.WriteLine("3. Muellifi ada gore axtar.");
            Console.WriteLine("4. Muellifi editle.");
            Console.WriteLine("5. Kitab elave et.");
            Console.WriteLine("6. kitablari gor.");
            Console.WriteLine("7. Muellifleri sil .");
            Console.WriteLine("8. Kitablari sil .");

           
            string chooseOperation = Console.ReadLine();

            
            Author author = new Author();
            Books book = new Books();
            VirtualDataBase vtb = new VirtualDataBase();


            switch (chooseOperation)
            {
               
                case "1":

                    vtb.AddAuthor(author);

                    goto case "2";
                case "2":

                    vtb.ShowAllAuthor(author);

                    goto case "3";
                case "3":

                    vtb.SearchAuthorByName(author);

                    goto case "4";
                case "4":

                    vtb.EditAuthor(author.Id);

                    break;
                case "5":

                    vtb.AddBooks(book,author);

                    goto case "6";
                case "6":

                    vtb.ShowAllBooks(book);

                    break;
                case "7":

                    vtb.DeleteAllAuthors(author.Id);

                    break;
                case "8":

                    vtb.DeleteAllBooks(book.Id);

                    break;
                default:
                    Console.WriteLine("Secim duzgun edilmemisdir!");
                    break;
            }
            



        }
    }
}
