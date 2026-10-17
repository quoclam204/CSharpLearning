using Exercise10;

namespace ReverseStringTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ReverseString reverseString = new ReverseString();
            string expected = "olleh";

            string result = reverseString.Reverse("hello");

            Assert.AreEqual(expected, result);
        }
    }
}
