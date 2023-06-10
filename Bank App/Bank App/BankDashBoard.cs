using Bank_App.BankTransaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    internal class BankDashBoard
    {
        public string option;

        public void DashBoard()
        {
            Console.WriteLine("Welcome To 'CHIHEART MICROFINANCE BANK'");
            Console.WriteLine("Below is the bank menu");
            Console.WriteLine("Please Make A Choice");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdrawal");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Account Details");
            Console.WriteLine("6. Statement of account");
            Console.WriteLine("7. Logout");

            Console.WriteLine("Enter your choice (1 - 7)");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Console.WriteLine("Create Account");
                    var reg = new User_Registration();
                    reg.Register();
                    break;

                case "2":
                    Console.WriteLine("Deposit");
                    var dep = new BankDeposit();
                    dep.deposit();
                    break;

                    case "3":
                    Console.WriteLine("withdrawal");
                    var with = new BankWithdrawal();
                    with.withdrawal();
                    break;

                    case "4":
                    Console.WriteLine("Transfer");
                    var transfer = new BankTransfer();
                    transfer.Transfer();
                    break;

                    case "5":
                    Console.WriteLine("Account Details");
                    DetailsTable.PrintAccountDetails();
                    break;

                    case "6":
                    Console.WriteLine("Statement of account");
                    break;

                case "7":
                    Console.WriteLine("Logout");
                    break;
            }
        }

    }
}
