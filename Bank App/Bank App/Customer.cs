 using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    internal class Customer
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        public string AccountNumber;
        public string AccountType;
        public decimal Balance;



        public Customer(string FirstName, string LastName, string Email, string Password, string AccountNumber, string AccountType, decimal Balance)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Password = Password;
            this.AccountNumber = AccountNumber;
            this.AccountType = AccountType;
            this.Balance = Balance;
        }
    }
}
