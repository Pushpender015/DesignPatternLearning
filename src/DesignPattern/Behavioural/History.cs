using DesignPatternLearning.src.DesignPattern.Behavioural.Memento;

namespace DesignPatternLearning.src.DesignPattern.Behavioural
{
    public class History
    {
        private List<EditorState> _States = new List<EditorState>();

        private Editor _editor;

        public History(Editor editor)
        {
            _editor = editor;
        }

        public void Backup()
        {
            _States.Add(_editor.CreateState());
        }

        public void Undo()
        {
            if (_States.Count == 0)
                return;

            EditorState prevState = _States.Last();
            _States.Remove(prevState);

            _editor.Restore(prevState);
        }

        public void ShowHistory()
        {
            Console.WriteLine("\nHistory: Here's the list of Mementos:");

            foreach (var state in _States)
            {
                Console.WriteLine(state.GetName());
            }
        }

    }
}
