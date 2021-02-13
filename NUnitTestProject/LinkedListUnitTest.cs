using System;
using DataStructure;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        LinkedList List;
        [SetUp]
        public void Setup()
        {
            List = new LinkedList();
        }

        [Test]
        public void GivenNodes_WhenAddedToSimpleList_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            node1.next = node2;
            node2.next = node3;

            bool result = node1.next.Equals(node2) &&
                          node2.next.Equals(node3) &&
                          node3.next == null;
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenNodes_WhenAdded_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(70);
            List.AddNode(node1);
            Node node2 = new Node(30);
            List.AddNode(node2);
            Node node3 = new Node(56);
            List.AddNode(node3);

            bool result = List.Head.Equals(node3) &&
                          List.Head.next.Equals(node2) &&
                          List.Tail.Equals(node1);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenNodes_WhenAppended_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            List.AppendNode(node1);
            List.AppendNode(node2);
            List.AppendNode(node3);

            bool result = List.Head.Equals(node1) &&
                          List.Head.next.Equals(node2) &&
                          List.Tail.Equals(node3);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenNodes_WhenInsertedInBetween_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            List.AddNode(node2);
            List.AddNode(node1);
            List.AppendNode(node3);

            bool result = List.Head.Equals(node1) &&
                          List.Head.next.Equals(node2) &&
                          List.Tail.Equals(node3);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenNodes_WhenDeletedFirstNode_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            List.AppendNode(node1);
            List.AppendNode(node2);
            List.AppendNode(node3);

            List.Pop();

            bool result = List.Head.Equals(node2) &&
                          List.Head.next.Equals(node3) &&
                          List.Tail.Equals(node3);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenNodes_WhenDeletedLastNode_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            List.AppendNode(node1);
            List.AppendNode(node2);
            List.AppendNode(node3);

            List.PopLast();

            bool result = List.Head.Equals(node1) &&
                          List.Head.next.Equals(node2) &&
                          List.Tail.Equals(node2);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenNodes_WhenSearchedNode_ShouldReturnTrue()
        {
            Node node1 = new Node(56);
            Node SearchNode = new Node(30);
            Node node3 = new Node(70);

            List.AppendNode(node1);
            List.AppendNode(SearchNode);
            List.AppendNode(node3);

            bool result = List.IsNodePresent(SearchNode);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenNodes_WhenInserted_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(70);
            Node node3 = new Node(30);

            List.AppendNode(node1);
            List.AppendNode(node2);
            List.InsertNode(node3, node1);

            bool result = List.Head.Equals(node1) &&
                          List.Head.next.Equals(node3) &&
                          List.Tail.Equals(node2);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenNodes_WhenDeletedSpecificNode_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(40);
            Node node4 = new Node(70);

            List.AppendNode(node1);
            List.AppendNode(node2);
            List.AppendNode(node3);
            List.AppendNode(node4);

            List.DeleteNode(node3);
            int size = List.GetSize();
            Console.WriteLine(size);

            bool result = List.Head.Equals(node1) &&
                          List.Head.next.Equals(node2) &&
                          List.Tail.Equals(node4);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenNodes_WhenAddInSorted_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(40);
            Node node4 = new Node(70);

            List.AddNodeInSort(node1);
            List.AddNodeInSort(node2);
            List.AddNodeInSort(node3);
            List.AddNodeInSort(node4);

            int size = List.GetSize();
            Console.WriteLine(size);

            bool result = List.Head.Equals(node2) &&
                          List.Head.next.Equals(node3) &&
                          List.Tail.Equals(node4);
            Assert.IsTrue(result);
        }
    }
}