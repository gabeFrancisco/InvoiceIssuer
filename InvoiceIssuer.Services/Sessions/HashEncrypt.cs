using System;
using System.Security.Cryptography;
using System.Text;

namespace InvoiceIssuer.Services.Sessions
{
    public class HashEncrypt
    {
        public static string GenerateHash(string typedPassword)
        {
            SHA512 algorith = SHA512.Create();

            if (string.IsNullOrEmpty(typedPassword))
                throw new NullReferenceException("You must type your password!");

            byte[] inputBytes = Encoding.UTF8.GetBytes(typedPassword);
            byte[] hash = algorith.ComputeHash(inputBytes);

            StringBuilder builder = new StringBuilder();
            foreach (var character in hash)
            {
                builder.Append(character.ToString("x2"));
            }

            return builder.ToString();
        }
    }
}