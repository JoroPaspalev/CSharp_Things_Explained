namespace Factory_Method_Design_Pattern
{
    public abstract class Gsm : IGsm
    {
        public int BatteryCapacity { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }
    }
}
