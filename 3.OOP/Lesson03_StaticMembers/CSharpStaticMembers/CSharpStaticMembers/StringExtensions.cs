using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStaticMembers
{
    static internal class StringExtensions
    {
        // Bước 1: Hash bằng SHA-256
        public static string HashPassword(this string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = SHA256.HashData(bytes);

            return Convert.ToHexString(hash);
        }

        // Bước 2: Hash bằng SHA-256 kết hợp Salt
        public static string HashPassword(this string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password + salt);
            byte[] hash = SHA256.HashData(bytes);

            return Convert.ToHexString(hash);
        }
    }
}
