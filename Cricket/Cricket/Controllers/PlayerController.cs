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
    public class PlayerController : ControllerBase
    {
        // GET: api/Country
        private readonly CricketContext _cricketcontext;
        public PlayerController(CricketContext cricketP)
        {
            _cricketcontext = cricketP;
        }
        [HttpGet]
        public IActionResult Get3()
        {
            var getPlayer = _cricketcontext.Players.ToList();
            return Ok(getPlayer);
        }

        // GET: api/Player/5
        /* [HttpGet("{id}", Name = "Get")]
         public string Get(int id)
         {
             return "value";
         }

         // POST: api/Player
         [HttpPost]
         public void Post([FromBody] string value)
         {
         }

         // PUT: api/Player/5
         [HttpPut("{id}")]
         public void Put(int id, [FromBody] string value)
         {
         }

         // DELETE: api/ApiWithActions/5
         [HttpDelete("{id}")]
         public void Delete(int id)
         {
         }*/
    }
}
