using System;
using System.Collections.Generic;
using System.Text;

namespace SecurityService.Data.Services.PasswordService
{
    public interface IPasswordService
    {
        byte[] GenerateSalt(int length);
        byte[] GenerateHash(string password, byte[] salt, int iterations, int length);
    }
}
