using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Deposit
    {
        public void deposit()
        {
            Console.WriteLine("Enter the amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Account Number: ");
            var accNo = Console.ReadLine();
            var accountNumber = CreateAccount.accounts.FirstOrDefault(x => x.AccountNumber == accNo);
            if (accountNumber == null)
            {
                Console.WriteLine("Account does not exist.");
            }
            else
            { 
                accountNumber.Balance += amount;
                Console.WriteLine("Deposit Successful!");
            }


            Transaction.AllTransactions.Add(new Transaction
            {
               Date = DateTime.Now,
                Description = "Deposit",
               Amount = amount,
               Balance = accountNumber.Balance
            });
        }

    }
}
