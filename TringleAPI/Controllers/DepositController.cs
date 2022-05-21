using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TringleAPI.Context;
using TringleAPI.Models;

namespace TringleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepositController : ControllerBase
    {
        private MyDbContext dbContext;

        public DepositController(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult POST([FromBody] Deposit deposit)
        {

            var accounts = this.dbContext.Accounts.FirstOrDefault(acc => acc.accountNumber == deposit.accountNumber);

            if (accounts != null)
            {
                this.dbContext.Deposits.Add(deposit);
                this.dbContext.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Created("Get", deposit);

        }
    }
}
