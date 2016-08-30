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
    [RoutePrefix("api/ProductType")]
    public class ProductTypeSelectController : ApiController
    {
        private readonly IProductTypeRepository service;

        public ProductTypeSelectController(IProductTypeRepository service)
        {
            this.service = service;
        }


        /// <summary>
        /// Get all Product Types from database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("select")]
        public IHttpActionResult Get()
        {
            var result = service.Select();
            return Ok(result);

        }
    }
}
