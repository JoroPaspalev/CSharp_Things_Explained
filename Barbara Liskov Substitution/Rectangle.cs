namespace Barbara_Liskov_Substitution
{
    public class Rectangle : Shape
    {
        public override double Area => this.Width * this.Height;

        public virtual double Width { get; set; }

        public virtual double Height { get; set; }
    }
}
