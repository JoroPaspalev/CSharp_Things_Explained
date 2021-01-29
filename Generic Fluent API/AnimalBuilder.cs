namespace Generic_Fluent_API
{
    public class AnimalBuilder<IAnimal>
    {
        private Animal animal;

        public AnimalBuilder()
        {
            this.animal = new Animal();
        }

        public AnimalBuilder<IAnimal> AddName(string name)
        {
            this.animal.Name = name;
            return this;
        }

        public Animal Build()
        {
            return this.animal;
        }


    }
}
