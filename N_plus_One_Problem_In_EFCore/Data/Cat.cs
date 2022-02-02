using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_plus_One_Problem_In_EFCore.Data
{
    public class Cat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public string Breed { get; set; }

        public int OwnerId { get; set; }

        public Owner Owner { get; set; }
    }
}
