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
    public class PaymentController : ControllerBase
    {
        private MyDbContext dbContext;

        public PaymentController(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult POST([FromBody] Payment payment)
        {

            var accounts = this.dbContext.Accounts.FirstOrDefault(acc => acc.accountNumber == payment.receiverAccount);

            if (accounts != null) { 
                this.dbContext.Payments.Add(payment);
                this.dbContext.SaveChanges();
            }
            else
            {
                return NotFound();
            }
            return Created("Get", payment);
           
        }
            
           
        
    }
}
