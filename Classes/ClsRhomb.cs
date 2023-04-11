using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFourangleClasses.Classes
{
    internal class ClsRhomb : ClsParallelogram

    {
        private double sideA;

        public void SidesCalculation()
        {
            sideA = Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
            Console.WriteLine("Сторона ромба");
            Console.WriteLine($"Стороная A={Math.Round(sideA, 2)}");
        }
        public double Perimetr()
        {
            return 4 * sideA;
        }
        public double Ploshad()
        {
            double s = 0;
            double p = Perimetr() / 2.0;
            s = Math.Pow(sideA,2) * Math.Sqrt(X1);
            return s;
        }
    }
}
