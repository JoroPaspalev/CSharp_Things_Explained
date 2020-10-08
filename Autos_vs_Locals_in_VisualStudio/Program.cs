using System;

namespace Autos_vs_Locals_in_VisualStudio
{
    class Program
    {
        //Autos and Locals windows are available only in Debbuging mode. Differences between then is that Autos show only variable in current line and previous line, and Locals show all variables in the scope. For example:

        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            string name = "Joro";
            decimal price = 12.34M;
        }

        // If we put breakpoint at row 12 where int b=2 is, Autos will show as only "b" and "a" variables. Local will show args,a,b,c,d,name,price. If we put breakpoint at row13 Autos will show only "c" and "b"
    }
}
