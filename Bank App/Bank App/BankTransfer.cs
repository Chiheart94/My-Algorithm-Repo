using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    internal class BankTransfer : User_Registration
    {
        public void Transfer()
        {
            Console.Clear();
            Console.WriteLine("Transfer Funds");
            Console.WriteLine();

            Console.WriteLine("Select Account to debit: ");
            string depositAccountNumber = Console.ReadLine();

            Customer depositCustomer = ValidateAccountNumber(depositAccountNumber);

            if (depositCustomer == null)
            {
                Console.WriteLine("Invalid Account Number! Please try again");
                Console.ReadLine();
             return;
            }

            Console.WriteLine("Select Account to debit: ");
            string receiveAccountNumber = Console.ReadLine();

            Customer receiveCustomer = ValidateAccountNumber(receiveAccountNumber);

            if (receiveCustomer == null)
            {
                Console.WriteLine("Invalid Account Number! Please try again");
                Console.ReadLine();
                return;
            }
            Console.Write("Enter amount to transfer: ");
            int amount = Convert.ToInt32(Console.ReadLine());



            // Check if the deposit account has sufficient balance
            if (depositCustomer.Balance < amount)
            {
                Console.WriteLine("Insufficient balance in the deposit account.");
                Console.ReadLine(); // Add a pause before returning to the BankMenu
                return;
            }

            depositCustomer.Balance -= amount;
            receiveCustomer.Balance += amount;


            Console.WriteLine("Transfer successful.");
            Console.WriteLine();
            Console.WriteLine("Deposit Account Details");
            Console.WriteLine($"AccountNumber: {depositCustomer.AccountNumber}");
            Console.WriteLine($"FirstName: {depositCustomer.FirstName}");
            Console.WriteLine($"LastName: {depositCustomer.LastName}");
            Console.WriteLine($"FullName: {depositCustomer.FirstName} {depositCustomer.LastName}");
            Console.WriteLine($"Email: {depositCustomer.Email}");          
            Console.WriteLine($"AccountType: {depositCustomer.AccountType}");
            Console.WriteLine($"Balance: {depositCustomer.Balance}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Deposit Account Details");
            Console.WriteLine($"AccountNumber: {receiveCustomer.AccountNumber}");
            Console.WriteLine($"FirstName: {receiveCustomer.FirstName}");
            Console.WriteLine($"LastName: {receiveCustomer.LastName}");
            Console.WriteLine($"FullName: {receiveCustomer.FirstName} {depositCustomer.LastName}");
            Console.WriteLine($"Email: {receiveCustomer.Email}");
            Console.WriteLine($"AccountType: {receiveCustomer.AccountType}");
            Console.WriteLine($"Balance: {receiveCustomer.Balance}");
            Console.WriteLine("");
            Console.WriteLine("Enter 1 to go back to MainMenu ");
            string choice = Console.ReadLine();

            if(choice == "1")
            {
                var menu = new BankDashBoard();
                menu.DashBoard();
            }
        
        }
        private Customer ValidateAccountNumber(string accountNumber)
        {
            foreach(var item in customers)
            {
                if(item.AccountNumber == accountNumber)
                {
                    return item;
                }
            }
            return null;
        }
      
    }
}

