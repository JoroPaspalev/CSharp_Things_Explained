using System;

namespace Open_Closed_Principle
{
    public static class PrintCircle
    {
        public static void Print(IShape shape)
        {
            var circle = shape as Circle;

            double radius = circle.Radius;
            double thickness = 0.4;
            ConsoleColor BorderColor = ConsoleColor.Yellow;
            Console.ForegroundColor = BorderColor;
            char symbol = '*';

            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
