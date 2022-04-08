using System;

namespace Predicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Predicate е всеки метод, който приема само един parameter като вход и връща bool. Например: IsEvenNumber(); IsNegativeNumber();

            Console.WriteLine(IsEvenNumber(4));
            Console.WriteLine(IsEvenNumber(7));

            Console.WriteLine(IsNegativeNumber(0));
            Console.WriteLine(IsNegativeNumber(9));
            Console.WriteLine(IsNegativeNumber(-5));

            //Мога да си присвоя Predicate функция на променлива от тип Func
            Func<int, bool> predicate = IsEvenNumber;
            Func<long, bool> varPredicate = IsNegativeNumber;

        }

        public static bool IsEvenNumber(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public static bool IsNegativeNumber(long number)
        {
            return number < 0 ? true : false;
        }
    }
}
