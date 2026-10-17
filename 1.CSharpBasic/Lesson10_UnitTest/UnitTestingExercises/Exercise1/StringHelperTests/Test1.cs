using Exercise1;

namespace StringHelperTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void GetLength_Hello_Returns5()
        {
            // Chuẩn bị dữ liệu
            StringHelper helper = new StringHelper();
            string text = "QuocLam";
            int expected = 8;

            // Thực hiện hành động
            int actual = helper.GetLength(text);

            // So sánh kết quả mong đợi và kết quả thực tế
            Assert.AreEqual(expected, actual);
        }
    }
}