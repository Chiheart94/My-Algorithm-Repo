using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class UserLogin
    {
        //string LoginEmail;
        //string Password;

        public void AcceptedLogin()
        {
            Console.Write("Enter your email address: ");
            string loginEmail = Console.ReadLine();

            Console.Write("Enter your password: ");
            string loginPassWord = Console.ReadLine();

            var loggedInUser = Registration.userAccounts.FirstOrDefault(user => user.Email == loginEmail && user.Password == loginPassWord);
            if (loggedInUser != null)
            {
                Console.Clear();
                Console.WriteLine("You are successfully loggedin !");
                var bankMenu = new DashBoard();
                bankMenu.dashBoard();
            }
            else
            {
                Console.WriteLine("Invalid Login details");
                AcceptedLogin();
            }
             
        }
    }
}
