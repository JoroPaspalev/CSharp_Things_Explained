using System;

namespace Barbara_Liskov_Substitution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Всеки базов клас трябва да може да бъде заменен от някой от наследниците си, без това да чупи кода
            Rectangle rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 5;
            Console.WriteLine(rectangle.Area);

            // Сега се опитвам да заместя базовия class Rectangle с Square и очаквам резултат 10*5=50 както се смята Area на rectangle
            Square rectangl = new Square();
            rectangl.Width = 10;
            rectangl.Height = 5;
            Console.WriteLine(rectangl.Area); // Само, че получавам 25 колкото е площа на квадрат

            // Правилния начин е да направим нов class Square наследяващ директно от Shape
            var squareCorrect = new SquareCorrect();
            squareCorrect.Side = 10;
            Console.WriteLine(squareCorrect.Area);




        }
    }
}
