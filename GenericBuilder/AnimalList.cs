using System.Collections.Generic;

namespace GenericBuilder
{
    public class AnimalList<T> : IAnimal
        where T : Animal, new() // Това казва, че приема само Animal класа или негов наследник. Нищо друго. 
        //  where T : Animal, new() - new()-то добавя ограничение освен че приема само Animal class или наследник то трябва всеки един от тези класове да има и празен ctor. Ако котката няма празен ctor нищо, че е наследник няма да може да бъде подавана
        // where се слага единствено при generic class. Няма как на non-generic class да му сложа where ограничение
    {
        private List<Animal> animalList;
        
        public AnimalList()
        {
            this.animalList = new List<Animal>();
        }

        public void Add(T animal)
        {
            this.animalList.Add(animal);
        }

        public bool Remove(T animal)
        {
            if (this.animalList.Contains(animal))
            {
                this.animalList.Remove(animal);
                return true;
            }

            return false;
        }

        public List<Animal> GetList()
        {
            return this.animalList;
        }

        // Слагам ги само за да покажа, че може да наследявам IAnimal и допълнително да имам where за самия T
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int Age { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    }
}
