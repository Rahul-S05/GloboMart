using GloboMart.App.Core.DomainModels;
using GloboMart.App.Core.Repositories;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.App.Core.Services
{
    public class ProductService : IProductRepository
    {
        private readonly IDataAccessRepository<Product> productDataAccess;

        public ProductService(IDataAccessRepository<Product> productDataAccess)
        {
            // creating instance of dataaccess file with app config values
            this.productDataAccess = productDataAccess;

        }


        public bool Create(Product product)
        {
            bool result = false;

            product.IsActive = true;
            product.Creator = "Admin";
            product.Created = DateTime.Now.ToShortDateString();
            // inserting Product record in the provide database
            result = productDataAccess.Create(product);
            return result;
        }

        public bool Update(Product product)
        {
            product.Last_editor = "Admin";
            product.Modified = DateTime.Now.ToShortDateString();
            var result = productDataAccess.Update(product);
            return result;
        }

        public bool Delete(Product product)
        {
            var result = productDataAccess.Delete(product);
            return result;
        }

        public List<Product> Select()
        {
            var result = productDataAccess.Select();
            return result;
        }

        public Product SelectById(int Id)
        {
            var result = productDataAccess.SelectById(Id);
            return result;
        }
    }
}
