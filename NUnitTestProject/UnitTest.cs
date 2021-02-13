using DataStructure;
using NUnit.Framework;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

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
    }
}