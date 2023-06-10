using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    internal class DetailsTable : User_Registration
    {
        public static void PrintAccountDetails()
        {
            Console.Clear();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine();
            Console.WriteLine("|---------------------------------------------------------------------------------------------|");
            Console.WriteLine("|                                    ACCOUNT DETAILS                                          |");
            Console.WriteLine("|---------------------------------------------------------------------------------------------|");
            Console.WriteLine("|        Full Name     |        Account Number     |    AccountType      |        Balance     |");
            Console.WriteLine("|---------------------------------------------------------------------------------------------|");



            foreach (var customer in User_Registration.customers)
            {
                Console.WriteLine("| {0,-20} | {1,-25} | {2,-19} | {3,-18} |", $"{customer.FirstName} {customer.LastName}", customer.AccountNumber, customer.AccountType, customer.Balance.ToString("C", new CultureInfo("ha-Latn-NG")));
            }



            Console.WriteLine("|---------------------------------------------------------------------------------------------|");
            Console.ResetColor();
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
    }
}

