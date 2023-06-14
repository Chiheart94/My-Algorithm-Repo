using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Withdrawal
    {
        public void withdrawal()
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
                accountNumber.Balance -= amount;
                Console.WriteLine("Withdrawal Successful!");
            }

            Transaction.AllTransactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Description = "Withdraw",
                Amount = amount,
                Balance = accountNumber.Balance
            });
        }
    }
}
