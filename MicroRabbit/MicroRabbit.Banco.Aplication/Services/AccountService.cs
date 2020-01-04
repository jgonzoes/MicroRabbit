using MicroRabbit.Banco.Aplication.Interfaces;
using MicroRabbit.Banco.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using MicroRabbit.Banco.Domain.Interfaces;

namespace MicroRabbit.Banco.Aplication.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAcconunts();
        }
    }
}
