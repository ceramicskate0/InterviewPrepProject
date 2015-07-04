using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterviewPrep
{    
    /// <summary>
        /// Defines what a node in the tree or struct is
        /// </summary>
        /// <typeparam name="T">Data Type Def</typeparam>
    public class Node <T>
    {
            public Node<T> Parent { get; set; }
            public Node<T> Left { get; set; }
            public Node<T> Right { get; set; }
            public T Value
            {
                get;
                set;
            }
            /// <summary>
            /// Tracvks if the node has been visted in the search your running
            /// </summary>
            public bool Visited = false;
            /// <summary>
            /// number assigned to each node as its created to track which node it was when it was created
            /// </summary>
            public int NodeNumber { get; set; }
    }
}
