using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterviewPrep
{
    interface ILList<T>
    {
        bool InsertNode(T x);

        T DeleteNode(T x);

        string PrintEntireTree();

        void ClearEntireTree();

        bool IsEmptyTree();

        string ViewNodeNumbered(int x);

        T ViewRoot();
    }
}
