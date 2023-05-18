using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Student
    {
        //Ortalama qiymeti almag ucun yazdigim method.
        double result;
        public double calcAverage(double a1, double a2, double a3)
        {
            result = (a1 + a2 + a3) / 3;
            return result;

        }

        //Ad soyadi almag ucun yazdigim Overload method.
        public string calcAverage(string name, string surname)
        {
            return name + surname;
        }

        //Qiymetin deyerlendirilmesi ucun yazdigim method.
        public void rateAverage()
        {
            if (result > 45)
            {
                Console.WriteLine("Telebe imtahandan kecib!");
            }
            else
            {
                Console.WriteLine("Telebe imtahandan kesilib!");
            }
        }
    }
}
