using System.Text;

namespace ExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cấu hình để hiển thị tiếng Việt khi xuất ra màn hình (Console.WriteLine)
            Console.OutputEncoding = Encoding.UTF8;

            // Cấu hình để nhận tiếng Việt khi nhập từ bàn phím (Console.ReadLine)

            Console.InputEncoding = Encoding.UTF8;
            try 
            {
                int a = 10, b = 0;

                int result = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Đã bắt được lỗi");

                throw;
            }
            finally
            {
                Console.WriteLine("Khối finally được thực thi");
            }
        }
    }
}
