using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Stack
    {
        LinkedList linkedList;

        public Stack()
        {
            linkedList = new LinkedList();
        }

        public void Push(Node node)
        {
            linkedList.AddNode(node);
        }

        public void DisplayStack()
        {
            Console.WriteLine("Stack:");
            linkedList.DisplayLinkedList();
        }

        public Node Top()
        {
            return linkedList.Head;
        }

        public Node Pop()
        {
            return linkedList.Pop();
        }
    }
}
