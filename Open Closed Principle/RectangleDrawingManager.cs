namespace Open_Closed_Principle
{
    public class RectangleDrawingManager : DrawingManagerCorrect
    {
        protected override void DrawFigure(IShape shape)
        {
            PrintRectangle.Print(shape);
        }
    }
}
