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
    public class WithdrawController : ControllerBase
    {
        private MyDbContext dbContext;

        public WithdrawController(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult POST([FromBody] Withdraw withdraw)
        {

            var accounts = this.dbContext.Accounts.FirstOrDefault(acc => acc.accountNumber == withdraw.accountNumber);

            if (accounts != null)
            {
                this.dbContext.Withdraws.Add(withdraw);
                this.dbContext.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Created("Get", withdraw);

        }
    }
}
