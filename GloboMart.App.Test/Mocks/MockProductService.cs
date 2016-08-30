using GloboMart.App.Core.Repositories;
using GloboMart.App.Core.DomainModels;
using GloboMart.App.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using StructureMap;
using GloboMart.App.Test.DependencyResolution;

namespace GloboMart.App.Test.Mocks
{
    public class MockProductService : IProductRepository
    {
        private readonly IDataAccessRepository<Product> productDataAccess;

        public MockProductService()
        {
            // creating instance of dataaccess file with app config values
            this.productDataAccess = IoC.container.GetInstance<MockProductDataAccess>();

        }

        /// <summary>
        /// insert the enterprise in the database
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public bool Create(Product product)
        {
            bool result = false;
            // inserting Product record in the provide database
            result = productDataAccess.Create(product);

            return result;
        }

        /// <summary>
        /// updating the worker record
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public bool Update(Product product)
        {
            var result = productDataAccess.Update(product);
            return result;
        }

        /// <summary>
        /// deleting the worker form database
        /// </summary>
        /// <param name="worker"></param>
        /// <returns></returns>
        public bool Delete(Product product)
        {
            var result = productDataAccess.Delete(product);
            return result;
        }

        /// <summary>
        /// selecting all workers
        /// </summary>
        /// <returns></returns>
        public List<Product> Select()
        {
            var result = productDataAccess.Select();
            return result;
        }

        /// <summary>
        /// selecting worker by its Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Product SelectById(int Id)
        {
            var result = productDataAccess.SelectById(Id);
            return result;
        }
    }
}
