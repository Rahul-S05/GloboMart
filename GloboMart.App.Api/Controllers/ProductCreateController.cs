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
    public class ProductCreateController : ApiController
    {
        private readonly IProductRepository service;

        public ProductCreateController(IProductRepository service)
        {
            this.service = service;
        }

        /// <summary>
        /// create a new product
        /// </summary>
        /// <param name="request">product object</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Create")]
        public IHttpActionResult Post([FromBody] Product request)
        {
            try
            {
                var result = service.Create(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);

            }

        }
    }
}
