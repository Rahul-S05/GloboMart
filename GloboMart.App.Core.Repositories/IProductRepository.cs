using GloboMart.App.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.App.Core.Repositories
{
    public interface IProductRepository
    {
        bool Create(Product product);
        bool Update(Product product);
        bool Delete(Product product);
        List<Product> Select();
        Product SelectById(int Id);
    }
}
