using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09
{
    internal class CheckingAccount : IBankAccount
    {
        public string ClientName {get;}

        public int AccountId { get; }

        public double Balance { get; set; }
        public List<string> LogData { get; set; }

        public CheckingAccount(string name, int id)
        {
            ClientName = name;
            AccountId = id;
            Balance = 0;
            LogData = new List<string>();
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            LogData.Add($"{DateTime.Now} - Deposited {amount} - New Balance is {Balance}");
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                
                LogData.Add($"{DateTime.Now} - Withdraw {amount} - Process failed due to Insufficient funds");
            }
           
            else { Balance -= amount; LogData.Add($"{DateTime.Now} - Withdraw {amount} - New Balance is {Balance}"); }
        }
       
        public void ShowAccountData()
        {
            Console.WriteLine($"This account is for {ClientName}" +
                $" - Id:{AccountId}-Current Balance: {Balance}\n\n" +
                $"LogHistory:\n\n{string.Join("\n", LogData)}");
        }
    }
}
