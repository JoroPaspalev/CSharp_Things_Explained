namespace Prototype_Design_Pattern
{
    public abstract class Prototype : IPrototype
    {
        public abstract IPrototype Clone();
    }
}
