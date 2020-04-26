using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFigures
{
    [TestClass]
    class UnitTestTriangle
    {
        [TestMethod]
        public void CalculateAreaWIthNegativeSide()
        {
            var triangle = new SFigures.Triangle(2, 3, -5);
            Assert.AreEqual(0, triangle.CalculateArea());
        }

        [TestMethod]
        public void CalculateRightArea()
        {
            var triangle = new SFigures.Triangle(4, 3, 5);
            Assert.AreEqual(6, triangle.CalculateArea());
        }
    }
}
