using System;
using System.Security.Cryptography;
using System.Text;

namespace Core.Helper
{
    public static class CommonHelper
    {
        public static string GenerateSHA1(string plainTextString)
        {
            //create new instance of md5
            var sha1 = SHA1.Create();

            //convert the input text to array of bytes
            var hashData = sha1.ComputeHash(Encoding.Default.GetBytes(plainTextString));

            //create new instance of StringBuilder to save hashed data
            var returnValue = new StringBuilder();

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }

            // return hexadecimal string
            return returnValue.ToString();
        }

        static int RandomNumber(int min, int max)
        {
            var random = new Random();
            return random.Next(min, max);
        }

        static string RandomString(int size, bool lowerCase)
        {
            var builder = new StringBuilder();
            var random = new Random();
            for (var i = 0; i < size; i++)
            {
                var ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public static string RandomPassword(int size = 0)
        {
            var builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
    }
}