using GloboMart.App.Core.DomainModels;
using GloboMart.App.Core.Repositories;
using GloboMart.App.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GloboMart.App.Api.Controllers
{
    [RoutePrefix("api/Product")]
    public class ProductSelectController : ApiController
    {
        private readonly IProductRepository service;

        public ProductSelectController(IProductRepository service)
        {
            this.service = service;
        }

        /// <summary>
        /// Select All products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("select")]
        public IHttpActionResult Get()
        {
            var result = service.Select();
            return Ok(result);

        }

        /// <summary>
        /// Select product w.r.t its Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("SelectById")]
        public IHttpActionResult Get(int Id)
        {
            var result = service.SelectById(Id);
            return Ok(result);

        }
    }
}
