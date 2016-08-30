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
    public class ProductTypeService : IProductTypeRepository
    {
        private readonly IDataAccessRepository<ProductType> productTypeDataAccess;

        public ProductTypeService(IDataAccessRepository<ProductType> productTypeDataAccess)
        {
            // creating instance of dataaccess file with app config values
            this.productTypeDataAccess = productTypeDataAccess;

        }
        public bool Create(ProductType productType)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductType productType)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ProductType productType)
        {
            throw new NotImplementedException();
        }

        List<ProductType> IProductTypeRepository.Select()
        {
            return productTypeDataAccess.Select();
        }

        ProductType IProductTypeRepository.SelectById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
