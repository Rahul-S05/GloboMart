using GloboMart.App.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.App.Core.Repositories
{
    public interface IProductTypeRepository
    {
        bool Create(ProductType productType);
        bool Update(ProductType productType);
        bool Delete(ProductType productType);
        List<ProductType> Select();
        ProductType SelectById(int Id);
    }
}
