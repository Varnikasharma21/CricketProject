using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cricket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cricket.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        // GET: api/Country
        private readonly CricketContext _cricketcontext;
        public CountryController(CricketContext cricketP)
        {
            _cricketcontext = cricketP;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var getCountry = _cricketcontext.Country.ToList();
            return Ok(getCountry);
        }

        // GET: api/Country/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Country
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Country/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
