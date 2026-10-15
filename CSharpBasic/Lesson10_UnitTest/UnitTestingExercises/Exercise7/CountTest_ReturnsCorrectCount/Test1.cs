using Exercise7;

namespace CountTest_ReturnsCorrectCount
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CountTest countTest = new CountTest();
            string[] arr = { "This is a test", "Hello World", "test case", "CSharp" };

            int result = countTest.Count(arr);

            Assert.AreEqual(2, result);
        }
    }
}
