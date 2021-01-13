using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Рекурсия е когато един метод извиква себе си или когато две метода се извикват един друг. Рекурсията е метод за решаване на задачи, която разделя един проблем на подпроблеми от един и същи вид

            //Например: Искаме да намерим в един int[] каква е сумата на елементите му рекурсивно
            //1.
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };
            int sum = Sum(numbers, 0);
            Console.WriteLine(sum);

            //Например - Искаме да намерим факториел на дадено число
            //2.
            long fact = Factorial(5);
            Console.WriteLine(fact);

            //3.
            //How to generate all 8-bit vectors recursively?
            //0 0 0 0 0 0 0 0
            //0 0 0 0 0 0 0 1
            //...
            //0 1 1 1 1 1 1 1
            //1 0 0 0 0 0 0 0
            //...
            //1 1 1 1 1 1 1 0
            //1 1 1 1 1 1 1 1
            Generate(0, new int[4]);

            //Алтернативното решение е това
            for (int i = 0; i <= 1; i++)
            {
                for (int p = 0; p <= 1; p++)
                {
                    for (int q = 0; q <= 1; q++)
                    {
                        for (int d = 0; d <= 1; d++)
                        {
                            Console.WriteLine($"{i} {p } { q} { d}");
                        }
                    }
                }
            }

        }

        //1.
        //т.е. тук подаваме масива с цели числа, и от кой индекс да започнем да сумираме. Целта е да стигнем до дъното на рекурсията и да започнем да връщаме number[index], който да се събере с резултата от предходния извикващ метод
        public static int Sum(int[] numbers, int index)
        {
            if (index == numbers.Length)
            {
                return 0;
            }

            var currSum = numbers[index] + Sum(numbers, index + 1);

            return currSum;
        }


        //2.
        //Трябва да започнем от числото и да намаляме докато стигнем до нула. Когато стигнем до нува return-ваме 1 иначе число по нула = нула
        public static long Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            var currFactorial = number * Factorial(number - 1);

            return currFactorial;
        }

        //3.
        //Стигаме до дъното на рекурсията и отпечатваме масива [0,0,0,0,0,0,0,0], като последния елемент е = 0, после се връщаме на извикващия метод, той върти втора итерация на цикъла т.е. последния елемент е = 1. Index-а пак ми е колкото дължината на масива затова се отпечатва [0,0,0,0,0,0,0,1]. Цикъла вече е приключил затова се връщаме една рекурсия назад. Index-а е равен на index-1 което е index = 6, значи няма да се отпечатва. Влизаме в цикъла, но i=1 затова на масива[6]=1 т.е. [0,0,0,0,0,0,1,0]. Вдигаме индекса, той става на = 7 значи печатаме.....
        public static void Generate(int index, int[] vector)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    Generate(index + 1, vector);
                }
            }
        }

    }
}
