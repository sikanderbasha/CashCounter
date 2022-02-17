using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    internal class Counter
    {
        double balance = 10000;
        int deposit = 0;
        int withdraw = 0;
       

        Queue queue = new Queue();
        public void DepositMoney()
        {
            Console.WriteLine("Amount :" + balance);
            Console.WriteLine("Enter Deposit Amount: ");
            deposit = Convert.ToInt32(Console.ReadLine());
            balance = balance + deposit;
            Console.WriteLine("Deposited amount "+ deposit);
            Console.WriteLine("Avaialble Balance is :" + balance);

            queue.Dequeue();
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Amount:" + balance);
            Console.WriteLine("Enter Withdraw Amount: ");
            withdraw = Convert.ToInt32(Console.ReadLine());
            if (withdraw > balance)
            {
                Console.WriteLine("Invalid Amount\n");
            }
            else
            {
                balance = balance - withdraw;
                Console.WriteLine("Amount withdrawn " +withdraw );
                Console.WriteLine("Avaialble Balance is :" + balance);
            }
            queue.Dequeue();
        }

    }
}
