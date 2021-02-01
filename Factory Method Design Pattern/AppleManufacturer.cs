
namespace Factory_Method_Design_Pattern
{
    public class AppleManufacturer : Manufacturer
    {
        public override IGsm CreateGsm()
        {
            var appleGsm = new AppleGsm
            {
                BatteryCapacity = 100,
                Width = 700,
                Height = 1900,
                Weight = 81
            };

            return appleGsm;
        }
    }
}
