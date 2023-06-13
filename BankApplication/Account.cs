using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        public AccountType  accountType{ get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string FullName { get; set; }
    }

    public enum AccountType
    {
        savings = 1, current = 2
    }
 }

