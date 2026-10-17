using Exercise9;

namespace FilterVowelTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FilterVowel filterVowel = new FilterVowel();
            string[] arr = { "Apple", "Banana", "Orange", "Cat", "Umbrella", "Egg" };
            string[] expected = { "Apple", "Orange", "Umbrella", "Egg" };

            string[] result = filterVowel.GetStringsStartingWithVowel(arr);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
