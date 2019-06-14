using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;

namespace CapaDatos
{
    public class Cryptographic
    {
        /* 
         Es una clase que está usando una libreria Cryptograbhy .NET
         * 1er Metodo.- 
         * Lo que va hacer es generarte un comodin de forma aleatoria que va a permitirte conbinar 
         
         */
        public static byte[] GenerateSalt()
        {
            const int saltLenght = 32;

            using(var randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[saltLenght];
                randomNumberGenerator.GetBytes(randomNumber);
                
                return randomNumber;
            }
        }
        private static byte[] Combine(byte[] first, byte[] second)
        {
            var ret = new byte[first.Length + second.Length];

            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);

            return ret;
        }

        public static byte[] HashPasswordWithSalt(byte [] toBeHashed, byte [] salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var combinedHash = Combine(toBeHashed, salt);

                return sha256.ComputeHash(combinedHash);
            }
        }

       
    }
}
