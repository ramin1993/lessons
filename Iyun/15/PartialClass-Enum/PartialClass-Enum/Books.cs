using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
   public class Books
    {
        public int counter = 1;

        private int _id;

        public int Id
        {
            get { return this._id; }
            set { _id = value; }
        }

        public Books()
        {
            _id = counter;
            counter++;
        }

        public string Title { get; set; }
        public string Name { get; set; }
        public string Ganre { get; set; }
        public int AuthorId { get; set; }


    }
}
      