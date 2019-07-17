using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Krooze.EntranceTest.Tests;
using Krooze.EntranceTest.WriteHere.Structure.Model;
using Krooze.EntranceTest.WriteHere.Tests.LogicTests;
using Microsoft.AspNetCore.Mvc;

namespace Krooze.EntranceTest.Web.Controllers
{
    [Route("api/LogicTests")]
    [ApiController]
    public class LogicTestsController : Controller
    {
        // GET api/LogicTests
        [HttpGet]
        public ActionResult<CruiseDTO> GetXML()
        {
            return new XMLTest().TranslateXML();
        }

        // GET api/LogicTests/10000/1000/12000
        [HttpGet("{cabinValue}/{portChange}/{totalValue}")]
        public ActionResult<decimal?> GetOtherTaxes(decimal cabinValue, decimal portChange, decimal totalValue)
        {
            return new LogicTests().OtherTaxes(cabinValue, portChange, totalValue);
        }

        // GET api/LogicTests/1000/700
        [HttpGet("{firstPassenger}/{secondPassenger}")]
        public ActionResult<bool?> IsThereDiscount(decimal firstPassenger, decimal secondPassenger)
        {
            return new LogicTests().Discount(firstPassenger, secondPassenger);
        }

        // GET api/LogicTests/400
        [HttpGet("{fullPrice}")]
        public ActionResult<int?> GetInstallments(decimal fullPrice)
        {
            return new LogicTests().Installments(fullPrice);
        }

    }
}