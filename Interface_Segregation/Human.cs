
namespace Interface_Segregation
{
    public class Human : IWorker
    {
        public void Eat()
        {
           // Human can eat
        }

        public void Sleep()
        {
            // Human can Sleep
        }

        public void Work()
        {
            // // Human can Work
        }
    }
}
