using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TringleAPI.Models
{
    public class Deposit
    {
        [Key]
        public int Id { get; set; }

        public int accountNumber { get; set; }
        public double amount { get; set; }
    }
}
