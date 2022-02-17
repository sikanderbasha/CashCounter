using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Queue queue = new Queue();
            Console.WriteLine("Enter 1 to deposit amount");
            Console.WriteLine("Enter 2 to withdraw amount");
            int check = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 5; i++)
                switch (check)
            {
                case 1:
                    queue.Enqueue(i);
                    counter.DepositMoney();
                    break;

                case 2:
                    queue.Enqueue(i);
                    counter.WithdrawMoney();
                    break;

                default:
                    System.Console.WriteLine("Invalid Selection!");
                    break;

            }
        }
    }
}
