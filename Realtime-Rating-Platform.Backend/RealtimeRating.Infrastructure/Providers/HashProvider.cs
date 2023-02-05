﻿using RealtimeRating.Application.Abstractions;
using System.Security.Cryptography;
using System.Text;

namespace RealtimeRating.Infrastructure.Providers
{
    public class HashProvider : IHashProvider
    {
        public string GetHash(string value)
        {
            const string pepper = "PlatformPepper";
            const int keySize = 64;
            const int iterations = 350000;

            HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

            var hash = Rfc2898DeriveBytes.Pbkdf2
                (
                    Encoding.UTF8.GetBytes(value),
                    new byte[0],
                    iterations,
                    hashAlgorithm,
                    keySize
                );

            return Convert.ToHexString(hash);
        }
    }
}