using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.DesignPattern.Behavioural.Memento
{
    // originator
    public class Editor
    {
        public string Title { get; set; } = "";
        public string Content { get; set; } = "";

        public EditorState CreateState()
        {
            return new EditorState(Title , Content);
        }

        public void Restore(EditorState state)
        {
            Title = state.GetTitle();
            Content = state.GetContent();
        }
    }
}
