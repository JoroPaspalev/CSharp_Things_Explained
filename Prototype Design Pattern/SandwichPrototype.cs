namespace Prototype_Design_Pattern
{
    public class SandwichPrototype : Prototype
    {
        public string Bread { get; set; }

        public string Meat { get; set; }

        public string Salads { get; set; }

        public string Cheese { get; set; }

        public string Additives { get; set; }

        public override IPrototype Clone()
        {
            // this.MemberwiseClone() - Това е .NET-ски метод, който наготово ни клонира текущия обект - this, който в случая е SandwichPrototype. Тъй като Clone() трябва да върне IPrototype, а this.MemberwiseClone() връща SandwichPrototype то трябва да го cast-нем
            return this.MemberwiseClone() as IPrototype;
        }
    }
}
