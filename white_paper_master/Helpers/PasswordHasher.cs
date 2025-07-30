using System.Security.Cryptography;
using System.Text;

namespace white_paper_master.Helpers
{
    public static class PasswordHasher
    {
        private const string Salt = "QxLUF1bgIAdeQX"; // should match your original Salt

        private static string ComputeSha512Base64(string input)
        {
            using (var sha512 = new SHA512Managed())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(string.Concat(input, Salt));
                byte[] hash = sha512.ComputeHash(bytes);
                return Convert.ToBase64String(hash).ToUpper();  // Base64 + Uppercase
            }
        }

        public static string ConvertUserNamePasswordToSHA512(string userId, string password)
        {
            string hashUser = ComputeSha512Base64(userId.ToUpper());
            string hashPass = ComputeSha512Base64(password);

            string combined = hashUser + hashPass;

            // Repeat hashing N times based on total length
            for (int i = 0; i < password.Length + userId.Length; i++)
            {
                combined = ComputeSha512Base64(combined.ToUpper());
            }

            return combined;  // Final result is already Uppercase Base64
        }
    }
}
