using GloboMart.App.Core.DomainModels;
using GloboMart.App.Core.Repositories;
using GloboMart.App.DataAccess.CustomDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.App.DataAccess
{
    public class ProductTypeDataAccess : IDataAccessRepository<ProductType>
    {
        public bool Create(ProductType item)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProductType item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(ProductType item)
        {
            throw new NotImplementedException();
        }

        public List<ProductType> Select()
        {
            using (var db = new GloboMartAppDbContext())
            {
                var lstProductType = db.ProductTypes.ToList();
                return lstProductType;
            }
        }

        public ProductType SelectById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
