using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.OopsPrinciples.Inheritance
{
    public class Vehicle
    {
        public string Brand { get; set; } = "";
        public string Model { get; set; } = "";
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle stopping...");
        }
    }
}
