using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.SOLID.I
{
    public class Circle : IShape2D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
