using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {          
            try
            {
                throw new DivideByZeroException("Cannot Divide by zero");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
