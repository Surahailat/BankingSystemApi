using BankingSystemApi.DTO;
using BankingSystemApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankingSystemApi.Controllers
{
    [ApiController]
    [Route("bankaccounts")]
    public class BankAccountsController : ControllerBase
    {


        private readonly IBankAccountService _bankAccountService;

        public BankAccountsController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        // POST /bankaccounts
        [HttpPost]
        public IActionResult CreateBankAccount([FromBody] CreateBankAccountRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (request == null)
                return BadRequest();

            var result =  _bankAccountService.CreateBankAccountAsync(request);
            return Ok(result);
        }

        // GET /bankaccounts/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBankAccountById(int id)
        {
            var result = await _bankAccountService.GetBankAccountByIdAsync(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
