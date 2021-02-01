namespace Open_Closed_Principle
{
    public class TriangleDrawingManager : DrawingManagerCorrect
    {
        protected override void DrawFigure(IShape shape)
        {
            // тук вече трябва да имплементирам как се рисува триъгалник по конзолата
            PrintTriangle.Print(shape);
        }
    }
}
