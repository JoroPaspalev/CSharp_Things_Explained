using System;
using System.Security.Cryptography;
using System.Text;

namespace SHA256_Hash_Agorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Sha256("feelgood");
            Console.WriteLine(result); //bafedefe815af32189f08f31f4dcfaa05c86c201a85b556f9b74496869fb67ff
            Console.WriteLine(result.Length);//64
        }

        public static string Sha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
