using System;

namespace Open_Closed_Principle
{
    public class DrawingManager : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            if (shape is Circle)
            {
                PrintCircle.Print(shape);  
            }
            else if (shape is Rectangle)
            {
                PrintRectangle.Print(shape);
            }
        }
    }
}