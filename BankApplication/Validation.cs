using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Validation
    {
        public string NameCollector(string prompt)
        {
            while (true)
            {

                Console.Write($"Enter your {prompt} name begining with uppercase: \n");
                string Name = Console.ReadLine();

                if (string.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("Invalid input. enter a valid name");
                    continue;
                }
                if (!char.IsUpper(Name[0]))
                {
                    Console.Write("Invalid entry! Name must begin with uppercase\n");
                    //firstName = Console.ReadLine();
                    continue;
                }
                if (char.IsDigit(Name[0]))
                {
                    Console.Write("Invalid entry! Name must not begin with a digit\n");
                    //firstName = Console.ReadLine();
                    continue;
                }
                return Name;
            }
                
        }

        public string EmailCollector()
        {
            while (true)
            {
                Console.Write("Enter Email Address: \n");
                string email = Console.ReadLine();

                if (!IsValidEmail(email))
                {
                    Console.WriteLine("Invalid Email, please enter  a valid email address");
                    continue;
                }
                return email;
            }
        }
        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com|outlook\.com)$");
        }
        public string PasswordCollector()
        {
            while (true)
            {
                Console.Write("Enter a Password " +
                "\n (Password requirements: " +
                "\n 1. Minimum 6 characters, " +
                "\n 2. alphanumeric, " +
                "\n 3. and at least one special character (@, #, $, %, ^, &, !).)): ");
                string password = Console.ReadLine();

                if (!IsValidPassword(password))
                {
                    Console.WriteLine("Invalid password: ");
                    continue;
                }
                return password;
            }
        }

        public bool IsValidPassword(string password)
        {
            string passwordPattern = @"^(?=.*[@#$%^&!])(?=.*[a-zA-Z0-9]).{6,}$";
            return Regex.IsMatch(password, passwordPattern);
        }
    }
}

