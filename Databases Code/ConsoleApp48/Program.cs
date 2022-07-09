using ConsoleApp.Data.Scaffolded;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            var localConnectionString = configuration.GetConnectionString("northwind");

            Console.WriteLine(localConnectionString);


            List<Category> query;
            using (var db = new NorthwindContext())
            {
                query = db.Categories
                    .Where(x => x.CategoryId > 2).ToList();
            }

            var res = query.ToList();
            foreach (var item in res)
            {
                Console.WriteLine(item.CategoryName);
            }

            using (var db = new NorthwindContext())
            {
                var ship = new Shipper()
                {
                     CompanyName = "Test",
                    Phone = "837373373",
                };

                db.Shippers.Add(ship);

                db.SaveChanges();
            }
        }
    }
}
