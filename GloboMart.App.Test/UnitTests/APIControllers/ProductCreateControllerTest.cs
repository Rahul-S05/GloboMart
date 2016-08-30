using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using GloboMart.App.Api.Controllers;
using GloboMart.App.Core.DomainModels;
using GloboMart.App.Test.DependencyResolution;
using GloboMart.App.Core.Repositories;
using System.Web.Http.Results;
using GloboMart.App.Test.Mocks;

namespace GloboMart.App.Test.UnitTests.APIControllers
{
    [TestClass]
    public class ProductCreateControllerTest
    {
        [TestInitialize]
        public void init()
        {
            IoC.Initialize();

        }
        [TestMethod]
        public void CreateProduct()
        {
            //Arrange
            IProductRepository service = IoC.container.GetInstance<MockProductService>();

            var productCreateController = new ProductCreateController(service);
            Product product = new Product();
            product.Name = "Cake";
            product.Description = "Veg Cake 1 kg";
            product.Barcode = "BAR102150";
            product.Price = 200;
            product.Created = DateTime.Now.ToShortDateString();
            product.Creator = "Admin";
            product.IsActive = true;

            var expectedResult = true;

            // act
            var result = productCreateController.Post(product) as OkNegotiatedContentResult<bool>;

            //assert
            Assert.AreEqual(result.Content, expectedResult);
        }


    }
}
