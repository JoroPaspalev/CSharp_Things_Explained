using System.Collections.Generic;
using System.Linq;

namespace Fluent_API
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fluent API - е когато можем да изреждаме метод точка, метод точка, метод точка т.е. имаме method chaining .Where().Select().OrderBy().ToList() ...
            // Например: 
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var filteredNumbers = numbers
                .Where(n => n % 2 == 0)
                .Select(x => x)
                .OrderByDescending(x => x)
                .ToList();

            // Fluent API прави кода по-лесно четим и разбираем
            // 1. Нека имаме един клас Person и той си има Properties - FirstName, Surname, LastName, Age, Address. За да можем да извикаме new Person с възможност да попълним някое от всички пропъртита пооделно ще ни трябват много конструктори, което не е много ефективно, защото ще трябва да изпишем супер много код. За това може да си направим един Builder class, който да има Fluent API за по лесно въвеждане на данните на Person

            var person = new Person();

            var person2 = new Person("Ivan", "Ivanov");

            var person3 = new Person("Ivan", "Ivanov", "Ivanov");


            // Ако използваме Fluent API ще стане така:
            // Правим си инстанция на Bulder-а, която ще ми създаде самия Person в конструктора му и попълваме properties на този скрит Person, много по-лесно само чрез извикване на точка нещо си, точка нещо си и т.н.
            var personBuilder = new PersonBuilder();
            var ivan = personBuilder
                .AddFirstName("Ivan")
                .AddSurname("Petrov")
                .AddLastName("Ivanov")
                .AddAge(33)
                .AddAddress("Ruse, Cherni vruh 23 Str")
                .Build();

            // Искаме да му въведем само името и годините
            var personBuilder1 = new PersonBuilder();
            var pesho = personBuilder1
                .AddFirstName("Pesho")
                .AddAge(22)
                .Build();
        }
    }
}
