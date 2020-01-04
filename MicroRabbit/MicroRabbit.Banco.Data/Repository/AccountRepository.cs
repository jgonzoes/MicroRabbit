using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Banco.Data.Context;
using MicroRabbit.Banco.Domain.Interfaces;
using MicroRabbit.Banco.Domain.Models;

namespace MicroRabbit.Banco.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContex _ctx;

        public AccountRepository(BankingDbContex ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Account> GetAcconunts()
        {
            throw new NotImplementedException();
        }
    }
}
