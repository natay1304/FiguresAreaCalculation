using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFigures
{
    public class CalculateArea
    {
        private IAreaCalculate areaCalculate;
        public CalculateArea(IAreaCalculate areaCalculate)
        {
            this.areaCalculate = areaCalculate;
        }

        public void SetStragedy(IAreaCalculate areaCalculate)
        {
            this.areaCalculate = areaCalculate;
        }

        public void CalculateAreaOfFigure()
        {
            Console.WriteLine(areaCalculate.CalculateArea());
        }
    }
}
