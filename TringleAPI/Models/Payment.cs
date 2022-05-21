using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TringleAPI.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public int senderAccount { get; set; }
        public int receiverAccount { get; set; }
        public double amount { get; set; }
    }
}
