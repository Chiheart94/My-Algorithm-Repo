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
        public void TransferMoney()
        {
            Console.WriteLine("Enter the amount: ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Destination Account Number: ");
            var ReceiverAccNo = Console.ReadLine();
            Console.WriteLine("Enter Sender's Account Number: ");
            var SenderAccNo = Console.ReadLine();

            var receiver = CreateAccount.accounts.FirstOrDefault(x => x.AccountNumber == ReceiverAccNo);
            var sender = CreateAccount.accounts.FirstOrDefault(x => x.AccountNumber == SenderAccNo);

            if (sender is null || receiver is null)
            {
                Console.WriteLine("Error in Transaction!");
            }
            else
            {
                sender.Balance -= amount;
                receiver.Balance += amount;
                Console.WriteLine("Transfer Successful");
            }
            Transaction.AllTransactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Description = $"Transfer To {ReceiverAccNo}",
                Amount = amount,
                Balance = sender.Balance
            });

            Transaction.AllTransactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Description = $"Transfer From {SenderAccNo}",
                Amount = amount,
                Balance = receiver.Balance
            });
        }       
      }
    }


