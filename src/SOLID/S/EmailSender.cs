using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.SOLID.S
{
    public class EmailSender
    {
        public void SendEmail(string email , string msg) 
        {
            Console.WriteLine(email + " " + msg);
        }
    }
}
