using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class DemoController : ControllerBase
    {
        static List<string> Countries = new List<string> { "India", "USA", "UK", "Japan,", "France" };

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Countries;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK,Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            if(id >= Countries.Count)
            {
                return NotFound();
            }
            string country = Countries[id];
            return Ok(country);
        }
        //post api/valuecontroller

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]

        public IActionResult Post([FromBody] string value)
        {
            Countries.Add(value);
            int id = Countries.Count - 1;
            return Created("https://localhost:44393/api/demo/" + id, value);
        }
        //put api/<valuecontroller>/5

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult Put(int id, [FromBody] string value)
        {
            if(id >= Countries.Count)
            {
                return NotFound();
            }
            Countries[id] = value;
            return NoContent();
        }

        //delete api/<valuecontroller>/5

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public IActionResult Delete(int id)
        {
            if(id >= Countries.Count)
            {
                return NotFound();
            }
            Countries.RemoveAt(id);
            return NoContent();
        }
    }
}
