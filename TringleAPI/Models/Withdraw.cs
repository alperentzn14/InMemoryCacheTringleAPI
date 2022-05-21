using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TringleAPI.Models
{
    public class Withdraw
    {
        [Key]
        public int Id { get; set; }
        public int accountNumber { get; set; }
        public double amount { get; set; }
    }
}
