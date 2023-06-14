using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class DashBoard
    {
        private readonly CreateAccount createAccount;
        private readonly Deposit deposits;
        private readonly Account account;
        private readonly Withdrawal withdraw;
        private readonly CheckBalance balance;
        private readonly Transfer transfer;
       // private readonly AccountDetails details;
        public DashBoard()
        {
            createAccount = new CreateAccount();
            deposits = new Deposit();
            account = new Account();
            withdraw = new Withdrawal();
            balance = new CheckBalance();
            transfer = new Transfer();
           // details = new AccountDetails();
        }
        public void dashBoard()
        {
            Console.WriteLine("Welcome To Kpalasa Microfinance Bank");
            Console.WriteLine("Below is the bank menu");
            Console.WriteLine("Please Make A Choice");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdrawal");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Check Balance");
            Console.WriteLine("6. Account Details");
            Console.WriteLine("7. Statement of account");
            Console.WriteLine("8. Logout");

            Console.WriteLine("Enter your choice (1 - 8)");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Create Account");
                    createAccount.AccountNumber();
                    dashBoard();
                    break;
                case "2":
                    Console.WriteLine("Deposit");
                    deposits.deposit();
                    dashBoard();
                    break;
                case "3":
                    Console.WriteLine("withdrawal");
                    withdraw.withdrawal();
                    dashBoard();
                    break;
                case "4":
                    Console.WriteLine("Transfer");
                    transfer.TransferMoney();
                    dashBoard();
                    break;
                case "5":
                    Console.WriteLine("Check Balance");
                    balance.CheckBal();
                    dashBoard();
                    break;
                case "6":
                    Console.WriteLine("Account Details");
                  //  details.DetailsTable();
                    dashBoard();
                   
                    break;
                case "7":
                    Console.WriteLine("Statement of account");
                   // var statement = new StatementOfAccount();
                   // statement.PrintStatement();
                    break;
                case "8":
                    Console.WriteLine("Logout");
                    var logout = new UserLogout();
                    logout.Logout();                   
                    break;
            }
        }
    }
}


