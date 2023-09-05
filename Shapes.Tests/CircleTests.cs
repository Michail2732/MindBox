namespace Shapes.Tests
{
    public class CircleTests
    {
        [TestCase(4, Math.PI * 4 * 4)]
        [TestCase(6, Math.PI * 6 * 6)]
        [TestCase(7, Math.PI * 7 * 7)]
        [TestCase(10, Math.PI * 10 * 10)]
        [TestCase(14, Math.PI * 14 * 14)]
        public void CalcArea_Void_Area(int radius, double area)
        {
            var circle = Instance(radius);

            double calcArea = circle.CalcArea();

            Assert.That(area, Is.EqualTo(calcArea));
        }

        private Circle Instance(int radius) => new Circle(radius);
    }
}