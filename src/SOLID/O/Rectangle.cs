using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.SOLID.O
{
    public class Rectangle : Shape
    {
        public double Length;
        public double Width;

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }
}
