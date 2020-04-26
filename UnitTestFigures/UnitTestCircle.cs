using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFigures
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void CalculateAreaWithNegativeRadius()
        {
            var circle = new SFigures.Circle(-5);

            Assert.AreEqual(0, circle.CalculateArea());
        }

        [TestMethod]
        public void CalculateRightArea()
        {
            var circle = new SFigures.Circle(1);
            Assert.AreEqual(Math.PI, circle.CalculateArea());
        }
    }
}
