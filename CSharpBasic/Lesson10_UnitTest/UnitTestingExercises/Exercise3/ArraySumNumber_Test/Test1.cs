using Exercise3;

namespace ArraySumNumber_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArraySumNumber arrNumber = new ArraySumNumber();
            int[] arr = { 1, 2, 3, 4, 5 };
            int expected = 15;

            int sumArr = arrNumber.ArrayNumber(arr);

            Assert.AreEqual(expected, sumArr);

        }
    }
}
