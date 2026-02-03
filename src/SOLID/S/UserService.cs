using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.SOLID.S
{
    public class UserService
    {
        public void Register(User user)
        {
            // register user logic...

            // send email...
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our platform");
        }
    }
}
