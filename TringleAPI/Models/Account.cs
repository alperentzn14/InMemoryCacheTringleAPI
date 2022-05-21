using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json; 
using Newtonsoft.Json.Converters;

namespace TringleAPI.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public int accountNumber { get; set; }
        public string ownerName { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(JsonStringEnumConverter))]
        public CurrencyCode currencyCode { get; set; }
        [Newtonsoft.Json.JsonConverter(typeof(JsonStringEnumConverter))]
        public AccountType accountType { get; set; }
        public double balance { get; set; }

        public enum CurrencyCode
        {
            TRY=0,
            USD=1,
            EURO=2
        }
        public enum AccountType
        {
            individual=0,
            corporate=1
        }
    }
}
