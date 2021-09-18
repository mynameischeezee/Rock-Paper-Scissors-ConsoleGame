using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class HMACGenerator
    {
        public string Generate(string text, string key)
        {
            using (var hmacsha256 = new HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                return BitConverter.ToString(hmacsha256.ComputeHash(Encoding.UTF8.GetBytes(text))).Replace("-", "");
            }

        }
    }
}
