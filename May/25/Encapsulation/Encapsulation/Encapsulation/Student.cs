using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
   internal class Student
    {
   
          private string name;
          private string surname;
          private string email;
          
        
          public string Name
          {
              
              set
              {
                  name = value;
                  email = "ramin@mail.ru";
              }
            get { return name; }
        }
          
          public string Surname
          {           
              set
              {
                  surname = value;
                  email = value;
                  if (surname != null)
                  {
                     email = "ramin@mail.ru";
                     name = null;                   
                  }
              }
            get { return surname; }
        }
          
          public string Email
          {
              get { return email; }
          }
}



}
