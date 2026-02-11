using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.DesignPattern.Behavioural.Iterator
{
    public class ShoppingList
    {
        private List<string> _list = new List<string>();

        public void Push(string itemName)
        {
            _list.Add(itemName);
        }

        public string Pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last; 
        }

        public List<string> GetList()
        {
            return _list; 
        }

        private class ListIterator : IItrator<string>
        {
            public string Currrent()
            {
                throw new NotImplementedException();
            }

            public bool HasNext()
            {
                throw new NotImplementedException();
            }

            public void Next()
            {
                throw new NotImplementedException();
            }
        }
    }
}
