using MicroRabbit.Banco.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banco.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAcconunts();
    }
}
