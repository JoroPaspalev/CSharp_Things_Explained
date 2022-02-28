using System;
using System.Collections.Generic;

namespace Static_Variables_In_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цел: Искам да преброя колко кучета съм взел в моя Магазин за кучета, като ги отделям по име и бройка. 
            // Напр. Мишо --> 3 бр., Гошо --> 5 бр. ...
            //Тъй като всеки път като направя dog = new Dog(), това нулира текущото куче, трябва да му направя полето, което искам да не се занулява static за да не се трие при new. т.е.  public static Dictionary<string, int?>
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Въведете име на кучето:");
                string nameOfDog = Console.ReadLine();

                //Всеки път правим нова инстанция
                Dog dog = new Dog(nameOfDog);

                if (!Dog.Shop.ContainsKey(nameOfDog))
                {
                    Dog.Shop[nameOfDog] = 0;
                }

                Dog.Shop[nameOfDog]++;

                //За да покажем, че static variables (т.е. Dog.Shop) са достъпни от всяка една инстанция правим това
                foreach (var kvp in Dog.Shop)
                {
                    Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }

    public class Dog
    {
        public static Dictionary<string, int?> Shop = new Dictionary<string, int?>();

        public Dog(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
