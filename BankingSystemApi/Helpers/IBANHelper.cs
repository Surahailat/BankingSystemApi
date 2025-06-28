using System.Security.Cryptography;
using System.Text;

namespace BankingSystemApi.Helpers
{
    public static class IBANHelper
    {
        private static readonly string EncryptionKey = "ThisIsASampleKey123!";

        public static string Encrypt(string plainText)
        {
            using var aes = Aes.Create();
            var key = new Rfc2898DeriveBytes(EncryptionKey, Encoding.UTF8.GetBytes("Salt1234")).GetBytes(32);
            aes.Key = key;
            aes.GenerateIV();

            using var encryptor = aes.CreateEncryptor();
            var plainBytes = Encoding.UTF8.GetBytes(plainText);
            var encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

            var result = aes.IV.Concat(encryptedBytes).ToArray();
            return Convert.ToBase64String(result);
        }

        public static string Hash(string input)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(input);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static string Mask(string iban)
        {
            if (iban.Length < 4)
                return "****";

            var last4 = iban[^4..];
            return $"**** **** **** {last4}";
        }
    }
}
