using System;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Искам променлива, на която да присвоя функция, приемаща decimal и bool и да не връща нищо - Такава функция се нарича Action. Разликата с Func<>, е че Action-а не връща нищо, тя е Void, докато Func връща някакъв резултат
            Action<decimal, bool> actionVariable = PrintSallary;

            actionVariable(1200, true);
            PrintSallary(1200, true);
        }

        // 1. 
        public static void PrintSallary(decimal sallary, bool isDeserveSallary)
        {
            if (isDeserveSallary)
            {
                Console.WriteLine($"Your sallary is: {sallary}lv");
            }
            else
            {
                Console.WriteLine("You don't deserve sallary");
            }
        }
    }
}
