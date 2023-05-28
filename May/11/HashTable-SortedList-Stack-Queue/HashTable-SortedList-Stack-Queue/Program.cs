using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_SortedList_Stack_Queue
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Homework 
            /*
                İlk öncə aşağıdakı kimi bir menu çıxsın ekranda.

                Menu:
                1 - Element elave et
                2 - Elementleri goster
                3 - Element axtar
                4 - Element editle
                5 - Element sil
                6 - Exit
                Emeliyyat novunu secin:

                Əməliyyat növünü user seçdikdən sonra aşağıdakı kimi proses davam edəcək...
                1:
                Soruşacaq: "Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "
                Daxil edəndən sonra: "Element elave olundu!"

                2:
                Bunu seçəndə bütün elementlər aşağıdakı kimi göstəriləcək.
                1. Element = 15
                2. Element = Salam
                3. Element = Hi
                Burdan çıxmaq üçündə "Davam etmek ucun Enter'e basin" yazısı görsənəcək.

                3:
                Bunu seçəndə aşağıdakı yazı çıxacaq.
                "Axtarmaq istediyiniz elementi daxil edin: "
                Daxil edəndən sonra əgər tapılıbsa, aşağıdakı yazı çıxsın
                "Element tapildi : Index :0 - Deyer: Salam"
                tapılmayıbsa bu yazı çıxsın
                "Axtardiginiz element tapilmadi".

                4:
                "Editlemek istediyiniz elementi daxil edin : " yazısı çıxsın və məsələn Salam sözünü editləmək istəyirsə,
                ilk öncə yoxlayın Salam elementi var mı? Yoxdursa bu yazı çıxsın:
                "Axtardiginiz element tapilmadi"
                Varsa:
                "Salam elementini ne ile evezlemek isteyirsiniz?"
                Editləyəndən sonra da "Element editlendi!" yazısı çıxsın.

                5:
                İlk öncə bunu soruşsun:
                "Butun elementleri silmek isteyirsiniz? (H/Y)"
                əgər cavab H olarsa o zaman bütün elementləri silib "Butun elementler silindi" yazısı çıxsın.
                əgər cavab Y olarsa o zaman "Silmek istediyiniz elementi daxil edin: " yazısı çıxsın və məsələn adam Salam daxil etdisə 
                ilk öncə yoxlayın Salam var mı? Varsa silib "Element silindi" yazın yoxdursa "Silmek istediyiniz element tapilmadi!" yazısı
                çıxsın.
            */

            /* Menu:
             1 - Element elave et
             2 - Elementleri goster
             3 - Element axtar
             4 - Element editle
             5 - Element sil
             6 - Exit*/

            Console.WriteLine("1 - Element elave et");
            Console.WriteLine("2 - Elementleri goster");
            Console.WriteLine("3 - Elementleri axtar");
            Console.WriteLine("4 - Elementleri editle");
            Console.WriteLine("5 - Elementleri sil");
            Console.WriteLine("6 - Exit");


            Console.WriteLine("Emeliyyat novunu secin");
            var operation = Console.ReadLine();

            Hashtable ntb = new Hashtable();

            string elementValue;
            int elementCount = 1;


            switch (operation)
            {
                case "1":

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Zehmet olmasa daxil etmek istediyiniz elementi yazin.");
                        elementValue = Console.ReadLine();


                        string key = $"{elementCount}. Element";
                        elementCount++;


                        ntb.Add(key, elementValue);

                        Console.WriteLine("Yeni element daxil etmek isteyirsiz? H/Y?");
                    } while (Console.ReadLine().ToUpper() == "H");


                    goto case "2";
                case "2":

                    foreach (DictionaryEntry item in ntb)
                    {

                        Console.WriteLine(item.Key + ":" + item.Value);
                    }
                    /*
                      foreach (DictionaryEntry item in ntb)
                      {
                          Console.WriteLine("{0} - {1}", item.Key, item.Value);
                      }
                     */
                    Console.WriteLine("Davam etmek ucun enter duymesine basin.");
                    Console.ReadKey();
                    goto case "3";
                case "3":

                    Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin :");
                    string searchWord = Convert.ToString(Console.ReadLine());
                    if (ntb.ContainsValue(searchWord))
                    {


                        DictionaryEntry entry = new DictionaryEntry(elementCount, searchWord);

                        Console.WriteLine("Element tapildi :" + " " + "{0} - {1}", entry.Key, entry.Value);


                    }
                    else
                    {
                        Console.WriteLine("Axtardiginiz element tapilmadi !");
                    }
                    goto case "4";

                case "4":
                    Console.WriteLine("Editlemek istediyiniz elementi yazin");
                    object editWord = (object)Console.ReadLine();
                    if (ntb.ContainsValue(editWord))
                    {
                        Console.WriteLine("Elementi ne ile evezlemek isteyirsiniz?");
                        string newEditWord = Console.ReadLine();


                        string oldKey = "";
                        foreach (DictionaryEntry item in ntb)
                        {
                            if (item.Value.Equals(editWord))
                            {
                                oldKey = (string)item.Key;
                                break;
                            }
                        }


                        ntb[oldKey] = newEditWord;


                        foreach (DictionaryEntry item in ntb)
                        {
                            Console.WriteLine("{0} - {1}", item.Key, item.Value);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Axtardiginiz element tapilmadi :(");
                    }
                    goto case "5";
                case "5":

                    Console.WriteLine("Butun elementleri silmek isteyirsiniz? H/Y");
                    string clrword = Convert.ToString(Console.ReadLine());
                    if (clrword.ToUpper() == "H")
                    {
                        ntb.Clear();
                        Console.WriteLine("Butun elementler silindi!");

                    }
                    else if (clrword.ToUpper() == "Y")
                    {
                        goto case "6";
                    }
                    else
                    {
                        Console.WriteLine("Silmek istediyiniz elementi yazin.");
                        if (ntb.ContainsValue(clrword))
                        {
                            ntb.Remove(clrword);
                            Console.WriteLine("Element silindi!");
                        }
                        else
                        {
                            Console.WriteLine("Silmek istediyiniz element sistemde yoxdur");
                        }
                    }


                    break;
                case "6":
                    Console.WriteLine("Menyudan cixmaq ucun enter duymesine sixin");
                    break;
            }
            #endregion
        }
    }
}
