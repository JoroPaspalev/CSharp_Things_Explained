using System;

namespace Sha512_Hash_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "feelgood";
            string hashedPass = Program.SHA512(password);
            //DA7A634D69ED8EABB1FC8116877EF3C61D68630F0A7B3C04AEB389977272306E5B86A0EBDE8F7F8D4A4DE0545D28CE76B6CB374725F415E3ADC1B2163146EA92

            Console.WriteLine(hashedPass);
        }

        public static string SHA512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
