using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboMart.App.Core.DomainModels;

namespace GloboMart.App.DataAccess.CustomDbContext
{
    class GloboMartAppDbContext : DbContext
    {
        public GloboMartAppDbContext()
            : base("name=GloboMartAppDbContext")
        {
            Database.SetInitializer(new DBInitializer());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        private class DBInitializer : CreateDatabaseIfNotExists<GloboMartAppDbContext>
        {

            protected override void Seed(GloboMartAppDbContext context)
            {

                IList<ProductType> productTypes = new List<ProductType>();

                productTypes.Add(new ProductType()
                {
                    Name = "Food",
                    Description = "Food",
                    Created = DateTime.Now.ToShortDateString(),
                    Creator = "Admin"
                });

                productTypes.Add(new ProductType()
                {
                    Name = "Food",
                    Description = "Food",
                    Created = DateTime.Now.ToShortDateString(),
                    Creator = "Admin"
                });

                productTypes.Add(new ProductType()
                {
                    Name = "Electronics",
                    Description = "Electronics",
                    Created = DateTime.Now.ToShortDateString(),
                    Creator = "Admin"
                });
                productTypes.Add(new ProductType()
                {
                    Name = "Clothing",
                    Description = "Clothing",
                    Created = DateTime.Now.ToShortDateString(),
                    Creator = "Admin"
                });
                productTypes.Add(new ProductType()
                {
                    Name = "Stationery",
                    Description = "Stationery",
                    Created = DateTime.Now.ToShortDateString(),
                    Creator = "Admin"
                });
                productTypes.Add(new ProductType()
                {
                    Name = "Appliances",
                    Description = "Appliances",
                    Created = DateTime.Now.ToShortDateString(),
                    Creator = "Admin"
                });

                foreach (ProductType productType in productTypes)
                    context.ProductTypes.Add(productType);
                base.Seed(context);
            }
        }
    }
}
