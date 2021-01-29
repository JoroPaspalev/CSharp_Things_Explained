using System;

namespace EqualOfTwoObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // by default C# сравнява обектите по техните HashCode (т.е. дали референциата води към един и същ адрес), затова cat1 != cat2 нищо че и двете са с име Ivan
            var cat1 = new Cat { Name = "Ivan" };
            var cat2 = new Cat { Name = "Ivan" };
            var cat3 = cat1;

            Console.WriteLine(cat1.Equals(cat2)); // False - Ако не съм Override-нал Equals в Cat
            Console.WriteLine(cat1.Equals(cat3)); // True
            Console.WriteLine(cat1.GetHashCode()); // 58225482
            Console.WriteLine(cat2.GetHashCode()); // 54267293
            Console.WriteLine(cat3.GetHashCode()); // 58225482

            // C# няма представа, как да сравни 2 обекта по техните Properties, затова трябва ние да му кажем. Как става - отиваме с класа Cat и override-ваме Equals метода, като казваме по какво да се сравняват двата обекта
        }
    }
}
