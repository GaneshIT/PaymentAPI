using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        [HttpGet("Get")]
        public IActionResult Get(int transactionid)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Create()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
