
namespace Open_Closed_Principle
{
    public class CircleDrawingManager : DrawingManagerCorrect
    {
        protected override void DrawFigure(IShape shape)
        {
            //  public void Draw(IShape shape) - този метод се наследява от DrawingManagerCorrect затова може да се извиква

            // Тук вече CircleDrawingManager знае как да рисува точно тази форма и не е нужно да влизам в DrawingManagerCorrect за да му сменям логиката и да правя if()else if() !!!Цялата работа е за да не влизам въобще в DrawingManagerCorrect и да трябва да променям нещо там!!!
            PrintCircle.Print(shape);
        }
    }
}
