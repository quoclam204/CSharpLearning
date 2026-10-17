using Exercise8;

namespace FilterEvenTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void GetEvenNumbers_WithIntegerArray_ReturnsOnlyEvenNumbers()
        {
            FilterEven filterEven = new FilterEven();
            int[] arrNumbers = { 2, 3, 4, 5, 2 };
            int[] expected = { 2, 4, 2 };

            int[] result = filterEven.GetEvenNumbers(arrNumbers);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
