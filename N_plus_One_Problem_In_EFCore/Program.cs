using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using N_plus_One_Problem_In_EFCore.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace N_plus_One_Problem_In_EFCore
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Database.Migrate();//���� � ��� ���� ��� ������� update-database
                await new Seeder().SeedAsync(db);//������� ����� ����� �� �����
                DbSet<Owner> ownersAsDBSet = db.Owners;// ���� �� �� ����� ������ ��� DB
                List<Owner> owners = ownersAsDBSet.ToList();// ��� ������ ������� .ToList() ������ �� ����� 1��. ������ ��� DB
                // � ������ ���������� Cats � Owner � ������ �� ������ �� � ������� ������� � ��� ���� ������
                foreach (var owner in owners)
                {
                    owner.Cats = db.Cats.Where(c => c.OwnerId == owner.Id).ToList();
                }
            }


            //�� �� �� ������ �� ������ - ����� � N + 1 Problem
            using (var db = new ApplicationDbContext())
            {
                //N + 1 Problem
                List<Owner> owners = db.Owners.ToList();//� ������� ������ ������� ������ Owners

                // � ������ ���������� Cats � Owner � ������ �� ������ �� � ������� ������� � ��� ���� ������ �� ����� owner, ����� ����� ��� N �� ���� ������, ������� � ���� �� owners. ������ � N + 1 problem, ������ �� �������� 10�� ������ (��� �� 10 �� ���� �������������) + 1 ������ ����� ����� ������� ������ owners
                foreach (var owner in owners)
                {
                    owner.Cats = db.Cats.Where(c => c.OwnerId == owner.Id).ToList();
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////
                //How to FIX this N + 1 problem

                var sw = new Stopwatch();
                sw.Start();

                // 1 way - Include
                var ownersWithAllCatsInOneQuery = db.Owners
                                                       .Include(o => o.Cats.Where(cat => cat.Name.Contains("a")))
                                                       .ToList();
                Console.WriteLine(sw.Elapsed);

                sw.Start();
                // 2 way - Select
                var ownersWithFilteredCatsInOneQuery = db.Owners
                                                            .Select(o => new
                                                            {
                                                               Cats = o.Cats.Where(c => c.Name.Contains("a"))
                                                            })
                                                            .ToList();
                Console.WriteLine(sw.Elapsed);
                ////////////////////////////////////////////////////////////////////////////////////////////////////
            }













            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
