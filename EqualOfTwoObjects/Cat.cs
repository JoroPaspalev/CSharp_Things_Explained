namespace EqualOfTwoObjects
{
    public class Cat
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Cat cat) // Ако obj (обекта с който ще се сравнява) е от тип Cat го кастни към Cat и го запиши в праменлива cat
            {
                return this.Name == cat.Name;// Тук казвам, че ако имената на двете котки са равни значи котките са равни
            }

            return false;
        }
    }
}
