using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Segregation
{
    public class Robot : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException(); // Because Robot cannot Eat
        }

        public void Sleep()
        {
            throw new NotImplementedException(); // Because Robot cannot Sleep
        }

        public void Work()
        {
            // Robot can only work
        }
    }
}
