using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.BankTransaction
{
    internal class BankDeposit : User_Registration
    {
        public decimal Amount { get; set; }

        public void deposit()
        {
            Console.Clear();
            Console.WriteLine("DEPOSIT FUNDS");
            Console.WriteLine();



            // Prompt user to enter the account number
            string accountNumber;
            Customer customer;
            bool isValidAccountNumber = false;



            do
            {
                Console.Write("Enter account number: ");
                accountNumber = (Console.ReadLine());


                // Validate the entered account number
                customer = ValidateAccountNumber(accountNumber);



                if (customer == null)
                {
                    Console.WriteLine("Invalid account number. Please try again.");
                }
                else
                {
                    isValidAccountNumber = true;
                }
            } while (!isValidAccountNumber);



            Console.Write("Enter amount to deposit: ");
            Amount = Convert.ToInt32(Console.ReadLine());



            // Update the balance of the customer
            customer.Balance += Amount;



            Console.WriteLine($"Your new balance is: {customer.Balance}");
            Console.WriteLine();
            Console.WriteLine("SEE YOUR UPDATES BELOW");



            // Display the customer's details
            Console.WriteLine($"FirstName: {customer.FirstName}");
            Console.WriteLine($"LastName: {customer.LastName}");
            Console.WriteLine($"Fullname: {customer.FirstName} {customer.LastName}");
            Console.WriteLine($"Email: {customer.Email}");
            Console.WriteLine($"AccountNumber: {customer.AccountNumber}");
            Console.WriteLine($"AccountType: {customer.AccountType}");
            Console.WriteLine($"Balance: {customer.Balance}");



            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Enter 1 to go back to BankMenu");
            string choice = Console.ReadLine();



            while (choice != "1")
            {
                Console.WriteLine("Invalid input. Please enter 1 to go back to BankMenu");
                choice = Console.ReadLine();
            }



            var menu = new BankDashBoard();
            menu.DashBoard();
        }



        private Customer ValidateAccountNumber(string accountNumber)
        {
            // Check if the account number consists only of digits
            if (!int.TryParse(accountNumber, out _))
            {
                return null; // Return null if the account number contains non-digit characters
            }



            // Search for the customer with the provided account number
            foreach (var item in customers)
            {
                if (item.AccountNumber == accountNumber)
                {
                    return item; // Return the customer if the account number is valid
                }
            }
            return null; // Return null if the account number is not
         }
    }
}
