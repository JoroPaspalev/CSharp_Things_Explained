using System;

namespace Open_Closed_Principle
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Неправилния вариант е този, защото в DrawingManager правим проверка дали типа е Circle или Rectangle и т.н. Ако утре искам да принтирам и Triangle, ко прайм? Трябва да влязам и в DrawingManager да променям. Затова си правим наследници на DrawingManager и те казват коя shape как да се рисува
            DrawingManager drManager = new DrawingManager();
            drManager.Draw(new Circle { Radius = 9 });
            drManager.Draw(new Rectangle { Width = 90, Height = 20 , LocationX = 0, LocationY = 20});

            // 2. Правилния вариант
            var circleDrawingManager = new CircleDrawingManager();
            circleDrawingManager.Draw(new Circle { Radius = 19 });

            var rectangleDrawingManager = new RectangleDrawingManager();
            rectangleDrawingManager.Draw(new Rectangle { Width = 70, Height = 10, LocationX=0, LocationY = 142});

            // Вече спокойно можем да добавим и TriangleManager който да рисува нова форма
            var triangleDrawingManager = new TriangleDrawingManager();
            triangleDrawingManager.Draw(new Triangle { Cathetus = 10 }); 






        }
    }
}
