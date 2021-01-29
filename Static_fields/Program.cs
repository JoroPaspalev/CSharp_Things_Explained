using System;

namespace Static_fields
{
    class Program
    {
        static void Main(string[] args)
        {
            // Какво означава едно поле (field) да е статично? - Означава, че това поле е свързано със самия клас, а не с негова инстанция --> Това означава, че полета, методи и свойства маркирани като статични, принадлежат на самия клас, а не на някой конкретен обект от дадения клас. И се извикват чрез самия клас --> Dog.countOfCreatedDogs

            // I. Нека имаме следната задача: Искаме да преброим колко кучета са инстанцирани от клас Dog?
            var dog1 = new Dog("Sharo", 2);
            var dog2 = new Dog("Murdjo", 1);
            var dog3 = new Dog("Pesho", 5);

            Console.WriteLine(Dog.countOfDogs);

            // Нека сега да искаме да видим кое е последно създаденото куче?
            // a. Правим си една static променлива lastCreatedDog, която ще се промения всеки път когато се създава ново куче и ще взима неговото име
            Console.WriteLine(Dog.lastCreatedDog);

            // II. Static методи в класа Dog - Извиква се без да е нужна инстанция на Dog, а става директно ето така:
            Dog.AllDogsMakeSameSound();


            // III. На static readonly variable можем да присвояваме стойност по време на изпълнение на програмата дори да е object, но при const не може. Const иска задължително задаване на стойност по време на компилация, а не по време на изпълнение на програмата.
            Console.WriteLine(Color.BlackColor);
            Console.WriteLine(Color.WhiteColor);
            Console.WriteLine(Color.CountOfColors);
        }
    }

    // 1. Правим си клас Dog
    public class Dog
    {
        // 3. Правим си една статична променлива която ще е на самия клас и всички инстанции на Dog ще могат да я достъпват защото е ОБЩА за тях.
        public static int countOfDogs = 0;
        public static string lastCreatedDog = string.Empty;

        // 4. В конструктора освен инициализация на Properties, правим и отчитане на броя новонаправени кучета
        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            Dog.countOfDogs++;
            Dog.lastCreatedDog = name;
        }

        // 2. Задаваме му Properties
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }

        public static void AllDogsMakeSameSound()
        {
            Console.WriteLine("bay bay");
        }
    }

    public class Color
    {
        public static readonly Color BlackColor = new Color(0, 0, 0);
        //public const Color whiteColor = new Color(255, 255, 255); - на променлива от тип const не може да и се присвоява стойност от тип обект т.е. компилатора забранява използването на думата new в const. Може единствено null стойност
        public const Color WhiteColor = null;
        public const int CountOfColors = 256;

        private readonly int red;
        private readonly int green;
        private readonly int blue;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public override string ToString()
        {
            return $"red:{this.red} green:{this.green} blue:{this.blue}";
        }
    }
}
