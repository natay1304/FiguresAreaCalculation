using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFigures
{
    public class Circle : IAreaCalculate
    {
        private double radius;
        
        public Circle(double radius)
        {
            if(radius > 0)
                this.radius = radius;
        }

        public double CalculateArea()
        {
            Console.Write("Площадь круга: ");
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
