using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStaticMembers
{
    internal class User
    {
        public string UserName { get; private set; }
        // public string Password { get; private set; } // vì public set sẽ thay đổi mật khẩu tùy ý
        public string PassWordHash { get; private set; }

        public string Salt { get; private set; } 

        public User(string userName, string passWord)
        {
            UserName = userName;
            Salt = GenerateSalt(); // tạo ra chuỗi Salt ngẫu nhiên
            PassWordHash = passWord.HashPassword(Salt);

        }

        // Salt là một chuỗi dữ liệu ngẫu nhiên được thêm vào mật khẩu trước khi hash
        // Tạo Salt riêng cho mỗi User
        public static string GenerateSalt()
        {
            byte[] saltBytes = RandomNumberGenerator.GetBytes(16);
            return Convert.ToBase64String(saltBytes);
        }

        // Kiểm tra mật khẩu
        public bool VerifyPassword(string password)
        {
            return PassWordHash == password.HashPassword(Salt);
        }
    }
}
