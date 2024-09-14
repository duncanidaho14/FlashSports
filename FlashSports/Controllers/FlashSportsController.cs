using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlashSports.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashSportsController : ControllerBase
    {
        #region methods
        // GET: api/sports-list
        [HttpGet]
        public IActionResult GetSports()
        {
            var model = Enumerable.Range(1, 10).Select(item => new FlashSports());

            return this.StatusCode(StatusCodes.Status204NoContent);
        }

        // GET api/sports/{id}
        [HttpGet("{id}")]
        public string GetSport(int id)
        {
            return "1";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion
    }
}
