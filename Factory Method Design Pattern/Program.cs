using System;

namespace Factory_Method_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Целта е да минаваме през клас, който да създава обектите, а не ние сами да ги създаваме

            // 1. Правя си abstract class Manufacturer
            // 2. В него си правя abstract method CreateGsm, който ще създава обектите и ще ми ги дава на готово т.е. ще ми връща IGsm. Abstract-ен е за да може да задължи наследниците да го имплементират
            // 3. Правя си Interface IGsm
            // 4. Правя си базов клас Gsm, който да наследява IGsm
            // 5. Правя AppleGsm, който да наследява базовия клас
            // 6. Правя си наследник (AppleManufacturer) на Manufacturer, който ще ми прави конкретна имплементация на AppleGsm и му имплементирам CreateGsm метода
            // 7. Така вече мога да направя apple gsm чрез AppleManufacturer.CreateGsm();
            IGsm applePhone = new AppleManufacturer().CreateGsm();

            // 8. Правим същото и за Samsung gsm
            IGsm samsungPhone = new SamsungManufacturer().CreateGsm();

            // По този начин много лесно утре мога да дойда и да добавя нов NokiaManufacturer примерно, който да ми прави Nokia gsm
            IGsm nokiaPhone = new NokiaManufacturer().CreateGsm();

            // HuaweiManufacturer
            // XiaomiManufacturer
            // ...

        }
    }
}
