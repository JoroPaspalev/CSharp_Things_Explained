using System;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задължително условие е да са подредени елементите в колекцията иначе няма как да работи
            // Той разделя на две и на две и на две, докато намери търсения елемент                       
            var arr = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };

            var searchEl = 61;
            var missingEl = 62;

            Console.WriteLine(BinarySearch(arr, searchEl));
            Console.WriteLine(BinarySearch(arr, missingEl));
        }

        public static bool BinarySearch(int[] arr, int searchEl)
        {
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex <= endIndex)
            {
                var middleIndex = (startIndex + endIndex) / 2;
                var currEl = arr[middleIndex];

                if (searchEl == currEl)
                {
                    return true;
                }

                if (searchEl < currEl)
                {
                    // тогава смени endIndex на middleIndex минус една позиция назад от текущата, защото тя вече е проверена за съвпадение
                    endIndex = middleIndex - 1;
                }

                if (searchEl > currEl)
                {
                    startIndex = middleIndex + 1;
                }
            }

            return false;
        }
    }
}
