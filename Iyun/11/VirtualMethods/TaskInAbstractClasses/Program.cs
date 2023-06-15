using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInAbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Banan banan = new Banan();
            banan.Name = "Banan";
            banan.Color = "Yellow";
            banan.InThisCountry();

            Apple apple = new Apple();
            apple.Name = "Alma";
            apple.Color = "Qirmizi";
            apple.InThisCountry();

            Avakado avakado = new Avakado();
            avakado.Name = "Avakado";
            avakado.Color = "Yasil";
            avakado.InThisCountry();
        }
    }
}
