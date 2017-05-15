using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Rectangle
    {
        double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            double S = side1 * side2;
            return S;
        }

        public double PerimetrCalculator()
        {
            double P = (side1 + side2) * 2;
            return P;
        }

        public double Area { get { return AreaCalculator(); } }
        public double Perimetr { get { return PerimetrCalculator(); } }
    }
}
