using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.BankTransaction
{

    internal class BankWithdrawal : User_Registration
    {
        public int Amount;

        public void withdrawal()
        {
            Console.Clear();
            Console.WriteLine("Withdraw Funds");

            Console.WriteLine("Enter account number: ");
            string AccountNumber = Console.ReadLine();

            Customer customer = ValidateAccountNumber(AccountNumber);

            if (customer == null)
            {
                Console.WriteLine("Invalid Account Number! Please try again. ");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Enter amount to withdraw: ");
            Amount = Convert.ToInt32(Console.ReadLine());

            //  if (customer.AccountType == "Savings" && (customer.Balance - Amount) < 1000)
            do
            {
                Console.WriteLine("Insufficient balance. Minimum balance requirement for savings account is 1000.");
                Console.ReadLine();
                //return;
            } while (customer.AccountType == "Savings" && (customer.Balance - Amount) < 1000);

            customer.Balance -= Amount;

            Console.WriteLine($"Your new balance is: {customer.Balance}");
            Console.WriteLine();
            Console.WriteLine("View your details below");

            Console.WriteLine($"FirstName: {customer.FirstName}");
            Console.WriteLine($"LastName: {customer.LastName}");
            Console.WriteLine($"FullName: {customer.FirstName} {customer.LastName}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"AccountNumber: {customer.AccountNumber}");
            Console.WriteLine($"AccountType: {customer.AccountType}");
            Console.WriteLine($"Balance: {customer.Balance}");
            Console.WriteLine("");
            Console.WriteLine("Enter 1 to go back to MainMenu");
            string choice = Console.ReadLine();

            do
            {
                Console.WriteLine("Invalid input! Please enter 1 to go back to MainMenu");
                choice = Console.ReadLine();
            } while (choice != "1");

                var menu = new BankDashBoard();
            menu.DashBoard();
        }
        private Customer ValidateAccountNumber(string AccountNumber)
        {
            foreach (var item in customers)
            {
                if (item.AccountNumber == AccountNumber)
                {
                    return item;
                }
            }
            return null;
        }
    }
}




