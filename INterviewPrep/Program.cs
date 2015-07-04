using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            ILList<string> SingleLinkedList = new LListTree<string>();

            SingleLinkedList.InsertNode("Root Node");
            SingleLinkedList.InsertNode("Right Child");
            SingleLinkedList.InsertNode("Right Right Child");
            Console.WriteLine(SingleLinkedList.PrintEntireTree());            
            HaltProgram();
        }

        private static void HaltProgram()
        {
            Console.ReadLine();
        }
    }
}
