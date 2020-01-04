using MicroRabbit.Banco.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banco.Aplication.Interfaces
{
    interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
