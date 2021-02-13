using DataStructure;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        [Test]
        public void GivenNodes_WhenAdded_ShouldPassLinkedListTest()
        {
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);

            LinkedList List = new LinkedList();
            List.AddNode(node1);
            List.AddNode(node2);
            List.AddNode(node3);
            bool result = List.Head.Equals(node3) &&
                          List.Head.next.Equals(node2) &&
                          List.Tail.Equals(node1);
            Assert.IsTrue(result);
        }
    }
}