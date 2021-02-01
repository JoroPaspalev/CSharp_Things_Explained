namespace Fluent_Interface_Design_Pattern
{
    public class PersonBuilder
    {
        private Person person;

        public PersonBuilder CreatePerson()
        {
            this.person = new Person();
            return this;
        }

        public PersonBuilder WithFirstName(string name)
        {
            this.person.FirstName = name;
            return this;
        }

        public PersonBuilder WithSurname(string surname)
        {
            this.person.SurName = surname;
            return this;
        }

        public PersonBuilder WithLastname(string lastName)
        {
            this.person.LastName = lastName;
            return this;
        }

        public PersonBuilder WithAge(int age)
        {
            this.person.Age = age;
            return this;
        }

        public PersonBuilder WithAddress(string address)
        {
            this.person.Address = address;
            return this;
        }

        public Person Build()
        {
            return this.person;
        }
    }
}
