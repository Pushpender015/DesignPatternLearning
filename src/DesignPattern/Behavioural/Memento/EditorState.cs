using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.DesignPattern.Behavioural.Memento
{
    // Memento
    public class EditorState
    {
        private readonly string _title;
        private readonly string _content;

        // state meta data
        private readonly DateTime _StateCreatedAt;

        public EditorState(string title, string content)
        {
            _title = title;
            _content = content;
            _StateCreatedAt = DateTime.Now;
        }

        public string GetTitle()
        {
            return _title; 
        }

        public string GetContent()
        {
            return _content;
        }

        public DateTime GetStateCreatedAt()
        {
            return _StateCreatedAt; 
        }

        public string GetName()
        {
            return $"{_StateCreatedAt} / {_title}";
        }
    }
}
