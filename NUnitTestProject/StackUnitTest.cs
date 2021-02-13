using System;
using System.Collections.Generic;
using System.Text;
using DataStructure;
using NUnit.Framework;

namespace NUnitTestProject
{
    class StackUnitTest
    {
        Stack stack;
        [SetUp]
        public void Setup()
        {
            stack = new Stack();
        }

        [Test]
        public void GivenNodes_WhenAddedToStack_ShouldPassStackTest()
        {
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);

            Node Top = stack.Top();

            Assert.AreEqual(node3, Top);
        }

        [Test]
        public void GivenNodes_WhenPoppedTilEmpty_ShouldPassStackTest()
        {
            Node node1 = new Node(70);
            Node node2 = new Node(30);
            Node node3 = new Node(56);

            stack.Push(node1);
            stack.Push(node2);
            stack.Push(node3);

            stack.Pop();
            stack.Pop();
            stack.Pop();
            Node result = stack.Top();

            Assert.IsNull(result);
        }
    }
}
