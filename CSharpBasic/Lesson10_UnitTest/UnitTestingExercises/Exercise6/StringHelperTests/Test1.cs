using Exercise6;

namespace StringHelperTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringHelper helper = new StringHelper();
            string text = "Hello, World!";

            string result = helper.RemoveVowels(text);

            Assert.AreEqual("Hll, Wrld!", result);
        }
    }
}
