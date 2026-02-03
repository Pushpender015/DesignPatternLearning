using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.OopsPrinciples.Polymorphism
{
    public class Plane : Vehicle
    {
        public int NoOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine("Car starting...");
        }

        public override void Stop()
        {
            Console.WriteLine("Car stop...");
        }
    }
}
