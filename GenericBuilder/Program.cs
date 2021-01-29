using System;
using System.Collections.Generic;

namespace GenericBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Искам да направя един лист, който да приема само определен клас или неговите наследници
            var animalList = new AnimalList<Animal>();

            animalList.Add(new Cat("Ivka"));
            animalList.Add(new Dog { Name = "Blagoi"});
            animalList.Add(new Animal { Name = "Animal"});
            // animalList.Add("Ivan"); - Не е наследник на Animal и затова не може да се добави в тази колекция
            var dog = new Dog { Name = "Basri" };
            animalList.Add(dog);
            var isDeleted = animalList.Remove(dog);

            Console.WriteLine(isDeleted);

            foreach (var animal in animalList.GetList())
            {
                Console.WriteLine(animal.Name);
                Console.WriteLine(animal.GetType());
            }


            var equalScale = new EqualityScale<int>(15, 15);

            Console.WriteLine(equalScale.AreEqual());
        }
    }
}
