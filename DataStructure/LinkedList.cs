using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }

        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }

        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked list is empty");
            else
                Console.WriteLine("Linked list:");
            while(temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)                  
                    Console.Write("->");
                temp = temp.next;
            }
        }

        public void AppendNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }

        public void InsertNode(Node NewNode, Node PreviousNode)
        {
            Node temp = Head;
            while(temp != null)
            {
                if (temp.data == PreviousNode.data)
                {
                    NewNode.next = temp.next;
                    temp.next = NewNode;
                    break;
                }
                temp = temp.next;
            }

            if (temp == null)
            {
                Console.WriteLine("node not found");
            }
        }
    }
}
