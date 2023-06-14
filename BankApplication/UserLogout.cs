using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class UserLogout
    {
        public void Logout()
        {
            Console.WriteLine("Logged out successfully.");
            Environment.Exit(0);        
        }
    }
}
