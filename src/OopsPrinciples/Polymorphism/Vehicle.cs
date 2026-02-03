using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.OopsPrinciples.Polymorphism
{
    public class Vehicle
    {
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        public int Year { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Vehicle starting...");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle stopping...");
        }
    }
}
