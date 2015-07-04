using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterviewPrep
{
    class Stack<T> : ILStack<T>
    {

        ILList<T> Stack = new LListTree<T>();

        public T Pop(T x)
        {
            return Stack.DeleteNode(x);
        }

        public void Push(T x)
        {
            Stack.InsertNode(x);
        }

        public void Clear()
        {
            Stack.ClearEntireTree();
        }

        public string Print()
        {
            return Stack.PrintEntireTree();
        }

        public T Top()
        {
           return Stack.ViewRoot();
        }

        public bool IsEmpty()
        {
            return Stack.IsEmptyTree();
        }
    }
}
