namespace Fluent_API
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string firstName)
        {
            this.FirstName = FirstName;
        }

        public Person(string firstName, string surname)
        {
            this.FirstName = firstName;
            this.Surname = surname;
        }

        public Person(string firstName, string surname, string lastName)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.LastName = lastName;
        }

        public Person(string firstName, string surname, string lastName, int age)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.LastName = lastName;
            this.Age = age;
        }

        public Person(string firstName, string surname, string lastName, int age, string address)
        {
            this.FirstName = firstName;
            this.Surname = surname;
            this.LastName = lastName;
            this.Age = age;
            this.Address = address;
        }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }
    }
}
