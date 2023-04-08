using CleanArchitect.Demo.API.Models;
using CleanArchitectDemo.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitect.Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ITransferMoneyUseCase _transferMoneyUseCase;

        public AccountsController(ITransferMoneyUseCase transferMoneyUseCase)
        {
            _transferMoneyUseCase = transferMoneyUseCase;
        }

        [HttpPost("transfer")]
        public async Task<IActionResult> TransferAsync(TransferMoneyDto transferMoneyDto)
        {
            try
            {
                await _transferMoneyUseCase.TransferAmountAsync(transferMoneyDto.AccountIdFrom, transferMoneyDto.AccountIdTo, transferMoneyDto.Amount);

                return Ok("Amount Transferred succesffully");
            }
            catch (Exception Ex)
            {

                throw new Exception( Ex.StackTrace);
            }
        }
    }
}
