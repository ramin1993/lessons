using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
   public sealed class VirtualDataBase:Author
    {
        ArrayList DBarr;
            public VirtualDataBase()
        {
            DBarr = new ArrayList();
        }


        public void AddAuthor(Author author)
        {
            Console.Clear();

            bool addingAuthors = true;
            while (addingAuthors)
            {
                Console.WriteLine("Muellif elave et.");
                string authorName = Console.ReadLine();

                Console.WriteLine("Muellifin yasin elave et");
                string authorAge = Console.ReadLine();
                

                Console.WriteLine("Cinsi daxil et. K/Q");
                string authorGender = Console.ReadLine();
                if (authorGender.ToUpper()=="K" && authorGender.ToUpper() == "Q")
                {
                    author.Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), authorGender);
                }
                

                author = new Author();
                author.Id = DBarr.Count + 1;
                author.Name = authorName;
                author.Age = int.Parse(authorAge);             
                DBarr.Add(author);

                Console.WriteLine("Muellif elave edildi.");

                Console.WriteLine("Yeni muellif elave etmek isteyirsiz? (Y/N)");
                string choice = Console.ReadLine();

                if (choice.ToUpper() != "Y")
                {
                    addingAuthors = false;
                }
            }




        }

        public void ShowAllAuthor(Author author)
        {
            DBarr.Add(author);
            foreach (Author item in DBarr)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void SearchAuthorByName(Author author)
        {
            Console.Clear();
            Console.WriteLine("Muellif adi daxil edin.");
            string searchName = Console.ReadLine();
            bool found = false;
            foreach(Author item in DBarr)
            {
                if (item.Name == searchName)
                {
                    Console.WriteLine(item.Name + " adli muellif tapildi.");
                    found = true;
                    break;
                }
                else if (item.Name == null && !(searchName is string))
                {
                    Console.WriteLine("Bu xanaya Muellif adi daxil edin.");
                }
                if (!found)
                {
                    Console.WriteLine("Axtardiginiz" + " "+ searchName+ " " + "sistemde movcud deil.");
                }

            }
        }

        public void EditAuthor(int id)
        {
            Console.Clear();
            Console.WriteLine("Editlemek istediyiniz muellif adini daxil edin.");
            string searchSameName = Console.ReadLine();
            bool foundAuthor = false;
            foreach(Author author in DBarr)
            {
                if (author.Name == searchSameName)
                {
                    foundAuthor = true;
                    if (author.Id == id)
                    {
                        Console.WriteLine("Muellif adini deyis.");
                        
                        string newName = Console.ReadLine();

                        Console.WriteLine("Muellifin yasini deyis.");

                        int newAge = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Muellif cinsin deyis.");
                        string newGender = Console.ReadLine();
                        author.Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), newGender);

                        author.Age = newAge;
                        author.Name = newName;
                        author.Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum), newGender);

                        Console.WriteLine("Muellif melumatlari yenilendi.");

                    }
                    else
                    {
                        Console.WriteLine("Sistemde bu adda Muellif tapilmadi.");
                    }
                    break;
                }
            }        

        }

        public void AddBooks(Books book,Author author)
        {
            Console.Clear();
            bool addingBooks = true;
            while(addingBooks)
            {
                Console.WriteLine("Elave etmek istediyiniz kitabin adini yazin.");
                string getBookName = Console.ReadLine();

                Console.WriteLine("Elave etmek istediyiniz kitabin janrin yazin.");
                string getBookGanre = Console.ReadLine();

                Console.WriteLine("Elave etmek istediyiniz kitabin muellifin yazin.");
                string getBookAuthor = Console.ReadLine();

                Console.WriteLine("Elave etmek istediyiniz kitabucun basliq yazin.");
                string getBookTitle = Console.ReadLine();

                book = new Books();

                book.Id = DBarr.Count + 1;
                book.AuthorId = author.Id;
                book.Ganre = getBookGanre;
                book.Name = getBookName;
                book.Title = getBookTitle;

                DBarr.Add(book);

                Console.WriteLine("Muellif elave edildi.");

                Console.WriteLine("Yeni kitab elave etmek isteyirsiz? (Y/N)");
                string choice = Console.ReadLine();

                if (choice.ToUpper() != "Y")
                {
                    addingBooks = false;
                }
            }

        }

        public void ShowAllBooks(Books book)
        {
            DBarr.Add(book);
            foreach (Books item in DBarr)
            {
                Console.WriteLine(item.Name);
            }
        }

        public void DeleteAllAuthors(int id)
        {
            Console.Clear();

            Console.WriteLine("Silmek ucun enter duymesine sixin.");

            Console.ReadKey();

            foreach (Author author in DBarr)
            {
                if(author.Id==id)
                DBarr.Remove(author);
            }
            Console.WriteLine("Muellifler silindi.");

        }

        public void DeleteAllBooks(int id)
        {
            Console.Clear();

            Console.WriteLine("Silmek ucun enter duymesine sixin.");

            Console.ReadKey();

            foreach (Books book in DBarr)
            {
                if (book.Id == id)
                    DBarr.Remove(book);
            }
            Console.WriteLine("Kitablar silindi.");
        }
  
    }
}
