using System.Collections.Generic;
using System.Linq;
using CafeManagement.Domain.Context;
using CafeManagement.Domain.Entities.Cafe;
using CafeManagement.Domain.Entities.Menu;

namespace CafeManagement.Domain.Seed
{
    public class Seeder
    {
        public static void Seed(CafeManagementContext context)
        {
            if (context == null) return;

            SeedData(context);
        }

        private static void SeedData(CafeManagementContext context)
        {
            bool existTable = context.Tables.Any();
            bool existCategory = context.Categories.Any();
            bool existProduct = context.Products.Any();

            if (!existTable)
            {
                context.Tables.AddRange(SeedTables());
                context.SaveChanges();

            }

            if (!existCategory)
            {
                context.Categories.AddRange(SeedCategories());
                context.SaveChanges();
            }


            if (!existProduct)
            {
                context.Products.AddRange(SeedProducts());
                context.SaveChanges();
            }

        }

        private static IEnumerable<Table> SeedTables()
        {
            return new List<Table>()
            {
                new Table()
                {
                    Id = 1,
                    TableName = "Masa 1",
                    IsFull = false
                },
                new Table()
                {
                    Id = 2,
                    TableName = "Masa 2",
                    IsFull = false
                },
                new Table()
                {
                    Id = 3,
                    TableName = "Masa 3",
                    IsFull = false
                },
                new Table()
                {
                    Id = 4,
                    TableName = "Masa 4",
                    IsFull = false
                },
                new Table()
                {
                    Id = 5,
                    TableName = "Masa 5",
                    IsFull = false
                },
                new Table()
                {
                    Id = 6,
                    TableName = "Masa 6",
                    IsFull = false
                },
                new Table()
                {
                    Id = 7,
                    TableName = "Masa 7",
                    IsFull = false
                },
                new Table()
                {
                    Id = 8,
                    TableName = "Masa 8",
                    IsFull = false
                },
                new Table()
                {
                    Id = 9,
                    TableName = "Masa 9",
                    IsFull = false
                }
            };
        }

        private  static IEnumerable<Category> SeedCategories()
        {
            return new List<Category>()
            {
                new()
                {
                    Id = 1,
                    Name = "Kahvaltılar",
                },
                new()
                {
                    Id = 2,
                    Name = "Pizzalar",
                },
                new()
                {
                    Id = 3,
                    Name = "Burgerler",
                },
                new()
                {
                    Id =4,
                    Name = "Makarnalar",
                },
                new()
                {
                    Id = 5,
                    Name = "Tatlılar",
                },
                new()
                {
                    Id = 6,
                    Name = "Soğuk İçecekler",
                },
                new()
                {
                    Id = 7,
                    Name = "Sıcak İçecekler",
                }
            };
        }

        private  static IEnumerable<Product> SeedProducts()
        {
            return new List<Product>()
            {
                new()
                {
                    Id = 1,
                    Name = "Serpme Kahvaltı",
                    Description = "2 Kişilik",
                    Price = 10,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Kahvaltılar")).Id
                },
                new()
                {
                    Id =2,
                    Name = "Serpme Kahvaltı",
                    Description = "3 Kişilik",
                    Price = 17,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Kahvaltılar")).Id
                },
                new()
                {
                    Id = 3,
                    Name = "Serpme Kahvaltı",
                    Description = "4 Kişilik",
                    Price = 20,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Kahvaltılar")).Id
                },
                new()
                {
                    Id = 4,
                    Name = "Serpme Kahvaltı",
                    Description = "6 Kişilik",
                    Price = 40,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Kahvaltılar")).Id
                },
                new()
                {
                    Id = 5,
                    Name = "Latte",
                    Price = 10,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Soğuk İçecekler")).Id
                },
                new()
                {
                    Id = 6,
                    Name = "Americano",
                    Price = 10,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Soğuk İçecekler")).Id
                },
                new()
                {
                    Id = 7,
                    Name = "Expresso",
                    Price = 10,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Soğuk İçecekler")).Id
                },
                new()
                {
                    Id = 8,
                    Name = "Cold Brew",
                    Price = 10,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Soğuk İçecekler")).Id
                },
                new()
                {
                    Id = 9,
                    Name = "Çay",
                    Price = 10,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Sıcak İçecekler")).Id
                },
                new()
                {
                    Id =  10,
                    Name = "Ihlamur",
                    Price = 10,
                    CategoryId = SeedCategories().First(x => x.Name.Equals("Sıcak İçecekler")).Id
                },
            };
        }
    }
}