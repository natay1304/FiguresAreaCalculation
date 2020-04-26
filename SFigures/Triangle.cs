using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFigures
{
    public class Triangle : IAreaCalculate
    {
        private double side1, side2, side3;

        public Triangle(double side1, double side2, double side3)
        {
            if(side1 > 0 && side2 > 0 && side3 > 0)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
        }

        public double CalculateArea()
        {
            Console.WriteLine(CheckSquare());
            double area;
            double halfP = (side1 + side2 + side3) / 2;
            Console.Write("Площадь треугольника: ");
            return area = Math.Sqrt(halfP * (halfP - side1) * (halfP - side2) * (halfP - side3));
        }

        private string CheckSquare()
        {
            double a, b, c;
            if (side1 > side2)
                if (side1 > side3)
                {
                    c = side1;
                    a = side2;
                    b = side3;
                }
                else
                {
                    c = side3;
                    a = side1;
                    b = side2;
                }
            else
            {
                c = side3;
                a = side2;
                b = side1;
            }

            if (c * c == (a * a + b * b))
                return "Треугольник прямоугольный";
            else
                return "Треугольник не прямоугольный";
        }
    }
}
