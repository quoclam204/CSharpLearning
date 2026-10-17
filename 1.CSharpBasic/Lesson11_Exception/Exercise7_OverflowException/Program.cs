using System.Text;

namespace Exercise7_OverflowException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Cấu hình để hiển thị tiếng Việt khi xuất ra màn hình (Console.WriteLine)
                Console.OutputEncoding = Encoding.UTF8;

                // Cấu hình để nhận tiếng Việt khi nhập từ bàn phím (Console.ReadLine)
                Console.InputEncoding = Encoding.UTF8;
                
                Console.Write("Nhập số a: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Nhập số b: ");
                int b = int.Parse(Console.ReadLine());

                // checked là một từ khóa dùng để bật tính năng kiểm tra lỗi tràn số (overflow) 
                int kq = checked(a + b);

                Console.WriteLine();

                Console.WriteLine($"Kết quả của phép tính: {a} + {b} = {kq}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Result too large");
            }
        }
    }
}
