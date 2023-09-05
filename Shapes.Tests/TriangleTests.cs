using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Tests
{
    public class TriangleTests
    {
        // Треугольники Герона
        [TestCase(3, 4, 5, 6)]
        [TestCase(6, 5, 5, 12)]
        [TestCase(8, 5, 5, 12)]        
        [TestCase(15, 13, 4, 24)]
        [TestCase(13, 12, 5, 30)]
        public void CalcArea_Void_Area(int a, int b, int c, double area)
        {
            var triangle = Instance(a, b, c);

            double calcArea = triangle.CalcArea();

            Assert.That(area, Is.EqualTo(calcArea));
        }

        // Пифагоровы тройки
        [TestCase(3, 4, 5)]
        [TestCase(5, 12, 13)]
        [TestCase(8, 15, 17)]
        [TestCase(7, 24, 25)]
        public void IsRectangular_RectangularTriangle_True(int a, int b, int c)
        {
            var triangle = Instance(a, b, c);

            bool isRectangular = triangle.IsRectangular;

            Assert.That(isRectangular, Is.EqualTo(true));
        }


        [TestCase(5, 6, 7)]
        [TestCase(5, 8, 8)]
        [TestCase(7, 11, 13)]
        [TestCase(8, 3, 6)]
        public void IsRectangular_NotRectangularTriangle_False(int a, int b, int c)
        {
            var triangle = Instance(a, b, c);

            bool isRectangular = triangle.IsRectangular;

            Assert.That(isRectangular, Is.EqualTo(false));
        }


        private Triangle Instance(int a, int b, int c) => new Triangle(a, b, c);
    }
}
