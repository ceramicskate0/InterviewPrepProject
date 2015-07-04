using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterviewPrep
{
    public class LListTree <T> : ILList<T>
    {
        private Node<T> rootElem = null;

        /// <summary>
        /// Add new nodes into the linked list of nodes
        /// </summary>
        /// <param name="x"></param>
        /// <returns>true for successful inputs and false for failures to input</returns>
        public bool InsertNode(T x)
        {
            try
            {
                Node<T> node = new Node<T>();//new element sent from main
                node.Value = x;
                //Is it Root Node case?
                if (rootElem == null)//no root so one was made
                {
                    node.Parent = null;
                    node.NodeNumber = 0;
                    rootElem = node;
                    return true;//insert worked
                }
                else//not root node
                {
                    Node<T> LocationTrackingNode = rootElem;//place holder for inserting new node 
                    int nodeNum = 1;
                    while (LocationTrackingNode.Right != null)//find next open node on right in list
                    {
                        LocationTrackingNode = LocationTrackingNode.Right;//move right on list
                        nodeNum++;
                    }
                    node.NodeNumber = nodeNum;
                    LocationTrackingNode.Right = node;//make the new node be the end nodes right link
                    node.Left = LocationTrackingNode;//make the new nodes left be the former end of the list
                    return true;//insert worked
                }
            }
            catch
            {
                return false;
            }
        }
     
        public T DeleteNode(T x)
        {
            try
            {
                Node<T> placeHolder = rootElem;
                if (rootElem == null)
                {
                    return default(T);
                }
                else
                {
                    while (x.Equals(placeHolder.Value)==false)
                    {
                        placeHolder = placeHolder.Right;
                    }

                    ReOrderListAfterDelete(placeHolder);       
                }
                return placeHolder.Value;
            }
            catch
            {
                return default(T);
            }
        }

        private void ReOrderListAfterDelete(Node<T> placeHolder)
        {
            if (placeHolder == rootElem)
            {
                rootElem = null;
            }
            else if (placeHolder.Left != null)
            {
                placeHolder.Left.Right = placeHolder.Right;
                if (placeHolder.Right != null)
                {
                    placeHolder.Right.Left = placeHolder.Left;
                }
            }    
        }

        /// <summary>
        /// Show all nodes in the list on the console
        /// </summary>
        /// <returns>strings of node values</returns>
        public string PrintEntireTree()
        {
            try
            {
                if (rootElem != null)
                {
                    Node<T> placeHolder = rootElem;
                    int lineNum = 1;

                    Console.WriteLine("\nThe List collection containes the following elements:\n");
                    Console.WriteLine("0. " + placeHolder.Value);//print root to start

                    while (placeHolder.Right != null)//print every other node but root
                    {
                        placeHolder = placeHolder.Right;
                        Console.WriteLine(lineNum + "." + " " + placeHolder.Value);
                        ++lineNum;
                    }

                    return "-----------------------------END OF LIST-------------------------------------";
                }
                else
                {
                    return "So minor issue, there is not a node in the List =(";
                }
            }
            catch
            {
                return "ERROR getting list";
            }
        }

        public void ClearEntireTree()
        {
            rootElem = null;
        }

        public bool IsEmptyTree()
        {
            if (rootElem==null)
            {
                return true;
            }
            else
            return false;
        }

        /// <summary>
        /// Finds a specfic node based on when it was created with the creation number
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public string ViewNodeNumbered(int x)
        {
            try
            {
                if (rootElem == null)
                {
                    return "No Elements in List";
                }
                else
                {
                    Node<T> placeHolder = rootElem;
                    while (x.Equals(placeHolder.NodeNumber) == false)
                    {
                        placeHolder = placeHolder.Right;
                    }
                    return placeHolder.Value.ToString();
                }
            }
            catch
            {
                return "Error";
            }
        }

        public T ViewRoot()
        {
            if (rootElem!=null)
            {
                return rootElem.Value;
            }
            else
            {
                Node<T> firstElemTemp = new Node<T>();
                return firstElemTemp.Value;
            }
        }
    }
}
