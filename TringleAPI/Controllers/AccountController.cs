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
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private MyDbContext dbContext;

   

        public AccountController(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        
        }
 

        [HttpGet("{accountNumber}")]
        public IActionResult GET(int accountNumber)
        {
            return Ok(this.dbContext.Accounts.FirstOrDefault(a => a.accountNumber == accountNumber));
        }

        [HttpPost]
        public IActionResult POST([FromBody] Account account)
        {
            this.dbContext.Accounts.Add(account);
            this.dbContext.SaveChanges();
            return Created("Get", account);
        }
    }
}
