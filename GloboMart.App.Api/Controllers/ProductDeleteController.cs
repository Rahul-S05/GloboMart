using GloboMart.App.Core.DomainModels;
using GloboMart.App.Core.Repositories;
using GloboMart.App.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GloboMart.App.Api.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductDeleteController : ApiController
    {
        private readonly IProductRepository service;

        public ProductDeleteController(IProductRepository service)
        {
            this.service = service;
        }

        /// <summary>
        /// Delete a product from DB
        /// </summary>
        /// <param name="request">Product object</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Delete")]
        public IHttpActionResult Post([FromBody]Product request)
        {
            //var service = new EnterpriseService();
            var result = service.Delete(request);
            return Ok(result);

        }
    }
}
