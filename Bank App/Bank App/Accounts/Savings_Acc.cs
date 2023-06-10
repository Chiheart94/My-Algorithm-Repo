using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Accounts
{
    internal class Savings_Acc
    {
        public long SavingsNumber()
        {
            Random random = new Random();
            var SavingsAccNo = random.Next(100000000, 199999999);
            return SavingsAccNo;
        }
    }
}
