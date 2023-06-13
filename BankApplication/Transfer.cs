using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Transfer
    {   
        public void transfer()
        {
            Console.WriteLine("Enter the amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Destination Account Number: ");
            var destinationAccNo = Console.ReadLine();
            var destinationAccount = CreateAccount.accounts.FirstOrDefault(x => x.AccountNumber == destinationAccNo);

         /*   if (destinationAccount != null)
            {
                Console.WriteLine("Enter the amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine($"My Balance Before: {accountNumber.Balance}");
                Console.WriteLine($"Recipient Balance before: {destinationAccount.Balance}");
                accountNumber.Balance -= amount;
                destinationAccount.Balance += amount;
                Console.WriteLine("Transfer Successful!");
                Console.WriteLine($"My Balance After: {accountNumber.Balance}");
                Console.WriteLine($"Recipient Balance After: {destinationAccount.Balance}");

                accountNumber.Transaction.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Description = $"Transfer To {destinationAccount.AccountNumber} ",
                    Amount = amount,
                    Balance = accountNumber.Balance
                });

                destinationAccount.Transaction.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Description = $"Transfer from {account.AccountNumber} ",
                    Amount = amount,
                    Balance = account.Balance
                });
            }
            else
            {
                Console.WriteLine("Destination account Number not found");
            }


        }*/
    }
    }
}
