using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09
{
    internal interface IBankAccount
    {
        string ClientName { get; }
        int AccountId { get; }
        double Balance { get; set; }
        List<string> LogData { get; set; }
        void ShowAccountData();
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}
