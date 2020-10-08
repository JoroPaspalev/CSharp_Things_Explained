using System;
using System.Collections.Generic;
using System.Linq;

namespace Func
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Искам функция, която да вдига на квадрат подадено число
            // 2. Искам втора функция, която да намира факториел на дадено число
            // 3. Искам трета функция, която да намира корен квадратен на подадено число
            // 4. Искам функция, която да приема някоя от трите функции и да печата резултата им. А не да и ма три отделни функции за печатане, които да приемат само числото и вътре да извикват различните методи, защото ще има повтаряемост на кода и той няма да се преизползва!
            // 5. Искам функция, която да приема int, double, string и да връща string
            // 6. Искам да си направя собствен метод .Where()

            //!!!!!Wrong way!!!!!!!!
            //PrintSquare(5);
            //PrintFactorial(5);
            //PrintSquareRoot(5);

            //Correct way - чрез една и съща функция можем да отпечатаме различен резултат, като подаваме друга функция, която изчислява резулата, който да се отпечата. Така преизползваме 3 пъти един и същ метод(функция)
            //1.
            PrintResult(5, Square);
            //2.
            PrintResult(5, Factorial);
            //3.
            PrintResult(5, SquareRoot);

            //Присвояване на цял един метод на променлива!!!
            Func<int, long> square = Square;
            Func<int, long> factorial = Factorial;
            Func<int, long> squareRoot = SquareRoot;

            //Това е еквивалентно на написаното по-горе, само че PrintResult-а използва променлива, на която е присвоен метода, вместо директно името на метода!!!
            //4.
            PrintResult(5, square);
            PrintResult(5, factorial);
            PrintResult(5, squareRoot);

            //Може да използваме Func<> и с повече от един входен параметър - приема първите 3 параметъра int, double, string и винаги последното е връщания тип - string в случая
            //Тук присвояваме функцията към променливата variableOfFuncWithThreeInputParameters
            //5.
            Func<int, double, string, string> variableOfFuncWithThreeInputParameters = ThreeInputParametersFunction;

            //Тези двете правят едно и също. В единия случай подаваме направо името на метода, а във втория името на променливата на която сме присвоили същия метод.
            PrintSallaryOfEmployee("Ivan", ThreeInputParametersFunction);
            PrintSallaryOfEmployee("Ivan", variableOfFuncWithThreeInputParameters);

            // 6.Решение
            // 6.1. Правя си един List<int>, който ще филтрирам
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // 6.2. Филтрирам го с MyWhere() и връщам резултата
            List<int> result = MyWhere(numbers, FilterNumbers);
            List<int> result2 = MyWhere(numbers, n => n % 2 != 0); // чрез използване на ламбда функция
            //Как става с оригиналния .Where()
            List<int> result3 = numbers.Where(x => x % 2 == 0).ToList();
        }

        //1.
        public static long Square(int number)
        {
            return number * number;
        }

        //2.
        public static long Factorial(int number)
        {
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        //3.
        public static long SquareRoot(int number)
        {
            long result = (long)Math.Sqrt(number);
            return result;
        }

        //4.
        //!!!!!Wrong way!!!!!!!!
        //public static void PrintSquare(int number)
        //{
        //    long result = Square(number);
        //    Console.WriteLine(result);
        //}

        //public static void PrintFactorial(int number)
        //{
        //    long result = Factorial(number);
        //    Console.WriteLine(result);
        //}

        //public static void PrintSquareRoot(int number)
        //{
        //    long result = SquareRoot(number);
        //    Console.WriteLine(result);
        //}

        //Correct way
        public static void PrintResult(int number, Func<int, long> func)
        {
            long result = func(number);
            Console.WriteLine(result);
        }

        // 5.
        public static string ThreeInputParametersFunction(int countOfWorkingDays, double sallaryForOneDay, string workerName)
        {
            decimal sallary = (decimal)(countOfWorkingDays * sallaryForOneDay);
            string result = $"{workerName}'s sallary is exactly: {sallary:F2}";
            return result;
        }

        // 5. Принтирай ми заплатата
        public static void PrintSallaryOfEmployee(string workerName, Func<int, double, string, string> func)
        {
            int workingDays = 21;
            double sallaryForOneDay = 50.4598433509;
            Console.WriteLine(func(workingDays, sallaryForOneDay, workerName));
        }

        // 6.
        public static List<int> MyWhere(List<int> numbers, Func<int, bool> filter)
        {
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (filter(number))
                {
                    result.Add(number);
                }

                //bool isMatch = false;
                //isMatch = filter(number);
                //if (isMatch)
                //{
                //    result.Add(number);
                //}
            }

            return result;
        }

        public static bool FilterNumbers(int number)
        {
            return number % 2 == 0;
        }
    }
}
