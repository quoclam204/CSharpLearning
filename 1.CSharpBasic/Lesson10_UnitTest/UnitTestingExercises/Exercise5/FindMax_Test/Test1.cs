using Exercise5;

namespace FindMax_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FindMax maxNumber = new FindMax();
            int[] arr = { 1, 2, 3, 4, 5 };
            int expected = 5;

            int result = maxNumber.MaxNumber(arr);

            Assert.AreEqual(expected, result, 0.001);

        }
    }
}
