using Bank_App.Accounts;
using Bank_App.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    internal class User_Registration
    {
        public static List<Customer> customers = new List<Customer>();

        public void Register()
        {
            var ValidateFName = new ValidateFirstName();
            var ValidateLastName = new ValidateLastName();
            var ValidateEmail = new ValidateEmail();
            var ValidatePassword = new ValidatePassWord();
            var OpenAccount = new Account_Choice();
            var balance = new Account_Balance();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Enter Your Details To Register: ");

                var FName = ValidateFName.FirstNameCollector();
                var LName = ValidateLastName.LastNameCollector();
                var Email = ValidateEmail.EmailCollector();
                var Password = ValidatePassword.PasswordCollector();
                var AccNum = OpenAccount.AccountNumber();
                var AccType = OpenAccount.AccountType();
                var myBalance = balance.balanceFunction();

                Customer customer = new Customer(FName, LName, Email, Password, AccNum, AccType, myBalance );
                customers.Add(customer);

                Console.WriteLine("Customer added successfully");
                Console.WriteLine("Would you want to add another customer? (Y/N)");
                string choice = Console.ReadLine();

                while(!choice.Equals("Y", StringComparison.OrdinalIgnoreCase) && !choice.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Inalid entry! please enter 'Y' to add another customer or 'N' to implement login");
                    choice = Console.ReadLine();
                }


                if (choice.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    exit = true;
                }
                Console.Clear();


            }
            Console.WriteLine("Your Details");

            foreach (var customer in customers)
            {



                Console.WriteLine($"FirstName: {customer.FirstName}");
                Console.WriteLine($"LastName: {customer.LastName}");
                Console.WriteLine($"Fullname: {customer.FirstName} {customer.LastName}");
                Console.WriteLine($"Email: {customer.Email}");
                Console.WriteLine($"AccountNumber: {customer.AccountNumber}");
                Console.WriteLine($"AccountType: {customer.AccountType}");
                Console.WriteLine($"Balance: {customer.Balance}");
            }



            // Console.Clear();
            Console.WriteLine("Thank your for registering. ");
            PromptForLogin();
        }
        private void PromptForLogin()
        {
            Console.WriteLine("Would you like to log in? (Y/N)");
            string loginChoice = Console.ReadLine();



            if (loginChoice.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thank you for considering us. You can bank with us next time.");
            }
            else if (loginChoice.Equals("Y", StringComparison.OrdinalIgnoreCase))
            {
                string loginInput;
                do
                {
                    Console.WriteLine("Please enter '3' to log in:");
                    loginInput = Console.ReadLine();
                } while (loginInput != "3");

                var login = new Login();
                login.LoginFunc();

                Console.WriteLine("press '0' to logout: ");
                string logoutInput = Console.ReadLine();
                if (logoutInput == "0")
                {
                    var logout = new Login();
                    //logout.LogoutFunction();
                }
            }
            else
            {
                Console.WriteLine("Inalid choice. enter 'Y' to add another customer or 'N' to login: ");
                Console.ReadLine();
                PromptForLogin();
            }
        }
    }
}
