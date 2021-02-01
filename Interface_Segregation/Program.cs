using System;
using System.Collections.Generic;

namespace Interface_Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Нека имаме един Interface IWorker който има 3 метода Eat(); Sleep(); Work();
            // Също така имаме и двама наследника на този IWorker - Human и Robot. Обаче Robot-a не може да яде и спи следователно той ще трябва да имплементира методи, които няма да използва (или да ги оставя с throw new Exception)

            var robot = new Robot();

            robot.Eat(); // Гърми
            robot.Sleep(); // Гърми

            // За да следваме Interface segregation принципа трябва IWorker да го разделим на 3 отделни Interfaces IWorker, IEater, ISleeper и всеки да има по един метод в него, след което Robot да наследява само IWorker без ISleeper и IEater

        }
    }
}
