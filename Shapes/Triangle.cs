using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle : Shape
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalcArea()
        {
            var p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRectangular
        {
            get
            {
                return (A * A + B * B == C * C) || (A * A + C * C == B * B) || (B * B + C * C == A * A);
            }
        }
    }
}
