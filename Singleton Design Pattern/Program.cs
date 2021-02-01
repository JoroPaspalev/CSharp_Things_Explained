using System;

namespace Singleton_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подсигурява, че класът има само една единствена инстанция и ни дава глобален достъп до нея чрез Static
            // Как се прави този клас? - 
            // 1. Правим Ctor-а да бъде private, за да не може да се инстанцира директно този клас ==> var dd = new SingletonContainer();
            // 2. Правим си Property, чрез което външния свят да има достъп но единствената инстанция, която е скрита в класа

            var instance1 = SingletonContainer.Instance;
            var instance2 = SingletonContainer.Instance;
            var instance3 = SingletonContainer.Instance;

            Console.WriteLine(instance1.Equals(instance2));
            Console.WriteLine(instance1.Equals(instance3));
            Console.WriteLine(instance1.GetHashCode());
            Console.WriteLine(instance2.GetHashCode());
            Console.WriteLine(instance3.GetHashCode());


        }
    }
}
