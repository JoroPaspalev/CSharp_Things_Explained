using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Closed_Principle
{
    public static class PrintTriangle
    {
        public static void Print(IShape shape)
        {
            var triangle = shape as Triangle;

            int val = triangle.Cathetus;
            int i, j, k;
            for (i = 1; i <= val; i++)
            {
                for (j = 1; j <= val - i; j++)
                {
                    // Console.Write("");  
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
