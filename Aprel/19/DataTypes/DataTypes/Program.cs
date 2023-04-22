using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework1 (Data types and examples)

            //Ev tapşırığı olaraq ilk növbədə ən az 2-3 saat internetdə "C# data types" (C# veri tipleri) mövzusunu geniş bir şəkildə araşdırırsınız.
            //Araşdıra - araşdıra da bir Console App açıb araşdırdığınız data tiplərindən nümunələr yazırsınız. Hər data type üçün ən az 5 fərqli nümunə yazın.

            //int type
            //max value 2147483647
            // min value -2147483647
            int numberOne = 10;
            int numberTwo = 200;
            int numberThree = -2345;
            int numberFour = 33456;
            int numberFive = -456900;

            //double type(16-17 digit) 64bit
            // max value -1.7976931348623157E+308
            // min value 1.7976931348623157E+308

            double firstDouble = -11 / 4d;
            double secondDouble = 22.5d;
            double thirdDouble = -145.7d;
            double forthDouble = 1234.8d;
            double fifthDouble = 34567.8;

            //float type (7 digit) 32bit
            //max value 3.40282347E+38F
            //min value -3.40282347E+38F

            float firstFloat = -2.123f;
            float secondFloat = 15.5f;
            float thirdFloat = -222.1f;
            float fourthFloat = 4563.89f;
            float fifthFloat = -9876.23f;

            //decimal type (28-29 digit) 128bit
            //max value 79228162514264337593543950335M
            //min value -79228162514264337593543950335M

            decimal firstDecimal = 2.123M;
            decimal secondDecimal = 10.234M;
            decimal thirdDecimal = 452.12345M;
            decimal fourthDecimal = 5783.23466M;
            decimal fifthDecimal = 23456.78943M;

            // short type 2byte (16bit)
            //min value = -32,768 
            //max value = 32,767

            short firstShort = -30921;
            short secondShort = 12345;
            short thirdShort = 23415;
            short fourthShort = 18764;
            short fifthShort = -4352;

            //long type 8byte (64 bit)
            //min value = - 9223372036854775807
            //max value = 9223372036854775808


            long firstLong = 234512;
            long secongLong = -112312;
            long thirdLong = 893212482;
            long fourthLong = -3492345;
            long fifthLong = 9836271;

            //sbyte 1byte (8bit)
            // min value = -128
            // max value = 127

            sbyte firstSbyte = 109;
            sbyte secondSbyte = -110;
            sbyte thirdSbyte = 88;
            sbyte fourthSbyte = -49;
            sbyte fufthSbyte = 98;

            //byte 1byte (8bit);
            //min value = 0;
            //max value =255;

            byte firstByte = 1;
            byte secondByte = 245;
            byte thirdByte = 178;
            byte fourthByte = 54;
            byte fifthByte = 19;

            //bool - 2byte (8bit) true,false

            bool firstBool = false;
            bool secondBool = true;
            bool thirdBool = false;
            bool fourthBool = true;
            bool fifthBool = true;

            //char type 2byte (16bit)
            // ' ' tek dirnaqlar arasinda ve yalmiz tek isareler ve ya herfler qebul edir (hem kicik hem boyuk)
            //min value '\0'
            //max value '\Uffff'
            char firstChar = 'R';
            char secondChar = '8';
            char thirdChar = '=';
            char fourthChar = 'u';
            char fifthChar = '@';

            //dateTime type 8byte(64bit);
            // January 1, 0001 at 12:00:00 -----December 31, 9999,

            DateTime forNow = DateTime.Now;
            int milliSecond = forNow.Millisecond;
            int second_ = forNow.Second;
            int minute_ = forNow.Minute;
            int hour_ = forNow.Hour;
            int day_ = forNow.Day;



            #endregion

            #region HomeWork2 (Variable Name Convention)
            //"C# variable naming convention" (C# değişken isimlendirme kuralları) mövzusunu araşdırırsınız. Araşdırmanızın nəticəsi olaraq, araşdırdığınız
            //adlandırma qaydalarından yola çıxaraq dəyişən adları yazın.
            var variableNamingConvention = "";
            var variable_namimg_convention = "";
            var variableNamingConvention_ = "";
            var VariableNamingConvention = "";
            var firstVariableNamingConvention = "";




            #endregion

            #region  Homework3 (int,bool,char,string,long)


            // int, bool, char, string və long tipində dəyişənlər yaradıb onlara dəyər verirsiniz.Sonra elə bir dəyişən yaratmalısınız ki, bütün bu dəyişənləri
            //  ona dəyər olaraq mənimsədə biləsiniz.

            int intDataType = 20;
            bool boolDataType = true;
            char charDataType = 'R';
            string stringDataType = "Ramin";
            long longDataType = 1245;
            var multiDataTypes = intDataType + " "
                                 + boolDataType + " "
                                 + charDataType + " "
                                 + stringDataType + " "
                                 + longDataType;


            string myString = intDataType.ToString()
                             + boolDataType.ToString()
                             + charDataType.ToString()
                             + stringDataType.ToString()
                             + longDataType.ToString();

            /*
              Not:
              string tipində sən birbaşa saxlaya bilmirsən. intDataType'ı ToString method'u ilə öncə string'ə çevirib
              elə saxlamış olursan. Nəticədə intDataType adlı dəyişənin tipi çevrilib saxlanılır myString'də. Burada
              string myString = intDataType; olmuş olsaydı qəbul olunardı.
             */


            #endregion

            #region Homework4
            //Araşdırdığınız dəyişən tipləri barədə bir yazı hazırlayacaqsız.Hər bir data type'ın nə kimi bir dəyər 
            //aldığını, neçə bit olduğunu və s. araşdırın.

            /*
              C# proqramla dilinde 3 cur data type var .
              1.Value type
              2.Referance type
              3.Pointer type

            1.Value type asagdakilar daxildir;
                 bool - hecmi 1byte(8bit),aldigi deyerler(true,false),
                 byte- hecmi 1 byte(8bit),deyer araligi (0-255),
                 char- hecmi 2byte (16bitdir), yalniz ' ' tek dirnaqlar arasinda yazilir ve tek herf qebul edir boyuk ve balaca ferqi yoxdur.
                 decimal-hecmi 16 byte (128 bit),deyer araligi +79,228,162,514,264,337,593,543,950,335   -79,228,162,514,264,337,593,543,950,335
                 double - 8byte (64bit) , deyer araligi -1.7976931348623157E+308 --- 1.7976931348623157E+308
                 enum -----
                 float --4 byte (32bit) ,aldigi deyer  -3.40282347E+38F --- 3.40282347E+38F
                 int- 4byte(32bit),aldigi deyer  -2,147,483,648 to 2,147,483,647
                 long - 8byte(64bit),aldigi deyer -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
                 sbyte -1byte(8bit),-128 +127
                 short -2byte (16bit),-32,768 to 32,767
                 struct-----
                 uint------
                 ulong-----
                 ushort----
                 datetime -8byte . araliq January 1, 0001 at 12:00:00 -----December 31, 9999

            2.Referance Type:
              1.String
              String data tipi metnleri,isareleri,reqemleri metin seklinde saxlaya bilen data tipidir.Referance
              data tipidir.Stringin bir nece komekci metodlari vardir.
              2.Class----
              3.Array----
              

             
             
            */
            string message = "mesaj";
            string notific = " var";
            string UpperCaseMessage = message.ToUpper();
            string LowerCaseMessage = message.ToLower();
            int messageLength = message.Length;
            int indexOfMessage = message.IndexOf('s');
            string Message = message.Replace('m', 'M');
            string substrMessage = message.Substring(1, 3);
            string joinStrings = string.Concat(message, notific);
            bool checkEndLetter = message.EndsWith("j");
            bool checkFirstLetter = message.StartsWith("m");



            #endregion
        }
    }
}
