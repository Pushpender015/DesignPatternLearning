using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.DesignPattern.Behavioural.State.GoodSolution
{
    public class DraftState : State
    {
        private Document _document;

        public DraftState(Document document)
        {
            _document = document;
        }

        public void publish()
        {
            _document.State = new ModerationState(_document);
        }
    }
}
