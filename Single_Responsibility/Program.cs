using System;

namespace Single_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Този принцип гласи: Всеки модул (class, Method...) трябва да прави едно единствено нещо
            SumAndPrint(5, 10);
        }
        public static void SumAndPrint(int a, int b)
        {
            //Тук имаме две операции - което чупи пози принцип

            // 1. Събиране
            int sum = a + b;

            // 2. Принтиране
            Console.WriteLine(sum);
        }
    }
}
