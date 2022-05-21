using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TringleAPI.Context;

namespace TringleAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountingController : ControllerBase
    {
        private MyDbContext dbContext;

        public AccountingController(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("{accountNumber}")]
        public IActionResult GET(int accountNumber)
        {

            return Ok(this.dbContext.TransactionHistories.FirstOrDefault(a => a.accountNumber == accountNumber));
        }
    }
}
