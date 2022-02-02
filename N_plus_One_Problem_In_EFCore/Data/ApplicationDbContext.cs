using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_plus_One_Problem_In_EFCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        public DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.; Database=NPlusOneProblem;integrated security=true");
            }
        }
    }
}
