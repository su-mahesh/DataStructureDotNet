using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Queue
    {
        LinkedList linkedList;

        public Queue()
        {
            linkedList = new LinkedList();
        }

        public void Enqueue(Node node)
        {
            linkedList.AppendNode(node);
        }

        public void DisplayQueue()
        {
            Console.WriteLine("Queue:");
            linkedList.DisplayLinkedList();
        }

        public Node Top()
        {
            return linkedList.Head;
        }

        public Node Dequeue()
        {
            return linkedList.Pop();
        }
    }
}
