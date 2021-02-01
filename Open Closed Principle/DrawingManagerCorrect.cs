namespace Open_Closed_Principle
{
    public abstract class DrawingManagerCorrect : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            this.DrawFigure(shape);
        }

        protected abstract void DrawFigure(IShape shape);
    }
}
