using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_plus_One_Problem_In_EFCore.Data
{
    public class Owner
    {
        public Owner()
        {
            Cats = new List<Cat>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string City { get; set; }

        public ICollection<Cat> Cats { get; set; }
    }
}
