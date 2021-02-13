using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class LinkedList
    {
        internal Node Head;
        internal void Add(int Data)
        {
            Node node = new Node(Data);
            if (this.Head == null)
                this.Head = node;
            else
            {
                Node temp = Head;
                while (temp.next != null)
                    temp = temp.next;
                temp.next = node;
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
    }
}
