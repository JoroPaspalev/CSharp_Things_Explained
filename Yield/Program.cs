using System;
using System.Collections.Generic;

namespace Yield
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in GenerateFibonacciNumbers_With_Additional_Collection(10))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(Environment.NewLine);

            foreach (var item in GenerateFibonacciNumbers_With_Yield(10))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static IEnumerable<int> GenerateFibonacciNumbers_With_Yield(int n)
        {
            for (int i = 0, j = 0, k = 1; i < n; i++)
            {
                yield return j;// yield връща елементите един по един без да трябва да създавам друга колекция в която да записвам временно резултатите и накрая да я return-на -> var list = new List<int>();

                var nextNumber = j + k;
                j = k;
                k = nextNumber;
            }
        }

        public static IEnumerable<int> GenerateFibonacciNumbers_With_Additional_Collection(int n)
        {
            var list = new List<int>();// без yield трябва да направя нова колекция (демек още памет да заема) което на времето не е било OK
            var j = 0;
            var k = 1;

            list.Add(j);
            list.Add(k);

            for (int i = 0; i < n - 2; i++)
            {
                var nextNum = j + k;

                list.Add(nextNum);
                j = k;
                k = nextNum;
            }

            return list;
        }
    }
}
