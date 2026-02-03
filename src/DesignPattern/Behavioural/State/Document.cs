using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.DesignPattern.Behavioural.State
{
    public class Document
    {
        public DocumentStates State { get; set; }

        public UserRoles CurrentUserRole { get; set; }

        public void Publish()
        {
            if (State == DocumentStates.Draft)
            {
                State = DocumentStates.Moderation;
            }
            else if (State == DocumentStates.Moderation)
            {
                if (CurrentUserRole == UserRoles.Admin)
                {
                    State = DocumentStates.Published;
                }
            }
            else if (State == DocumentStates.Published)
            {
                // do nothing
            }
        }
    }
}
