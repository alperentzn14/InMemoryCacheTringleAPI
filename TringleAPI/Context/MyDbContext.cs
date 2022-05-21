using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TringleAPI.Models;

namespace TringleAPI.Context
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
         
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Withdraw> Withdraws { get; set; }
    }
}
