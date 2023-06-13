using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class CreateAccount
    {
        public string choice;
        public static List<Account> accounts = new List<Account>();
        public string AccountNumber()
        {
            Console.WriteLine("Enter 1 to create a savings account or 2 to create a current account:  ");
            choice = Console.ReadLine();

            if(choice == "1")
            {
                Random random = new Random();
                string accountNumber = random.Next(1000000000, 1999999999).ToString();
                Account account = new Account
                {
                    accountType = AccountType.savings,
                    AccountNumber = accountNumber,
                    Balance = 0,
                    FullName = ""
                };
                accounts.Add(account);
                Console.WriteLine("Savings Account created successfully");
                Console.WriteLine(accountNumber);
                return accountNumber;
            }
            else if(choice == "2")
            {
                Random random = new Random();
                string accountNumber = random.Next(1000000000, 1999999999).ToString();
                Account account = new Account
                {
                    accountType = AccountType.current,
                    AccountNumber = accountNumber,
                    Balance = 0,
                    FullName = ""
                };
                accounts.Add(account);
                Console.WriteLine("Current Account created successfully");
                Console.WriteLine(accountNumber);
                return accountNumber;
            }
            else
            {
                throw new ArgumentException("Invalid choice. Please enter either 1 for savings account or 2 for current account.");
            }


            return string.Empty;
        }
       
           

    }
}
