using System;

namespace Open_Closed_Principle
{
    public static class PrintRectangle
    {
       public static void Print(IShape shape)
        {
            var rectangle = shape as Rectangle;

            int Width = rectangle.Width;
            int Hieght = rectangle.Height;
            int LocationX = rectangle.LocationX;
            int LocationY = rectangle.LocationY;
            ConsoleColor BorderColor = ConsoleColor.DarkRed;

            string s = "╔";
            string space = "";
            string temp = "";
            for (int i = 0; i < Width; i++)
            {
                space += " ";
                s += "═";
            }

            for (int j = 0; j < LocationX; j++)
                temp += " ";

            s += "╗" + "\n";

            for (int i = 0; i < Hieght; i++)
                s += temp + "║" + space + "║" + "\n";

            s += temp + "╚";
            for (int i = 0; i < Width; i++)
                s += "═";

            s += "╝" + "\n";

            Console.ForegroundColor = BorderColor;
            Console.CursorTop = LocationY;
            Console.CursorLeft = LocationX;
            Console.Write(s);
            Console.ResetColor();
        }
    }
}
