namespace Fluent_API
{
    public class PersonBuilder
    {
        private Person person;

        public PersonBuilder()
        {
            this.person = new Person();
        }

        public PersonBuilder AddFirstName(string firstName)
        {
            this.person.FirstName = firstName;
            return this;
        }

        public PersonBuilder AddSurname(string surname)
        {
            this.person.Surname = surname;
            return this;
        }

        public PersonBuilder AddLastName(string lastName)
        {
            this.person.LastName = lastName;
            return this;
        }

        public PersonBuilder AddAge(int age)
        {
            this.person.Age = age;
            return this;
        }

        public PersonBuilder AddAddress(string address)
        {
            this.person.Address = address;
            return this;
        }

        // Чрез този метод даваме достъп на потребителя да получи достъп до самия Person. Без Build той не вижда this.person защото е private!
        public Person Build()
        {
            return this.person;
        }



    }
}
