using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App
{
    internal class Login : User_Registration
    {

        string loginEmail;
        string loginPassword;
        public void LoginFunc()
        {
            Console.Write("Enter your email address: ");
            string loginEmail = Console.ReadLine();

            foreach (var item in customers)
            {
                if (loginEmail == item.Email)
                {
                    Console.Write("Enter your password: ");
                    string loginPassWord = Console.ReadLine();
                    if (loginPassWord == item.Password)
                    {
                        Console.Clear();
                        var bankMenu = new BankDashBoard();
                        bankMenu.DashBoard();
                    }
                    else
                    {
                        LoginFunc();
                    }
                }
                else
                {
                    LoginFunc();
                }
            }
        }
    }
}
