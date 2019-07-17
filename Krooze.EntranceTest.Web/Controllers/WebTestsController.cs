using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Krooze.EntranceTest.WriteHere.Tests.WebTests;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Krooze.EntranceTest.Web.Controllers
{
    [ApiController]
    public class WebTestsController : Controller
    {
        //GET api/WebTests/GetAllMovies
        [HttpGet]
        [Route("api/WebTests/GetAllMovies")]
        public ActionResult<JObject> GetAllMovies()
        {
            return new WebTest().GetAllMovies();
        }

        // Post api/WebTests
        [HttpGet]
        [Route("api/WebTests/GetDirector")]
        public ActionResult<string> GetDirector()
        {
            return new WebTest().GetDirector();
        }
    }
}