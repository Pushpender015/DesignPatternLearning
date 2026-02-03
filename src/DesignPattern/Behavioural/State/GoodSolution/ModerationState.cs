using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.DesignPattern.Behavioural.State.GoodSolution
{
    public class ModerationState : State
    {
        private Document _document;

        public ModerationState(Document document)
        {
            _document = document;
        }

        public void publish()
        {
            if(_document.CurrentUserRole == UserRoles.Admin)
            {
                _document.State = new PublishedState(_document);
            }
        }
    }
}
