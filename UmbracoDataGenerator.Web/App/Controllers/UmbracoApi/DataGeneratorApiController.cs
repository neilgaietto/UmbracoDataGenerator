using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Web.Mvc;
using UmbracoDataGenerator.Library.Services.Interfaces;

namespace UmbracoDataGenerator.Web.App.Controllers.UmbracoApi
{
    [PluginController("Generator")]
    public class DataGeneratorApiController : BaseUmbracoApiController
    {
        private readonly IGeneratorService _generatorService;

        public DataGeneratorApiController(IGeneratorService generatorService)
        {
            _generatorService = generatorService;
        }

        [HttpPost] // POST umbraco/backoffice/Generator/DataGeneratorApi/CreateNodes
        public IHttpActionResult CreateNodes()
        {
            _generatorService.Create("test", 1);

            return Ok();
        }
    }
}