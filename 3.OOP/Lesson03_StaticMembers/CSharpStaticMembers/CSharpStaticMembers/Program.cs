namespace CSharpStaticMembers
{
    internal class Program //: A
    {
        static void Main(string[] args)
        {
            User user = new User("quoclam2004", "12345");

            Console.WriteLine($"Username: {user.UserName}");
            Console.WriteLine($"Salt: {user.Salt}");
            Console.WriteLine($"Password Hash: {user.PassWordHash}");

            // Kiểm tra mật khẩu có đúng không
            bool result = user.VerifyPassword("12345");
            Console.WriteLine(result);

            // tạo ra 1 static class sau đó định nghĩa 1 method. trong method đó in ra câu hello static!
            CSharpStaticMembers.MyStaticClass();
        }
    }
}
