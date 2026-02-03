using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.SOLID.L
{
    public class Sqaure : Shape
    {
        public double sideLength { get; set; }

        public override double Area =>  sideLength * sideLength;
    }
}
