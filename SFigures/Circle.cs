using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFigures
{
    class Circle : IAreaCalculate
    {
        private double radius;
        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            Console.WriteLine("Площадь круга:");
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
