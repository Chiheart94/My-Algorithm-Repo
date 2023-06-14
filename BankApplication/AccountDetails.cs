//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BankApplication
//{
//    internal class AccountDetails
//    { 

//        public void DetailsTable()
//        {
//            Console.WriteLine("Please Enter Account Number: ");
//            var account = Console.ReadLine();

//            var account = CreateAccount.accounts.FirstOrDefault();

//            Console.OutputEncoding = Encoding.UTF8;
//            Console.WriteLine($"ACCOUNT DETAILS\n");
//            Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|");
//            Console.WriteLine("| FULL NAME         | ACCOUNT NUMBER                | ACCOUNT TYPE             | AMOUNT BAL          |");
//            Console.WriteLine("|-------------------|-------------------------------|--------------------------|---------------------|");
//            Console.WriteLine($"| {account.FullName,-17} | {account.AccountNumber,-29} | {account.accountType,-24} | {account.Balance.ToString("C", new CultureInfo("ha-Latn-NG")),-19} |");
//            Console.WriteLine("|----------------------------------------------------------------------------------------------------|");


//        }
//        public void PrintStatement(Account account)
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Console.WriteLine($"ACCOUNT STATEMENT ON ACCOUNT NO {account.AccountNumber}\n");
//            Console.WriteLine("|---------------------|-----------------------------------------------|--------------------------|---------------------|");
//            Console.WriteLine("| DATE                | DESCRIPTION                                   | AMOUNT                   | BALANCE             |");
//            Console.WriteLine("|---------------------|-----------------------------------------------|--------------------------|---------------------|");

//            foreach (Transaction transaction in account.AllTransactions)
//            {
//                Console.WriteLine($"| {transaction.Date,-10} | {transaction.Description,-45} | {transaction.Amount,-24} | {transaction.Balance.ToString("C", new CultureInfo("ha-Latn-NG")),-19} |");
//            }

//            Console.WriteLine("|----------------------------------------------------------------------------------------------------------------------|");
//        }
//    }
//}

