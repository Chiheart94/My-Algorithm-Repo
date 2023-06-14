using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class ChechBalance
    {
        public void CheckBal()
        {
             
            Console.WriteLine("Enter Account Number: ");
            var accNo = Console.ReadLine();
            var accountNumber = CreateAccount.accounts.FirstOrDefault(x => x.AccountNumber == accNo);
            if (accountNumber == null)
            {
                Console.WriteLine("Account does not exist.");
            }
            else
            {
                Console.WriteLine($"Your account Balance is {accountNumber.Balance}");
            }

        }
    }
}
