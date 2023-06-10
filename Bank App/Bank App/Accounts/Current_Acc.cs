using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bank_App.Accounts
{
    internal class Current_Acc
    {
        public long CurrentNumber()
        {
            Random random = new Random();
            var CurrentAccNo = random.Next(1000000000, 1999999999);
            return CurrentAccNo;
        }
    }
}
