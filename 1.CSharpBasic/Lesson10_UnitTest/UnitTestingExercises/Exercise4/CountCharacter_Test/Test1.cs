using Exercise4;

namespace CountCharacter_Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            StringHelper helper = new StringHelper();
            string text = "ToiLaLam";
            char character = 'L';
            int cout = 2;

            int countChar = helper.CountCharacter(text, character);

            Assert.AreEqual(2, countChar);
        }
    }
}
