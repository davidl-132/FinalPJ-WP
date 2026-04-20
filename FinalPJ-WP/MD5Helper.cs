using System;
using System.Security.Cryptography;
using System.Text;

namespace FinalPJ_WP
{
    public static class MD5Helper
    {
        public static string Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2")); 
                return sb.ToString();
            }
        }
    }
}