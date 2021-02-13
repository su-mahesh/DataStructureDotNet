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

        public Node Pop()
        {
            Node temp = Head;
            if (Head != null)
            {                
                Head = Head.next;
            }           
            return temp;
        }

        public Node PopLast()
        {
            Node TailTemp = Tail;
            if (!IsEmpty())
            {
                Node temp = Head;
                while (temp.next != Tail)
                {
                    temp = temp.next;
                }                
                temp.next = null;
                Tail = temp;               
            }
            return TailTemp;
        }

        public bool IsEmpty()
        {
            return Head == null && Tail == null;
        }

        public bool IsNodePresent(Node SearchNode)
        {
            Node temp = Head;
            while (temp != Tail)
            {
                if (temp.data.Equals(SearchNode.data))
                    return true;
                temp = temp.next;
            }
            return false;
        }

        public bool DeleteNode(Node DeleteNode)
        {
            
            Node temp = Head;
            if (!IsEmpty())
            {
                if (DeleteNode.data.Equals(Head.data))
                {
                    Pop();
                    return true;
                }
                if (DeleteNode.data.Equals(Tail.data))
                {
                    PopLast();
                    return true;
                }
                while (temp != null)
                {
                    if (temp.next != null && temp.next.data.Equals(DeleteNode.data))
                    {
                        temp.next = DeleteNode.next;
                        return true;
                    }
                    temp = temp.next;
                }
            }             
            return false;
        }

        public int GetSize()
        {
            int size = 0;
            Node temp = Head;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }

            return size;
        }
    }
}
