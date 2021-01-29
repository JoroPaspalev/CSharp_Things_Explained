using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Защо да използваме Generic методи или класове? Навремето е нямало Generics и всичко е било колекция от обекти - например: List<object> object[] ... Това обаче е проблем, защото нямаме типизация т.е. вътре обектите да са от един и същ вид - може да имаме string, int, Cat, Dog ... Затова се въвежда типизацията т.е. като кажем че един лист е от int-ове вътре има само int-ове и нищо друго. Освен това ако искаме от List<object> да вземем някой елемент, който е int ще трябва допълнително да го кастваме или всички да ги кастнем, което е допълнително работа.
            // Най-често Generics се използва при Collections - List<T>, HashSet<T>, Stack, Queue, Dictionary<TKey, TValue>


            // 1. Създаване на Generic method - който да попълва елементите на масив от подадени отвън типове данни
            var stringArray = SomeMethod<string>(10, "text");
            var intArray = SomeMethod<int>(10, 5);


            // 2. Създаване на Generic method от List<T>
            var myList = MyList<string>("Ivan");
            // Можем да извикаме метода MyList без да слагаме <T> след името му, защото компилатора ще се сети сам и ще вземе типа от типа на подавания параметър в сигнатурата на метода
            var myString_List1 = MyList("Ivan");
            var myInt_List = MyList(55);
            var myChar_List = MyList('f');


            // 3. Направи ми колекция която може да записва всякакъв тип в себе си и има следните методи Add и Remove, като Remove връща последно вкарания елемент в тази колекция и го изтрива
            var box = new Box<string>();
            box.Add("pillow1");
            box.Add("pillow2");
            box.Add("pillow3");
            box.Add("pillow4");
            var currPillow = box.Remove();

            var box_Of_int = new Box<int>();
            box_Of_int.Add(256);
            box_Of_int.Add(128);
            box_Of_int.Add(64);
            var currNumber = box_Of_int.Remove();

            var box_Of_Cats = new Box<Cat>();
            box_Of_Cats.Add(new Cat { Name = "Basri" });
            box_Of_Cats.Add(new Cat { Name = "Ivanichka" });
            box_Of_Cats.Remove();
            var count = box_Of_Cats.Count;

            // 4. Направете клас ArrayCreator, който да има един единствен метод static T[] Create(int lenght, T item)
            var array = ArrayCreator.Create<int>(5, 333);


                                                            // Generics Constraints

            // 5. Generics Constraints - те ни позволяват да ограничаваме <T> - т.е. подаваните типове към Generic класовете или методите, така както ние искаме. тъй като C# не знае какъв тип ще му бъде подаден, той не може и да изпълни никакви операции върху подаваните типове. Например: int sum = T1 + T2. Това няма да се компилира, тъй като как C# да знае T1 и T2 какво са, string ли е, int ли е, Cat ли е затова можем да му подскажем чрез where - class or struct:

            // 5.1. where : T is class - това казва, че List приема само T, което е Class иначе не работи
            var my_List = new MyClassList<Cat>();
            // Ако му подам това гърми. Защото int е struct
            //var my_list_ = new MyList<int>(); 

            // 5.2. where : T is struct - т.е. типове данни на които defult value не е null
            var @struct1 = new MyStructList<int>();
            var @struct2 = new MyStructList<bool>();
            var @struct3 = new MyStructList<char>();
            // Ако му подам това гърми. Защото e class
            //var @struct_ = new MyStructList<Cat>();

            // 5.3. where T : new() - Понеже C# не ми дава да правя нова инстанция от T ( new T ) в Class-a или method-a (т.е. да създам обект от T), мога да му кажа where T : new() т.е. T може да е всяко нещо, което има празен конструктор (Ако класът ми има празен конструктор мога да го подам вместо T)
            var classWithEmptyCtor = new MyListWithEmptyCtorClass<Cat>();

        }

        // 5.1.
        public class MyClassList<T>
            where T : class
        {
        }

        // 5.2.
        public class MyStructList<T>
            where T : struct
        {
        }

        // 5.3.
        public class MyListWithEmptyCtorClass<T>
            where T : new()
        {
            T animal;

            public void Add(T item)
            {
                this.animal = new T();
            }
        }


       
        // 1.
        public static T[] SomeMethod<T>(int length, T value)
        {
            var array = new T[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = value;
            }

            return array;
        }

        // 2.
        public static List<T> MyList<T>(T item)
        {
            List<T> list = new List<T>();

            list.Add(item);

            return list;
        }
    }   
}
