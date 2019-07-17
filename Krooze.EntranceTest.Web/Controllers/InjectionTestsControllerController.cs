using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Tests.InjectionTests;
using Microsoft.AspNetCore.Mvc;

namespace Krooze.EntranceTest.Web.Controllers
{
    [Route("api/InjectionTests")]
    [ApiController]
    public class InjectionTestsControllerController : Controller
    {
        // GET api/InjectionTests
        [HttpGet("{CompanyID}")]
        public ActionResult<List<CruiseDTO>> GetCruises(int CompanyID)
        {
            CruiseRequestDTO request = new CruiseRequestDTO();
            request.CruiseCompanyCode = CompanyID;
            return new InjectionTest().GetCruises(request);
        }
    }
}