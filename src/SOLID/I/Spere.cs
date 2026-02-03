using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.SOLID.I
{
    internal class Spere : IShape3D , IShape2D
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
