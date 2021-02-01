namespace Singleton_Design_Pattern
{
    public class SingletonContainer
    {
        // Тук мога да извикам private Ctor-а понеже съм вътре в самия клас и имам достъп
        private static SingletonContainer instance = new SingletonContainer();

        // private ctor не може да бъде извикан отвън
        private SingletonContainer()
        {
            // do some work
            System.Console.WriteLine("тъй като е static field това означава, че прави само една единствена глобална инстанция, която вика private Ctor-а само при първоначалното инициализиране");
        }

        public static SingletonContainer Instance => instance;
    }
}
