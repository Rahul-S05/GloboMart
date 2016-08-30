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
    public class ProductDeleteControllerTest
    {
        [TestInitialize]
        public void init()
        {
            IoC.Initialize();

        }
        [TestMethod]
        public void DeleteProduct()
        {
            //Arrange
            IProductRepository service = IoC.container.GetInstance<MockProductService>();

            var productDeleteController = new ProductDeleteController(service);
            Product product = new Product();
            product.Id = 1;

            var expectedResult = true;

            // act
            var result = productDeleteController.Post(product) as OkNegotiatedContentResult<bool>;

            //assert
            Assert.AreEqual(result.Content, expectedResult);
        }
    }
}
