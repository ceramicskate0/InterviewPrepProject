using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterviewPrep
{
    interface ILStack<T>
    {
        T Pop(T z);

        void Push(T z);

        void Clear();

        string Print();

        T Top();

        bool isEmpty();
        
    }
}
