using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_2
{
    public sealed class Book : IGenericRepostroy<Book>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime CreateDate { get; set; }
        public int Page { get; set; }

        public void Add(Book data)
        {
            data.Page = 200;
        }
        public void UpDate(Book data)
        {
            data.CreateDate = new DateTime(2007,12,20);
        }
        public void Delete(Book data)
        {
            data.Author = null;
        }
        public void Get(Book data)
        {
            Console.WriteLine("Id: " + data.Id + "\n" + "Ad: " + data.Name + "\n" +
                  "Muellif: " + data.Author + "\n" + "Yas : " + data.Page + "\n" +
                 "Nesr Tarixi: " + data.CreateDate);
        }


    }
}
