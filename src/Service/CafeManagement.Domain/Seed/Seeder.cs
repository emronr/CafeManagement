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
                context.Products.AddRange(SeedProducts(context));
                context.SaveChanges();
            }

        }

        private static IEnumerable<Table> SeedTables()
        {
            return new List<Table>()
            {
                new Table()
                {
                    TableName = "Masa 1",
                    IsFull = false
                },
                new Table()
                {
                    TableName = "Masa 2",
                    IsFull = false
                },
                new Table()
                {
                    TableName = "Masa 3",
                    IsFull = false
                },
                new Table()
                {
                    TableName = "Masa 4",
                    IsFull = false
                },
                new Table()
                {
                    TableName = "Masa 5",
                    IsFull = false
                },
                new Table()
                {
                    TableName = "Masa 6",
                    IsFull = false
                },
                new Table()
                {
                    TableName = "Masa 7",
                    IsFull = false
                },
                new Table()
                {
                    TableName = "Masa 8",
                    IsFull = false
                },
                new Table()
                {
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
                    Name = "Kahvaltılar",
                },
                new()
                {
                    Name = "Pizzalar",
                },
                new()
                {
                    Name = "Burgerler",
                },
                new()
                {
                    Name = "Makarnalar",
                },
                new()
                {
                    Name = "Tatlılar",
                },
                new()
                {
                    Name = "Soğuk İçecekler",
                },
                new()
                {
                    Name = "Sıcak İçecekler",
                }
            };
        }

        private  static IEnumerable<Product> SeedProducts(CafeManagementContext context)
        {
            var categories = context.Categories.ToList();
            return new List<Product>()
            {
                new()
                {
                    Name = "Serpme Kahvaltı",
                    Description = "2 Kişilik",
                    Price = 10,
                    CategoryId = categories.First(x => x.Name.Equals("Kahvaltılar")).Id
                },
                new()
                {
                    Name = "Serpme Kahvaltı",
                    Description = "3 Kişilik",
                    Price = 17,
                    CategoryId = categories.First(x => x.Name.Equals("Kahvaltılar")).Id
                },
                new()
                {
                    Name = "Serpme Kahvaltı",
                    Description = "4 Kişilik",
                    Price = 20,
                    CategoryId = categories.First(x => x.Name.Equals("Kahvaltılar")).Id
                },
                new()
                {
                    Name = "Serpme Kahvaltı",
                    Description = "6 Kişilik",
                    Price = 40,
                    CategoryId = categories.First(x => x.Name.Equals("Kahvaltılar")).Id
                },
                new()
                {
                    Name = "Latte",
                    Price = 10,
                    CategoryId = categories.First(x => x.Name.Equals("Soğuk İçecekler")).Id
                },
                new()
                {
                    Name = "Americano",
                    Price = 10,
                    CategoryId = categories.First(x => x.Name.Equals("Soğuk İçecekler")).Id
                },
                new()
                {
                    Name = "Expresso",
                    Price = 10,
                    CategoryId = categories.First(x => x.Name.Equals("Soğuk İçecekler")).Id
                },
                new()
                {
                    Name = "Cold Brew",
                    Price = 10,
                    CategoryId = categories.First(x => x.Name.Equals("Soğuk İçecekler")).Id
                },
                new()
                {
                    Name = "Çay",
                    Price = 10,
                    CategoryId = categories.First(x => x.Name.Equals("Sıcak İçecekler")).Id
                },
                new()
                {
                    Name = "Ihlamur",
                    Price = 10,
                    CategoryId = categories.First(x => x.Name.Equals("Sıcak İçecekler")).Id
                },
            };
        }
    }
}