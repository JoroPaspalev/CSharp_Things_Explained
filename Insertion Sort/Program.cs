using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Въртя през елементите на колекцията от началото към края, като започвам от втория елемент и го сравнявам с първия
            // Ако втория е по-малък от първия ги сменям.
            // Преминавам към следващия т.е. третия проверявам го с предпоследния и ако е по-малък от него го SWAP-вам. След това с предпредпоследния и ако той не е по-малък прекъсвам до там т.е. значи всички преди него са по-малки и няма смисъл да въртя и през тях
            // Минавам на четвъртия - сравнявам го с третия, после с втория и първия. Ако не се Swap-ват break-вам
            var unsortedArr = new int[] { 44, 3, 297, 38, 5, 47, 15, 1, 29, 97, 83, 222, 7, 8, 8, 7 };

            Console.WriteLine(string.Join(", ", InsertionSort(unsortedArr)));
        }

        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var currEl = arr[i];

                for (int p = i - 1; p >= 0; p--)
                {
                    var previousEl = arr[p];

                    if (currEl < previousEl)
                    {
                        arr[p + 1] = previousEl;
                        arr[p] = currEl;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return arr;
        }
    }
}
