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
    public class ProductSelectControllerTest
    {
        [TestInitialize]
        public void init()
        {
            IoC.Initialize();

        }
        [TestMethod]
        public void SelectAllProduct()
        {
            //Arrange
            IProductRepository service = IoC.container.GetInstance<MockProductService>();

            var productSelectController = new ProductSelectController(service);
            int expectedResult = 0;

            // act
            var result = productSelectController.Get() as OkNegotiatedContentResult<List<Product>>;

            //assert
            Assert.IsTrue(result.Content.Count > expectedResult, "Get the list of products");
        }

        [TestMethod]
        public void SelectProductById()
        {
            //Arrange
            IProductRepository service = IoC.container.GetInstance<MockProductService>();
            var productSelectController = new ProductSelectController(service);
            var expectedResult = 1;

            // act
            var result = productSelectController.Get(expectedResult) as OkNegotiatedContentResult<Product>;

            //assert
            Assert.AreEqual(expectedResult, result.Content.Id);
        }
    }
}
