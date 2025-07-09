using Assignment12._2;

namespace Assignment12._2Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ListNode test = new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));
            var expected = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))).ToList();
            var result = Program.RemoveElements(test, 6).ToList();
            Assert.IsTrue(expected.SequenceEqual(result), "The list after removing elements with value 6 does not match the expected result.");
        }

        [TestMethod]
        public void TestMethod2()
        {
            ListNode test = null;
            var result = Program.RemoveElements(test, 6);
            Assert.IsNull(result, "The result should be null when the input list is null.");
        }

        [TestMethod]
        public void TestMethod3()
        {
            ListNode test = new ListNode(7, new ListNode(7, new ListNode(7, new ListNode(7))));
            var result = Program.RemoveElements(test, 7);
            Assert.IsNull(result, "The result should be null when all elements are removed.");
        }
    }
}
