using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Market_Program
{
    internal class PasswordHasher
    {
        private const int SaltSize = 16;
        private const int Iterations = 10000;

        public static string HashPassword(string password)
        {
            byte[] salt = GenerateSalt();
            byte[] hashedBytes = HashWithSalt(Encoding.UTF8.GetBytes(password), salt, Iterations);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Convert.ToBase64String(salt));
            stringBuilder.Append(":");
            stringBuilder.Append(Convert.ToBase64String(hashedBytes));

            return stringBuilder.ToString();
        }

        public static bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            string[] parts = hashedPassword.Split(':');
            if (parts.Length != 2)
            {
                return false;
            }

            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] hashedBytes = HashWithSalt(Encoding.UTF8.GetBytes(inputPassword), salt, Iterations);

            return parts[1] == Convert.ToBase64String(hashedBytes);
        }

        private static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[SaltSize];
                rng.GetBytes(salt);
                return salt;
            }
        }

        private static byte[] HashWithSalt(byte[] inputBytes, byte[] salt, int iterations)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(inputBytes, salt, iterations))
            {
                return pbkdf2.GetBytes(32);
            }
        }
    }
}
