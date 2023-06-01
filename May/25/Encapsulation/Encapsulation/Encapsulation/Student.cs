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
                this.name = value;
                if (name != value)
                {
                    this.email = null;
                    this.surname = null;
                    this.Surname = null;
                }
                else
                {
                    
                    this.email = "ramin@mail.ru";
                }
              }
            get { return name; }
        }
          
          public string Surname
          {           
              set
              {
                this.surname = value;

                if (surname != value)
                  {
                    this.email = null;
                     this.name = null;
                    this.Surname = value;
                }
                {
                    
                    this.email = "ramin@mail.ru";
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
