using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
           #region Homework1
           /*
             Homework 1:
             Əvvəlcədən iki dəyişəndə username və password saxlayın. 
             Bunlar heç bir zaman dəyişməyəcək şəkildə olsun. 
             Yəni proqramda belə dəyişdirmək mümkün olmasın.
             Sonra istifadəçidən username və password'u daxil etməsini istəyin.
             Əgər istifadəçi doğru məlumatları yazsa ekrana "Sisteme daxil olundu." mesajı çıxsın.
             Yox əgər səhv məlumat daxil etsə, yenidən username və password'u daxil etməsini istəyin. 
             3 dəfə səhv daxil etdikdən sonra "Hesab bloklandi" yazsın.
          */

            Console.Write("Username :");
            var username = Console.ReadLine();

            Console.Write("Password :");
            var password = Console.ReadLine();

            Console.WriteLine("username :" + username);
            Console.WriteLine("password: " + password);

            Console.Clear();

            Console.Write("Username :");
            var enterUsname = Console.ReadLine();

            Console.Write("Password :");
            var enterPassword = Console.ReadLine();
            Console.Clear();

            if (username == enterUsname && password == enterPassword)
            {
                Console.WriteLine("Sisteme daxil olundu");
            }
            else
            {
                Console.WriteLine("Yeniden username ve passwordu daxil edin");
                Console.Write("Username :");
                var wrongName = Console.ReadLine();

                Console.Write("Password :");
                var wrongPassword = Console.ReadLine();
                Console.Clear();

                if (wrongName == username && wrongPassword == password)
                {
                    Console.WriteLine("Sisteme daxil olundu");
                }
                else
                {
                    Console.WriteLine("Diqqet !Eger siz yene username ve passwordu yalnis daxil etseniz," +
                        "hesabiniz bloklanacaq !");
                    Console.Write("Username :");
                    var wrongNameSec = Console.ReadLine();

                    Console.Write("Password :");
                    var wrongPasswordSec = Console.ReadLine();

                    if (wrongNameSec == username && wrongPasswordSec == password)
                    {
                        Console.WriteLine("Sisteme daxil olundu");
                    }
                    else
                    {
                        Console.Write("Hesab bloklandi");
                    }

                }
            }
            Console.ReadLine();
        #endregion

           #region Homework2
        /*
        Homework 2:
        Switch-case ilə sadə kalkulyator app'ı yazacaqsız. 
        İlk öncə istifadəçiyə kiçik menyu çıxardın. Orda edə biləcəyi əməliyyatlar olacaq. 
        Toplama, çıxma, vurma və bölmə. İstifadəçi hansını seçsə həmin case'də ekrana
        nəticəni çıxardacaqsız.Nəticəni göstərəndən sonra aşağıda yenidən ana menyunu göstərəcəksiz. 
        İstifadəçi istədiyi qədər yəni proqramı bağlayana qədər bu döngü halında davam edəcək.
     */
            again:
            Console.WriteLine("Hesablama isleri gore bilersiz:");
            Console.WriteLine("Birinci reqemi daxil edin:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Bir emeliyyat secin (+, - , * , / )");
            char oper = char.Parse(Console.ReadLine());

            Console.WriteLine("ikinci reqemi daxil edin:");
            double b = double.Parse(Console.ReadLine());

            double rslt = 0;

            switch (oper)
            {
                case '+':
                    rslt = a + b;
                    Console.WriteLine("Cavab :" + rslt);


                    goto again;
                case '-':
                    rslt = a - b;
                    Console.WriteLine("Cavab :" + rslt);

                    goto again;
                case '*':
                    rslt = a * b;
                    Console.WriteLine("Cavab :" + rslt);

                    goto again;
                case '/':
                    rslt = a / b;
                    Console.WriteLine("Cavab :" + rslt);

                    goto again;
                default:
                    Console.WriteLine("Bele bir emeliyyat yoxdur");

                    goto again;
            }




#endregion
        }
    }
}
