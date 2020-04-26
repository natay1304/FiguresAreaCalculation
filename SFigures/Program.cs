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
            Triangle triangle = new Triangle(4, 3, 5);
            Console.WriteLine(triangle.CalculateArea());
        }
    }
}
