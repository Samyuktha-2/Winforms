using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mutex
{
    public class BankAccount
    {
        public int Balance = 1000;

        static Mutex mutex = new Mutex(false,"BankAccountMutex");

        public void Withdraw(int amount)
        {
            mutex.WaitOne();

            try
            {
                if (Balance >= amount)
                {
                    Thread.Sleep(100); // simulate delay
                    Balance -= amount;
                    Console.WriteLine($"Withdrawn {amount}, Balance: {Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
            finally
            {
                mutex.ReleaseMutex();
            }
            
        }

    }
}
