using System;

namespace Generic_Fluent_API
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalBuilder = new AnimalBuilder<Cat>();

            var cat = (Cat)animalBuilder
                .AddName("Ginka")
                .Build();

            ;
           
        }
    }
}
