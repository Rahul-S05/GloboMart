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
    public class ProductDataAccess : IDataAccessRepository<Product>
    {
        public bool Create(Product product)
        {
            using (var db = new GloboMartAppDbContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
                return true;
            }
        }

        public bool Update(Product product)
        {
            using (var db = new GloboMartAppDbContext())
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
        }

        public bool Delete(Product product)
        {
            using (var db = new GloboMartAppDbContext())
            {
                db.Entry(product).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
        }

        public List<Product> Select()
        {
            using (var db = new GloboMartAppDbContext())
            {
                var lstProduct = db.Products.ToList();
                ProductType productType = null;
                foreach (Product product in lstProduct)
                {
                    productType = new ProductType();
                    productType = db.ProductTypes.Where(pt => pt.Id == product.ProductTypeId).FirstOrDefault();
                    product.ProductType = productType;
                }
                return lstProduct;
            }
        }

        public Product SelectById(int Id)
        {
            using (var db = new GloboMartAppDbContext())
            {
                var product = db.Products.Where(e => e.Id == Id).FirstOrDefault();
                ProductType productType = db.ProductTypes.Where(pt => pt.Id == product.ProductTypeId).FirstOrDefault();
                product.ProductType = productType;
                return product;
            }
        }
    }
}
