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
    }
}
