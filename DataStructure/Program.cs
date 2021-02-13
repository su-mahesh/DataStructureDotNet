using System;

namespace DataStructure
{
    class Program
    {
        static void Main()
        {
            LinkedList List = new LinkedList();
            Node node1 = new Node(1197);
            Node node2 = new Node(180);
            Node node3 = new Node(170);
            Node node4 = new Node(160);
            Node node5 = new Node(150);
            Node node6 = new Node(140);

            List.AddNodeInSort(node1);
            List.AddNodeInSort(node2);
            List.AddNodeInSort(node3);
            List.AddNodeInSort(node4);
            List.AddNodeInSort(node5);
            List.AddNodeInSort(node6);

            List.Display();
        }
    }
}
