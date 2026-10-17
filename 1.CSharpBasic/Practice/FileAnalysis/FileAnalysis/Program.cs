namespace FileAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the File Analysic Application!\n");

            while (true)
            {
                Console.Write("Please enter the path to the file you would like to analyze: ");
                string? filePath = Console.ReadLine(); // Có thể nhận giá trị null

                // Kiểm tra người dùng có nhập đường dẫn hay chỉ nhấn Enter
                if (string.IsNullOrWhiteSpace(filePath))
                {
                    Console.WriteLine("Please enter a valid path!");
                    continue;
                }

                // Xóa dấu ngoặc kép ("") ở đầu và cuối đường dẫn nếu có
                filePath = filePath.Trim('"');

                try
                {
                    // Kiểm tra file có tồn tại không
                    if (!File.Exists(filePath))
                    {
                        throw new FileNotFoundException();  
                    }

                    // Đọc đường dẫn đã nhập
                    string content = File.ReadAllText(filePath);

                    Console.WriteLine("File analysis complete.\n");

                    FileAnalyzer fileAnalyzer = new FileAnalyzer();

                    Console.WriteLine("Statistics");

                    Console.WriteLine($"Total Characters: {fileAnalyzer.CountCharacter(content)}");
                    Console.WriteLine($"Total Lines: {fileAnalyzer.CountLines(content)}");
                    Console.WriteLine($"Total Words: {fileAnalyzer.CountWords(content)}");
                    Console.WriteLine($"Average Word Length: {fileAnalyzer.AverageWordLength(content)}");

                    break;
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File not found!");
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("You do not have permission to access this file!");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                }
            }    
        }
    }
}
