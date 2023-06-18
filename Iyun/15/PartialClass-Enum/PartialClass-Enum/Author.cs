using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
    public class Author
    {
        public int counter = 0;

        private int _id;

        public int Id
        {
            get { return this._id; }
            set { _id = value; }
        }

        public Author()
        {
            _id = counter;
            counter++;

        }

        public string Name { get; set; }
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }

        public static void Writer()
        {

        }
      
    }
}
