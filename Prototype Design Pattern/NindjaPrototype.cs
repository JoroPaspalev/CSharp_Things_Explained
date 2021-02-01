namespace Prototype_Design_Pattern
{
    public class NindjaPrototype : Prototype
    {
        public int Heath { get; set; }

        public int Strenght { get; set; }

        public string Weapon { get; set; }

        public int Defence { get; set; }

        public string InWhichArmyIs { get; set; }

        public int BattlesCount { get; set; }

        // Този Clone() метод връща копие на прототипа
        public override IPrototype Clone()
        {
            return this.MemberwiseClone() as NindjaPrototype;
        }
    }
}
