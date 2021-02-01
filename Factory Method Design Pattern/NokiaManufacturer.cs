namespace Factory_Method_Design_Pattern
{
    public class NokiaManufacturer : Manufacturer
    {
        public override IGsm CreateGsm()
        {
            var nokiaGsm = new NokiaGsm
            {
                BatteryCapacity = 93,
                Width = 100,
                Height = 110,
                Weight = 199
            };
            return nokiaGsm;
        }
    }
}
