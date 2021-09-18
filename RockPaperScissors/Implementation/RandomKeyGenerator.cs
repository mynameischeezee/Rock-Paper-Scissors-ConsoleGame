using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RandomKeyGenerator
    {
        public string Generate()
        {
            byte[] key = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetNonZeroBytes(key);
            }
            return BitConverter.ToString(key).Replace("-", "");
        }

    }
}
