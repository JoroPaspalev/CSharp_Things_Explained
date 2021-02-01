using System;

namespace Prototype_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Идеята тук е че имаме един прототип и искаме да можем да го клонираме много пъти. Например имаме една игра в която има един герой и той се бие с 1000 нинджи - е имено тези 1000 нинджи ще ги клонираме защото всяка една е различен обект и ако героя удари една Health-a и ще бъде различен вече спрамо останалите
            // Ако нинджата ни има 100 propertie ще стане много нечетимо, отколкото ако имаме само един .Clone() 

            NindjaPrototype nindja1 = new NindjaPrototype() { Heath = 100, Strenght = 70, Defence = 40, Weapon = "Samurai sword", InWhichArmyIs = "Ring Vlastelins", BattlesCount = 33};
            NindjaPrototype nindja2 = new NindjaPrototype() { Heath = 100, Strenght = 70, Defence = 40, Weapon = "Samurai sword", InWhichArmyIs = "Ring Vlastelins", BattlesCount = 33 };
            NindjaPrototype nindja3 = new NindjaPrototype() { Heath = 100, Strenght = 70, Defence = 40, Weapon = "Samurai sword", InWhichArmyIs = "Ring Vlastelins", BattlesCount = 33 };
            NindjaPrototype nindja4 = new NindjaPrototype() { Heath = 100, Strenght = 70, Defence = 40, Weapon = "Samurai sword", InWhichArmyIs = "Ring Vlastelins", BattlesCount = 33 };

            // Така е доста по-компактно
           NindjaPrototype nindja5 = nindja1.Clone() as NindjaPrototype;
           NindjaPrototype nindja6 = nindja1.Clone() as NindjaPrototype;
           NindjaPrototype nindja7 = nindja1.Clone() as NindjaPrototype;
           NindjaPrototype nindja8 = nindja1.Clone() as NindjaPrototype;
           NindjaPrototype nindja9 = nindja1.Clone() as NindjaPrototype;


            //2. Искам днес в "Разширени Вени" да продам 20 сандвича от един и същи вид
            var sandwich = new SandwichPrototype() { Bread = "Brown", Meat = "Pork", Cheese = "Gauda", Salads = "Green, Iceberg", Additives = "Ketchup, Mayonnaise, Mustard" };
            // Вместо всеки един сандвич да го клонирам така (или пък още по-лошо да го Copy-Paste-вам) мога да имам просто .Clone()

            var sandwich1 = sandwich.Clone() as SandwichPrototype;
            var sandwich2 = sandwich.Clone() as SandwichPrototype;
            var sandwich3 = sandwich.Clone() as SandwichPrototype;
            var sandwich4 = sandwich.Clone() as SandwichPrototype;

        }
    }
}
