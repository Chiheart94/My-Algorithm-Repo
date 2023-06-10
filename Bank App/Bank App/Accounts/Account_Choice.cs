using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Accounts
{
    internal class Account_Choice
    {
        public string choice;
        public string Accounttype;
        public string AccountNumber()
        {
            Console.WriteLine("Enter 1 to create a savings account or 2 to create a current account:  ");



            while (true)
            {
                choice = Console.ReadLine();



                if (choice == "1" || choice == "2")
                    break;



                Console.WriteLine("Invalid choice. Please enter either 1 for savings account or 2 for current account: ");
                
            }



            Random random = new Random();
            string accountNumber = random.Next(1000000000, 1999999999).ToString();



            return accountNumber;
        }



        public string AccountType()
        {
            if (choice == "1")
            {
                return "Savings Account";
            }
            else if (choice == "2")
            {
                return "Current Account";
            }
            else
            {
                throw new ArgumentException("Invalid choice. Please enter either 1 for savings account or 2 for current account.");
            }
        }
    }
}
