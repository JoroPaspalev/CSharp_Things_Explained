using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities_in_Bulgaria
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }

                var currCity = input.
                    Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                    ToArray().
                    ElementAt(0);

                cities.Add(currCity);
            }

            Console.ReadLine();

        }
    }
}
