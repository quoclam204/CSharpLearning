using FileAnalysis;

namespace FileAnalysisTest
{
    [TestClass]
    public sealed class FileAnalyzerTests
    {
        [TestMethod]
        public void CountCharacter_ShouldReturnCorrectCount()
        {
            FileAnalyzer analysis = new FileAnalyzer();
            int expected = 8;
            string text = "Quoc Lam";

            int actual = analysis.CountCharacter(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountLines_ShouldReturnCorrectCount()
        {
            FileAnalyzer analysis = new FileAnalyzer();
            int expected = 4;
            string text = "Nguyen\n Le\n Quoc\n Lam";

            int actual = analysis.CountLines(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountWords_ShouldReturnCorrectCount()
        {
            FileAnalyzer analysis = new FileAnalyzer();
            int expected = 4;
            string text = "Nguyen\n Lê\t Quốc Lâm";

            int actual = analysis.CountWords(text);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AverageWordLength_ShouldReturnCorrectAverage()
        {
            FileAnalyzer analysis = new FileAnalyzer();
            double expected = 3.75;
            string text = "Nguyễn\n Lê\t Quốc Lâm";

            double actual = analysis.AverageWordLength(text);

            Assert.AreEqual(expected, actual, 0.001);
        }

        // Test thêm các tình huống khác

        // Kiểm tra chuỗi rỗng khi đếm số ký tự
        [TestMethod]
        public void CountCharacter_ShouldReturnZeroForEmptyString()
        {
            FileAnalyzer analysis = new FileAnalyzer();

            int expected = 0;
            string text = "";

            int actual = analysis.CountCharacter(text);

            Assert.AreEqual(expected, actual);
        }

        // Kiểm tra chuỗi 1 dòng
        [TestMethod]
        public void CountLines_ShouldReturnOneForSingleLine()
        {
            FileAnalyzer analysis = new FileAnalyzer();

            int expected = 1;
            string text = "Hello";

            int actual = analysis.CountLines(text);

            Assert.AreEqual(expected, actual);
        }

        // Kiểm tra chuỗi không có từ
        [TestMethod]
        public void CountWords_ShouldReturnZeroForEmptyString()
        {
            FileAnalyzer analysis = new FileAnalyzer();

            int expected = 0;
            string text = "";

            int actual = analysis.CountWords(text);

            Assert.AreEqual(expected, actual);
        }

        // Kiểm tra độ dài trung bình khi chuỗi rỗng
        [TestMethod]
        public void AverageWordLength_ShouldReturnZeroForEmptyString()
        {
            FileAnalyzer analysis = new FileAnalyzer();

            double expected = 0;
            string text = "";

            double actual = analysis.AverageWordLength(text);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
