using System.Web.Http.Dispatcher;
using StructureMap;
using StructureMap.Configuration.DSL;
using GloboMart.App.Core.Repositories;
using GloboMart.App.Core.DomainModels;
using GloboMart.App.DataAccess;
using GloboMart.App.Core.Services;


namespace GloboMart.App.Api.DependencyResolution
{
    public class IoCRegistry : Registry
    {
        public IoCRegistry()
        {
            // Register all types
            For<IProductRepository>().Use<ProductService>();
            For<IProductTypeRepository>().Use<ProductTypeService>();
            For<IDataAccessRepository<Product>>().Use<ProductDataAccess>();
            For<IDataAccessRepository<ProductType>>().Use<ProductTypeDataAccess>();
        }
    }
}