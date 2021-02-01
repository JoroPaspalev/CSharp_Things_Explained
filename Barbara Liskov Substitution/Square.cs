namespace Barbara_Liskov_Substitution
{
    public class Square : Rectangle
    {
        // Тъй като квадрата може да се получи от квадрат с равни страни, решавам, че може да наследя от Rectangle и да му променям страните от Width = Height = зададената от вън стойност. Ако ми подадеш стойност за Width аз ще я копирам и на Height и обратно, ако ми дадеш стойност за Height аз ще я задам и на Weight, така ще стане квадрат. Да ама не!!! Ако задам square.Width =10 и после square.Height = 20, кое ще ми вземе за правилно 10 или 20 - в случая 20 понеже е последно въведената стойност
        public override double Width
        {
            get => base.Width;
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Height 
        {
            get => base.Height;
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
