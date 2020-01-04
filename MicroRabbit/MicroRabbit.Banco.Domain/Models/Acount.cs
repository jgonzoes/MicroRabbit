using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banco.Domain.Models
{
   public class Account
    {
        public int IsType { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance{ get; set; }
    }
}
