using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TringleAPI.Models
{
    public class TransactionHistory
    {
        [Key]
        public int Id { get; set; }
        public int accountNumber { get; set; }
        public double amount { get; set; }
        public DateTime createdAt { get; set; }

        [Newtonsoft.Json.JsonConverter(typeof(JsonStringEnumConverter))]
        public TransactionType transactionType { get; set; }
        
        public enum TransactionType
        {
            payment = 0,
            deposit = 1,
            withdraw=2
        }
    }
}
