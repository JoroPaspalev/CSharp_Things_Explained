namespace Factory_Method_Design_Pattern
{
    public class SamsungManufacturer : Manufacturer
    {
        public override IGsm CreateGsm()
        {
            var samsungGsm = new SamsungGsm
            {
                BatteryCapacity = 110,
                Width = 130,
                Height = 200,
                Weight = 99
            };
            return samsungGsm;
        }
    }
}
