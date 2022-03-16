using Animals;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Всичките тези класове се намират в namespace Animals и само това вижда Visual Studio-то. Не го интересува името на .cs файла, нито в коя папка или подпапка е Cat или Dog класа. Така мога да си направя разделение по папки и въпреки това всички класове да се виждат едновременно като извикам единствено using Animals
            var cat = new Cat();
            var dog = new Animals.Dog().IamDogFrom_Animals_Namespace;
            var m = new Monkey();
            var snake = new Snake();
            var enumeration = Enumerations.aaa;
            var checken = new Chicken();

            // По този начин аз като developer мога да си направя отделни папки за да ми е по-лесно ориентирането в кода, но пък този който ще ми използва бибилиотеката няма да селектира 1000 различни using-а, а само един единствен, в който ще са видими всички  класове.


            //Ако оставя даден клас без да има namespace, то той директно отива в global namespace
            //Global namespace е с по-голям приоритет т.е. VS първо търси в него за даден клас и после тръгва по using-ите
            var ddog = new global::Dog().IamDogFrom_Global_Namespace;
            //var ddog = new Dog().IamDogFromGlobalNamespace;//Същото като горното само че без изрично да описвам global::


            ///////////////////////////////////////////////////////////////////////

            //Ако обаче вкараме using Animals вътре в namespace Project така ще се промени този приоритет и тогава първо ще се търси Dog в namespace Animals и чак след това ще се търси в global namespace

            //namespace Project
            //{
            //    using Animals;



            ///////////////////////////////////////////////////////////////////////
            // Разделяне на namespace с точки за всяка поддиректория

            var dogC = new Library.aaa.bbb.ccc.Dog();
            var bird = new Library.aaa.bbb.Bird();
            var mouse = new Library.aaa.Mouse();
            var caw = new Library.aaa.bbb.Caw(); //Caw.cs класът се намира на ниво Libary, но след като му промених namespace на Library.aaa.bb Visual Studio-то не го интересува това нещо и си гледа към му е namespace

        }
    }
}
