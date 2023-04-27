using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework1           
            ////Implicit convention
            //int intDataT = 20;
            //float implicitFloat = intDataT;

            //byte byteDataT = 250;
            //int implicitByte = byteDataT;

            //short shortDataT = 100;
            //long implicitShort = shortDataT;

            //char charDataT = 'A';//Unicode value reqem oldugu ucun long tipine implicit etmek mumkundur.
            //long implicitChar = charDataT;

            //float floatDataT = 223.44f;
            //double implicitDouble = floatDataT;


            ////Explicit Convention
            //byte byteDataTNext = 233;
            //sbyte explicitSbyte = (sbyte)byteDataTNext;

            //float floatDataTNext = 74832;
            //int explicitInt = (int)floatDataTNext;

            //char charDataTNext = 's';
            //string explicitStr = charDataTNext.ToString();

            //bool boolDataT = true;
            //string explicitStrNext = boolDataT.ToString();

            //long longDataT = 400223334441103;
            //int explicitIntNextOne = (int)longDataT;

            ////Helper Class Conversion

            //string stringToInt = "4566";
            //int inInt = Convert.ToInt32(stringToInt);

            //bool boolToString = true;
            //string inString = Convert.ToString(boolToString);
            //sbyte sbyteToSbyte = Convert.ToSByte("20");
            //DateTime toDateTime = Convert.ToDateTime("2012.12.12");
            //ulong toUlong = Convert.ToUInt64("921392312");

            #endregion

            #region Homework2
            //// Bir dənə anket proqramı yığacaqsınız.İstifadəçidən onun haqqında məlumatları toplayacaqsınız.Bu məlumatlar ad, soyad, cins, doğum tarixi,
            //// yaşadığı ölkə, yaşadığı şəhər, boy, çəki, maaş olacaq.Siz bu məlumatları saxlamaq üçün doğru bir data type seçməlisiniz.

            //Console.OutputEncoding = Encoding.Unicode;
            //Console.InputEncoding = Encoding.Unicode;


            //Console.Write("Adinizi daxil edin : ");
            //string name = Console.ReadLine();

            //Console.Write("Soyad daxil edin : ");
            //string surname = Console.ReadLine();

            //Console.Write("Cins K/Q: ");
            //char gender = Convert.ToChar(Console.ReadLine());


            //Console.Write("Doğum tarixi (yyyy,mm,dd):");
            //DateTime dateT = Convert.ToDateTime(Console.ReadLine());
            

            //Console.Write("Yasadığı ölkə:");
            //string country = Console.ReadLine();


            //Console.Write("Yaşadığı şəhər:");
            //string city = Console.ReadLine();


            //Console.Write("Boy:");
            //double height = Convert.ToDouble(Console.ReadLine());
            
            

            //Console.Write("çəki:");
            //double Weight = Convert.ToDouble(Console.ReadLine());
            

            //;
            //Console.Write("Maaş:");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());



            #endregion

            #region Homework3 
            /* İstifadəçidən yaşını, maaşını, boyunu, çəkisini və neçə dostu olduğunu soruşacaqsınız.Daxil etdiyi bütün dəyərləri ilk öncə int tipinə convert
               edəcəksiniz.Daha sonra int dəyişənini byte tipinə cast edəcəksiniz(explicit conversion).
               Burada istifadəçi maaşı və yaşı xaricində digər məlumatları byte'ın max dəyərindən çox yazsa heç bir xəta çıxmasın. Maaşını və ya yaşını byte
               tipinin qəbul edəcəyi maksimum dəyərdən çox yazarsa elə edin ki, proqramda xəta çıxsın.*/


            Console.WriteLine("Yaş:");

            int userAgeConvertToInt = Convert.ToInt16(Console.ReadLine());
            
            Console.WriteLine("Maaş:");
            int userSalaryConvertInt = Convert.ToInt32(Console.ReadLine());
            
            checked
            {
                byte userAgeCastToByte = (byte)userAgeConvertToInt;
                byte userSalaryCastToByte = (byte)userSalaryConvertInt;
            }


            Console.WriteLine("Boy:");
            int userHeightConvertInt = Convert.ToInt32(Console.ReadLine());
            byte userHeightCastToByte = (byte)userHeightConvertInt;
            


            Console.WriteLine("Çəki :");
            int userWeightConvertToInt = Convert.ToInt16(Console.ReadLine());
            byte userWeightCastToByte = (byte)userWeightConvertToInt;
            

            Console.WriteLine("Neçə dostunuz var ? :");
            int userFriendsConvertToInt = Convert.ToInt16(Console.ReadLine());
            byte userFriendsCastToByte = (byte)userFriendsConvertToInt;
         
            Console.ReadLine();


            #endregion

            #region Homework4

            //Aşağıdakı dəyərləri düzgün tiplərdə dəyişənlər yaradıb saxlayın:
            string strWhether = "Hava gözəldir. ";
            char chrPercent = '%';
            double dblSixteenDgt = 9999999999999999;
            bool truBool = true;
            bool flsBool = false;
            char chrZero = '0';
            sbyte sbytZero = 0;
            byte bytT = 150;
            double dblT = -111111111115615;
            decimal dcmlT = 15.2M;
            float fltT = 15.2F;
            DateTime nwDtTime = new DateTime(2020, 12, 12);
            #endregion

            #region Homework5
            //Global və Local dəyişən fərqlərini skoplarla izah edə biləcəyiniz bir kod nümunəsi hazırlayın.

            int gloabalVariable = 98;//Global variable
            string myName = "Qlobal variable";//Global variable
            char chrGlobal = '#';//Global variable

            {
                int localVariable = 20;//Local variable
                Console.WriteLine(localVariable);
                Console.WriteLine(myName);
            }
            {
                Console.WriteLine(gloabalVariable);

            }
            {
                string exlicitCharVar = chrGlobal.ToString();
            }
            #endregion
        }
    }
}
