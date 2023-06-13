using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Registration
    {
        public static List<UserAccount> userAccounts = new List<UserAccount>();
        private readonly UserAccount _userAccount;
        private readonly Validation _validation;
        private readonly CreateAccount _createAccount;
        
        public Registration()
        {
            _userAccount = new UserAccount();
            _validation = new Validation();
            _createAccount = new CreateAccount();
           // userAccounts = new List<UserAccount>();
        }
        public void signUp()
        {
            var choice = "";

            do
            {
                Console.WriteLine("1. Signup\n2. Login\n3. Exit");
                Console.WriteLine("Enter your choice");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":

                        //Console.WriteLine("Enter your First Name");
                        string firstName = _validation.NameCollector("First Name");
                        //Console.WriteLine("Enter your Last Name");
                        string lastName = _validation.NameCollector("Last Name");
                        //Console.WriteLine("Enter your Email");
                        string email = _validation.EmailCollector();
                        //Console.WriteLine("Enter your password");
                        string password = _validation.PasswordCollector();
                        
                        _userAccount.FirstName = firstName;
                        _userAccount.LastName = lastName;
                        _userAccount.Email = email;
                        _userAccount.Password = password;

                        _createAccount.AccountNumber();

                        userAccounts.Add(_userAccount);
                        
                       
                        break;
                    case "2":
                       var login = new UserLogin();
                       login.AcceptedLogin();
                        break;
                    case "3":
                      //  Console.WriteLine("Exit..");
                      var logout = new UserLogout();
                        logout.Logout();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                //choice = Console.ReadLine();
            } while (choice != "3");


        }
        //public long SavingsNumber()
        //{
        //    Random random = new Random();
        //    var SavingsAccNo = random.Next(100000000, 199999999);
        //    return SavingsAccNo;
        //}

        //public long CurrentNumber()
        //{
        //    Random random = new Random();
        //    var CurrentAccNo = random.Next(100000000, 199999999);
        //    return CurrentAccNo;
        //}
    }
}
