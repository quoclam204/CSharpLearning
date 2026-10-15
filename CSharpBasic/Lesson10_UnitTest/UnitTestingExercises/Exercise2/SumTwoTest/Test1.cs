using Exercise2;

namespace SumTwoTest
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SumNumber sum = new SumNumber();
            int expected = 5;

            int sumNumber = sum.Sum(2, 3);

            Assert.AreEqual(expected, sumNumber);
        }
    }
}
