using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Virtual Methods
            /*
              Virtual methodlar:
              Virtual methodlar bize Base classda "virtual keyword"-nan tanitdigimiz methodlari hemin klassdan 
              miras aldigi classin daxilinde hemin metodu override(ezmeye,methodun bodi hissesin) etmeye imkan verir.
               
            public class VirtualClass{
            public virtual VirtualMethodInBaseClass(string test){
              
              Console.WriteLine("This is Base class" + test);
                }
            }

            public class ChildofVirtualMethodClass :VirtualMethodInBaseClass {
             
              public override VirtualMethodInBaseClass(string test){
                 Console.WriteLine(test + "overriden Method result");  
              }
            }
            

            class Program{
            public void Main (string[] args ){
            ChildofVirtualMethodClass child = new ChildofVirtualMethodClass();
            child.VirtualMethodInBaseClass("This is ");
             }
            }
            //Output:  This us overriden Method result.


            -------------------------------------------------------------------------

            New keyword vasitesi ile base classimizdaki eyni adli methodlari child classda gizlede bilirik.
          
            --------------------------------------------------------------------------------------------

            Normal methodlar (non virtual method) override olmurlar.


            public class NonVirtualMethods
           {
                 public void Text()
                 {
                     Console.WriteLine("Normal methodlar override oluna bilmez!");
                 }
           }

        public class ChildClassOfVirtualMethods : NonVirtualMethods
        {
            public void override Text()
            {
                Console.WriteLine("Text in ChildClassOfVirtualMethods");
            }
        }           
        
        --------------------------------------------------------------------------------------

            virtual methodlari static,private,abstract,override access modifierleri ile islene bilmez.

        ---------------------------------------------------------------------------------------

          Methodlardan basqa propertylerde override ola biler.
          public class Parent{
               public virtual string Name{get;set;}
          }
          public class Child:Parent{
          private string Surname;
          public override string Name {
                set {
                    Surname=value;
                }
                get {
                return Surname + Base.Name
                }
              }
          }



        */

            #endregion

            #region What is Abstract Class
            /*
             Abstraction OOP-nin esas hisslerinden biridir.(Bir methodun ferqli overridelarinin olmasi Polymorpism adlanir.)
             Abstract methodlarin V=irtual methodlardan ferqi ondadirki,Base classinda yazilmis virtual methodun (Body hissesini)
             yaratmaga mecburuq, amma Abstract methodlarda Body hissesini yaza bilmerik,Body hissesini yalniz inherit aldigimiz
             subClass daxilinda yaza bilerik.

            1.Abstract class daxilinda non-abstract ve abstract memberler yaradila biler.
            2.Class yalniz bir abstract classdan inherit (miras) ala biler.
            3.Abstract Object yaratmaq mumkun deyil.
            4.Abstract classlar static,private ve protected ola bilmirler.Onlar yalniz Internal ve public ola bilirler.
            5.Abstract classlarin instance yaradilmir,inherit aldigi subClassinin instance yaradilir.
             */

            #endregion

            MultiOperation calcMulti = new MultiOperation();
            calcMulti.DoCalculation(4, 5);
            MinusOperation calcMin = new MinusOperation();
            calcMin.DoCalculation(100, 32);
            PlusOperation calcPlus = new PlusOperation();
            calcPlus.DoCalculation(10, 23);
            DivideOperation calcDvd = new DivideOperation();
            calcDvd.DoCalculation(10, 0);
            
            
        }



    }
}
