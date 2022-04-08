using System;
using System.Collections.Generic;

namespace Delegates
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Делегата е нещо (pointer) което сочи към функция. Тази функция към която сочи делегата трябва да има същата сигнатура като делегата
            //Всички останали типове данни Func, Action и Predicate са Delegates просто се различават по това, че приемат точно определени параметри и връщат или не резултат - Например Predicate - взема само един входен параметър и връща винаги bool, Action-на пъка винаги не връща нищо, докато път Func може да взема различни входни параметри и да връща резултат

            //4. Извиквам функцията PrintResult, като на нея, като параметър подавам друга функция която се нарича CallBack функция, в случая е Square. По този начин Delegate взима адреса на функцията която трябва да извика, извиква Square функцията тя се изпълнява и връща резултат в PrintResult функцията
            PrintResult(Square);


            //5. По този начин като сме дефинирали PrintResult функцията с делегат можем да изциклим всичките 4 функции които отговярят на сигнатурата на делегата без проблем. Можем да си направим масив от функции и да ги Foreach-нем

            var listWithFunctions = new List<MyDelegate>() 
            {
                Square,
                MultiplyTwoNumbers,
                SubtractNumbers,
                AddingTwoNumber
            };

            foreach (var currentFunc in listWithFunctions)
            {
                PrintResult(currentFunc);
            }


            Console.ReadLine();
        }

        //Ето пример за Delegate - той се дефинира с ключовата думичка delegate
        // Delegate Syntax - [access modifier] delegate [return type] [delegate name]([parameters])
        // Добра практика е делегата да се дефинира извън класа, но може да бъде дефиниран и вътре в него

        //1. // declare a delegate
        public delegate int MyDelegate(int num1, int num2);

        //2. set target method - т.е. делегата ще сочи към този метод
        public static int Square(int num1, int num2)
        {
            return num1 * num1;
        }

        // 2. set target method
        public static int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        // 2. set target method
        public static int SubtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        // 2. set target method
        public static int AddingTwoNumber(int num1, int num2)
        {
            return num1 + num2;
        }

        // 3. Set Delegate to other function as a parameter
        //Функцията PrintResult казва - Аз искам да ми се подават всякакви функции на които сигнатурата, задължително трябва да е от два int (int num1, int num2), аз вътре ще пренасоча към подадената ми функция да изчисли резултата и аз ще го принтирам
        public static void PrintResult(MyDelegate myDelegate)
        {
            var num1 = 5;
            var num2 = 6;
            var result = myDelegate(num1, num2);
            Console.WriteLine(result);
        }


    }

}

