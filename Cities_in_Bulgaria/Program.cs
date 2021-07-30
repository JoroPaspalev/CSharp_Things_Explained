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

            Console.ReadLine(); // add new comments from Mariyan locally
            //add new comments from Mariyan locally 2
            //add new comments from Mariyan locally 3
            ////add new comments from Mariyan locally 4
            ////add new comments from Mariyan locally 5
            ////add new comments from Mariyan locally 6
            //7
            //8
            //9
        }
    }
}
