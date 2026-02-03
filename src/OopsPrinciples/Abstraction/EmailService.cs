using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.OopsPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Console.WriteLine("Send email...");
        }

        public void Connect()
        {
            Console.WriteLine("Connecting to email server...");
        }

        public void Authenticate()
        {
            Console.WriteLine("Authenticatoin successful...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnect form the server...");
        }
    }
}
