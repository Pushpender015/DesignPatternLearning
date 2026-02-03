using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.OopsPrinciples.Polymorphism
{
    public class Motercycle : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Motercycle starting...");
        }

        public override void Stop()
        {
            Console.WriteLine("Motercycle stopping...");
        }
    }
}
