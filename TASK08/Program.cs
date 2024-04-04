using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount newAccount00 = new SavingAccount("Mohamed",12364);
            newAccount00.Balance = 1000;
            newAccount00.Deposit(9000);
            newAccount00.Withdraw(8100);
            newAccount00.Withdraw(7000);
            newAccount00.ShowAccountData();

            Console.WriteLine("\n\n");
            CheckingAccount newAccount01 = new CheckingAccount("Khaled", 13658);
            newAccount01.Balance = 1000;
            newAccount01.Deposit(9000);
            newAccount01.Withdraw(8100);
            newAccount01.Withdraw(7000);
            newAccount01.ShowAccountData();

        }
    }
}
