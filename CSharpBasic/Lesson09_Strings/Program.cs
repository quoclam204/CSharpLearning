using System.Text;

namespace Lesson09_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Bài tập 1: ");
            // Find the length of a string:

            string message = "Hello, world!";

            Console.WriteLine("Độ dài của chuỗi là: " + message.Length);

            Console.WriteLine("Bài tập 2: ");
            // Convert a string to uppercase:

            Console.WriteLine("Chuỗi sau khi chuyển thành in hoa là: " + message.ToUpper());

            Console.WriteLine("Bài tập 3: ");
            // Convert a string to lowercase:

            Console.WriteLine("Chuỗi sau khi chuyển thành chữ thường là: " + message.ToLower());

            Console.WriteLine("Bài tập 4: ");
            // Trim whitespace from the beginning and end of a string:

            string message2 = " Hello, world! ";

            Console.WriteLine("Chuỗi sau khi loại bỏ khoảng trắng ở đầu và cuối chuỗi là: " + message2.Trim());

            Console.WriteLine("Bài tập 5: ");
            // Concatenate two strings:

            string string1 = "Hello, ";
            string string2 = "world!";
            string srting3 = string1 + string2;

            Console.WriteLine("Chuỗi sau khi được nối là: " + srting3);

            Console.WriteLine("Bài tập 6: ");
            // Get a substring of a string:

            Console.WriteLine("Chuỗi sau khi lấy 1 phần là: " + message.Substring(7));

            Console.WriteLine("Bài tập 7: ");
            // Replace a substring within a string:

            Console.WriteLine("Chuỗi sau khi bị thay thế 1 phần là: " + message.Replace("world!", "you!"));

            Console.WriteLine("Bài tập 8: ");
            // Insert a substring into a string:

            string message3 = "Hello, !";
            Console.WriteLine("Chuỗi sau khi chèn vào là: " + message3.Insert(7, "world"));

            Console.WriteLine("Bài tập 9: ");
            // Split a string into an array of substrings:

            string[] result = message.Split(' ');

            foreach (var item in result)
            {
                Console.Write(item);
            }

            Console.WriteLine("Bài tập 10: ");
            // Split a string into an array of substrings:

            int index = message.IndexOf("world");

            Console.WriteLine("Vị trí của chuỗi world trong chuỗi là: " + index);

            Console.WriteLine("Bài tập 11: ");
            // Find the last index of a substring within a string:

            Console.WriteLine("Phần tử cuối cùng trong mảng là: " + message.LastIndexOf("l"));

            Console.WriteLine("Bài tập 12: ");
            // Check if a string starts with a given substring:

            Console.WriteLine("Kiểm tra trong chuỗi có từ Hello không: " + message.StartsWith("Hello"));

            Console.WriteLine("Bài tập 13: ");
            // Check if a string ends with a given substring:

            Console.WriteLine("Kiểm tra trong chuỗi có kết thúc bằng từ world không: " + message.EndsWith("world!"));

            Console.WriteLine("Bài tập 14: ");
            // Check if a string ends with a given substring:

            Console.WriteLine("Kiểm tra 1 chuỗi có chứa chuỗi con cho trước hay không: " + message.Contains("world"));
        }
    }
}
