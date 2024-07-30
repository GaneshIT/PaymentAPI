using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentData.Repository;
using PaymentModel;

namespace PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactions _transactions;
        public TransactionsController(ITransactions transactions)
        {
            _transactions = transactions;
        }
        [HttpGet("Get")]
        public IActionResult Get(int transactionid)
        {
            var result = _transactions.Get(transactionid);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Create(Transactions t)
        {
            _transactions.Create(t);
            return Ok("Inserted");
        }
        [HttpPut]
        public IActionResult Update(Transactions t)
        {
            _transactions.Update(t);
            return Ok("Updated");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _transactions.Delete(id);
            return Ok("Inserted");
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result=_transactions.GetAll();
            return Ok(result);
        }
    }
}
