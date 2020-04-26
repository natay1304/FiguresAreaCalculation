using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(4, 3, 6);
            var calculateArea = new CalculateArea(triangle);
            calculateArea.CalculateAreaOfFigure();

            var circle = new Circle(5);
            calculateArea.SetStragedy(circle);
            calculateArea.CalculateAreaOfFigure();
        }
    }
}
