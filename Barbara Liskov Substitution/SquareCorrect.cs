namespace Barbara_Liskov_Substitution
{
    public class SquareCorrect : Shape
    {
        public override double Area => this.Side * this.Side;

        public double Side { get; set; }
    }
}
