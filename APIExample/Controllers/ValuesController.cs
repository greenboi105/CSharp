using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<string> _values = new List<string>
        {
            "Value 1",
            "Value 2",
            "Value 3"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_values);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 0 || id >= _values.Count)
                return NotFound();

            return Ok(_values[id]);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            _values.Add(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            if (id < 0 || id >= _values.Count)
                return NotFound();

            _values[id] = value;
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id < 0 || id >= _values.Count)
                return NotFound();

            _values.RemoveAt(id);
            return Ok();
        }
    }
}
