
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N_plus_One_Problem_In_EFCore.Data
{
    public class Seeder
    {
        public async Task SeedAsync(ApplicationDbContext db)
        {
            //If there is already entries in CitiesLatLong table do nothing
            if (db.Owners.Count() > 0)
            {
                return;
            }

            var owners = new List<Owner>()
            {
                new Owner{Name = "Antonian", Age=12, City="Sofia" },
                new Owner{Name = "Basrito", Age=15, City="Plovdiv" },
                new Owner{Name = "Vesko", Age=43, City="Stara Zagora" },
                new Owner{Name = "Peshkata", Age=77, City="Varna" },
                new Owner{Name = "Zvezdo", Age=9, City="Ruse" },
            };

            var cats = new List<Cat>()
            {
                new Cat{ Name = "Ivanka", Age = 1 , Breed = "Uli4na", OwnerId = 1 },
                new Cat{ Name = "Penka", Age = 11 , Breed = "Uli4na", OwnerId = 1 },
                new Cat{ Name = "Ginka", Age = 12 , Breed = "Uli4na", OwnerId = 1 },
                new Cat{ Name = "Fani", Age = 6 , Breed = "Uli4na", OwnerId = 2 },
                new Cat{ Name = "Minka", Age = 31 , Breed = "Uli4na", OwnerId = 2 },
                new Cat{ Name = "Ivani4ka", Age = 2 , Breed = "Uli4na", OwnerId = 3 },
                new Cat{ Name = "Petranka", Age = 3 , Breed = "Uli4na", OwnerId = 3 },
                new Cat{ Name = "Ana", Age = 3 , Breed = "Uli4na", OwnerId = 3 },
                new Cat{ Name = "Monik", Age = 1 , Breed = "Uli4na", OwnerId = 3 },
                new Cat{ Name = "Sezgin", Age = 1 , Breed = "Uli4na", OwnerId = 3 },
                new Cat{ Name = "Geneviv", Age = 81 , Breed = "Uli4na", OwnerId = 3 },
                new Cat{ Name = "Danka", Age = 18 , Breed = "Uli4na", OwnerId = 3 },
                new Cat{ Name = "Luiza", Age = 10 , Breed = "Uli4na", OwnerId = 3 },
                new Cat{ Name = "Muiza", Age = 7 , Breed = "Uli4na", OwnerId = 4 }
            };

            await db.Owners.AddRangeAsync(owners);
            await db.SaveChangesAsync();
            await db.Cats.AddRangeAsync(cats);
            await db.SaveChangesAsync();
        }
    }
}
