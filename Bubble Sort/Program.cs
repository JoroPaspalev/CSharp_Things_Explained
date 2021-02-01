using static Selection_Sort.Program;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Идеята на BubbleSort е да тръгна отпървия елемент да го сравня с втория и ако първия е по-голям от втория да им сменя местата. Така избутвам най-големия елемент (число) най-надясно т.е. ги подреждам не от ляво на дясно, а от дясно на ляво. При следващата итерация намалявам с един елемент, тъй като знам, че на последата позиция ми е подреден елемента и така докато останат само първите 2 елемента. След като bool isSorted ми върне че са всичките по ред връщам масива
            var unsortedArr = new int[] { 2, 7, 4, 1, 5, 3 };
            System.Console.WriteLine(string.Join(", ", BubbleSort(unsortedArr)));
        }

        public static int[] BubbleSort(int[] arr)
        {
            for (int p = 1; p < arr.Length; p++)
            {
                bool isSorted = true;

                for (int i = 0; i < arr.Length - p; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap2ElementsInArray(arr, i, i + 1);
                        isSorted = false;
                    }
                }

                if (isSorted)
                {
                    return arr;
                }
            }

            return arr;
        }
    }
}
