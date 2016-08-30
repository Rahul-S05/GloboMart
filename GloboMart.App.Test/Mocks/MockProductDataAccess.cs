using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GloboMart.App.Core.DomainModels;
using GloboMart.App.DataAccess.CustomDbContext;
using GloboMart.App.Core.Repositories;

namespace GloboMart.App.Test.Mocks
{
    public class MockProductDataAccess : IDataAccessRepository<Product>
    {
        /// <summary>
        /// Insert an Product in the database
        /// </summary>
        /// <param name="enterprise"></param>
        /// <returns></returns>
        public bool Create(Product product)
        {
            return true;


        }


        /// <summary>
        /// Update the Product record
        /// </summary>
        /// <param name="enterprise"></param>
        /// <returns></returns>
        public bool Update(Product product)
        {

            return true;

        }

        /// <summary>
        /// delete a Product from database
        /// </summary>
        /// <param name="enterprise"></param>
        /// <returns></returns>
        public bool Delete(Product product)
        {

            return true;

        }

        /// <summary>
        /// select all Product present in the database
        /// </summary>
        /// <returns></returns>
        public List<Product> Select()
        {

            Product product = new Product();
            product.Id = 1;
            product.Name = "Cake";
            product.Description = "Veg Cake 1 kg";
            product.Barcode = "BAR102150";
            product.Price = 200;
            product.Created = DateTime.Now.ToShortDateString();
            product.Creator = "Admin";
            product.IsActive = true;

            List<Product> lstProduct = new List<Product>();
            lstProduct.Add(product);
            return lstProduct;

        }


        /// <summary>
        /// selecet an Product w.r.t its Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Product SelectById(int Id)
        {
            Product product = new Product();
            product.Id = 1;
            product.Name = "Cake";
            product.Description = "Veg Cake 1 kg";
            product.Barcode = "BAR102150";
            product.Price = 200;
            product.Created = DateTime.Now.ToShortDateString();
            product.Creator = "Admin";
            product.IsActive = true;
            return product;
        }
    }
}
