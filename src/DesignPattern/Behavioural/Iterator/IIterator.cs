using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.src.DesignPattern.Behavioural.Iterator
{
    public interface IIterator
    {
        void Next();
        bool HasNext();
        T Current();

    }
}
