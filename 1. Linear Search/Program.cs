using System;

namespace _1._Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            // Това е най-простия и най-интуитивен начин да търсим

            // Искаме да си направим метода Contains, на който му даваме масив и число, което да проверява дали дали този масив го има или не и да ни връща bool

            var arr = new int[] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(Contains(arr, 5));
            Console.WriteLine(Contains(arr, 7));
        }

        public static bool Contains(int[] arr, int searchEl)
        {
            foreach (var el in arr)
            {
                if (el == searchEl)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
