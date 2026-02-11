using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.DesignPattern.Behavioural.Command
{
    public class Light
    {
        public void TurnOn()
        {
            Console.WriteLine("Light is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light is off");
        }
    }
}
