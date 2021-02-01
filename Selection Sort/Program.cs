using System;

namespace Selection_Sort
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Сортиращ алгоритъм е вид алгоритъм, който пренарежда елементите на колекцията в някакъв ред
            // Как работи - Намираме най-малкия елемент в масива и го сменяме с първи елемент
            // След това търсим следващия най-малък (без намерения вече) и го сменяме с този на втора позиция 
            // След това търсим третия най-малък и го сменяме с този на трета позиция  и т.н.

            //int[] unSortedArr = new[] { 2, 4, 1, 6, 5, 3, 8, 7 };
            int[] unSortedArr = new[] { 12, 334, 1, 6, 12, 23, 12, 709 };

            var sortedArr = Selection_Sort(unSortedArr);

            Console.WriteLine($"[{string.Join(", ", sortedArr)}]");
            Console.WriteLine($"[{string.Join(", ", SelectionSort(unSortedArr))}]");
        }

        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var min = i;

                for (int curr = i+1; curr < arr.Length; curr++)
                {
                    if (arr[curr] < arr[min])
                    {
                        min = curr;
                    }
                }
                Swap2ElementsInArray(arr, i, min);
            }
            return arr;
        }

        public static int[] Selection_Sort(int[] arr)
        {
            for (int p = 0; p < arr.Length-1; p++)
            {
                int firstIndex = p;
                int minValue = int.MaxValue;
                int swapIndex = p;

                for (int i = p; i < arr.Length; i++)
                {
                    int currEl = arr[i];

                    if (currEl < minValue)
                    {
                        minValue = currEl;
                        swapIndex = i;
                    }
                }
                Swap2ElementsInArray(arr, firstIndex, swapIndex);
            }

            return arr;
        }

        public static void Swap2ElementsInArray(int[] arr, int firstIndex, int swapIndex)
        {
            var firstEl = arr[firstIndex];
            var swapEl = arr[swapIndex];

            arr[firstIndex] = swapEl;
            arr[swapIndex] = firstEl;
        }
    }
}
