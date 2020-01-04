using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Banco.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banco.Data.Context
{
    public class BankingDbContex : DbContext
    {
        public BankingDbContex(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

    }
}
