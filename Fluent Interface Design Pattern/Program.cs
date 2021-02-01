namespace Fluent_Interface_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // той също е част от creational Design Patterns защото връща създаден обект
            // 1. Правя си клас, който ще създава инстанция на private обект. Чрез public Properties ще мога да му попълвам стойностите и накрая ще може да ви се върне нов обект със записани стойности.  

            // 1. Правя си един class Person който има Properties: First, Surname, LastName, Age, Address 
            // 2. Правя си PersonBuilder който вътре в себе си прави инстанция на Person и я държи скрита
            // 3. Правя методи в PersonBuilder, който да приемат някакви стойности през параметър на метода и да ги сетват на Person. Задължително трябва да връщат this за да може да продължим с точка следващ метод - .FirstName("Ivan").LastName("Pepkin".Age(12))
            // 4. За да може да връща целия Person с попълнените му данни трябва да направя един метод, който връща Person-a

            var personBuilder = new PersonBuilder();
            var person = personBuilder
                .CreatePerson()
                .WithFirstName("Ivan")
                .WithSurname("Penchev")
                .WithLastname("Gorilov")
                .WithAge(33)
                .WithAddress("Sofia")
                .Build();
        }
    }
}
