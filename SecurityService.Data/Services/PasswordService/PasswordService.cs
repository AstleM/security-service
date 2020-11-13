using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SecurityService.Data.Services.PasswordService
{
    public class PasswordService : IPasswordService
    {
        public byte[] GenerateHash(string password, byte[] salt, int iterations, int length)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                return deriveBytes.GetBytes(length);
            }
        }

        public byte[] GenerateSalt(int length)
        {
            byte[] output = new byte[length];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(output);
            };

            return output;
        }
    }
}
