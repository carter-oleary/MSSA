using ChallengeLab10;

namespace ChallengeLab10UnitTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            char exp = 'e';
            Assert.AreEqual(exp, Functions.FindRandomChar("abcd", "beacd"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = [1, 2, 3, 0, 0, 0];
            int[] exp = [1, 2, 2, 3, 5, 6];
            Functions.MergeArrays(nums, 3, [2, 5, 6], 3);
            CollectionAssert.AreEqual(exp, nums);
        }
    }
}
