namespace Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = 5;

            int tangSau = test1++;
            Console.WriteLine(tangSau); // i++ là tăng sau -> gán trước xong rồi mới tăng

            var test2 = 5;
            int tangTruoc = ++test2;
            Console.WriteLine(tangTruoc); // ++i là tăng trước -> tăng giá trị lên xong rồi mới gán

            Console.WriteLine("-----------------------------------------------------------");

            char test = 'c';
            var result = test - 10;
            Console.WriteLine(result); // Kết quả là 53 vì 'c' có giá trị ASCII là 99, trừ đi 10 sẽ ra 89, và 89 là ký tự 'Y' trong bảng ASCII

        }
    }
}
