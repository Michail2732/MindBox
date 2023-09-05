using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public int Radius { get; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double CalcArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
