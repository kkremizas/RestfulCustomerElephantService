using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestfulCustomerElephantService.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestfulCustomerElephantService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ElephantsController : ControllerBase
    {
        private List<Elephant> _dbList;

        public ElephantsController()
        {
            _dbList = FakeDBRepo.elps;
        }

        // GET: api/<ElephantsController>
        [HttpGet]
        public List<Elephant> Get()
        {
            return _dbList;
        }

        // GET api/<ElephantsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var elephant = GetElephantById(id);
            if (elephant != null)
            {
                return Ok(elephant);
            }
            else
            {
                return NotFound(new {message = "Id is not found"});
            }


        }

        // POST api/<ElephantsController>
        [HttpPost]
        public IActionResult Post([FromBody] Elephant newElephant)
        {
            _dbList.Add(newElephant);
            return CreatedAtAction("Get", new {id = newElephant.Id}, newElephant);
        }

        // PUT api/<ElephantsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ElephantsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public Elephant GetElephantById(int id)
        {
            var elephant = _dbList.FirstOrDefault(e => e.Id == id);
            return elephant;
        }
    }
}
