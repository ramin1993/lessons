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
        
        public double CalcAverage(double a1, double a2, double a3)
        {
            double result;
            result = (a1 + a2 + a3) / 3;
            return result;

        }

        //Ad soyadi almag ucun yazdigim Overload method.
        public string CalcAverage(string name, string surname)
        {
            return name + surname;
        }

        //Qiymetin deyerlendirilmesi ucun yazdigim method.
        public void RateAverage(double pointAvrg)
        {
            if (pointAvrg > 45)
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
