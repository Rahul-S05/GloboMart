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
    public class ProductUpdateController : ApiController
    {
         private readonly IProductRepository service;

         public ProductUpdateController(IProductRepository service)
        {
            this.service = service;
        }
        
        /// <summary>
        /// Update product information
        /// </summary>
        /// <param name="request">Product Object</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Update")]
         public IHttpActionResult Post([FromBody]Product request)
        {
            var result = service.Update(request);
            return Ok(result);

        }
    }
}
