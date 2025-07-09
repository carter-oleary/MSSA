using Assignment12._3;
using System.ComponentModel.DataAnnotations;
namespace Assignment12._3Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestEmptyString()
        {
            var testString = "";
            var exp = "";
            var result = Program.RemoveDuplicates(testString);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void TestStringLen1()
        {
            var testString = "a";
            var exp = "a";
            var result = Program.RemoveDuplicates(testString);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void TestNoRemovals()
        {
            var testString = "abcdef";
            var exp = "abcdef";
            var result = Program.RemoveDuplicates(testString);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void TestAllRemovals()
        {
            var testString = "aabbccdd";
            var exp = "";
            var result = Program.RemoveDuplicates(testString);
            Assert.AreEqual(exp, result);
        }

        [TestMethod]
        public void TestNormal()
        {
            var testString = "azxxzy";
            var exp = "ay";
            var result = Program.RemoveDuplicates(testString);
            Assert.AreEqual(exp, result);
        }
    }
}
