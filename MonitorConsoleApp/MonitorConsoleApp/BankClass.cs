using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorConsoleApp
{
    public class BankClass
    {
        public int Balance = 1000;
        

        public void WithDraw(int amount)
        {
            if(Balance >= amount)
            {
                Thread.Sleep(1000);
                Balance -= amount;
            }
            Console.WriteLine($"Available Balance: {Balance}");
        }

        public int Balance1 = 1000;
        private object lockObj = new object();
        public void WithDraw1(int amount)
        {
            Monitor.Enter(lockObj);
            try
            {
                if(Balance1 >= amount)
                {
                    Thread.Sleep(1000);
                    Balance1 -= amount;
                    Console.WriteLine($"Available Balance1: {Balance1}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance1");
                }
            }
            finally
            {
                Monitor.Exit(lockObj);
            }
        }

        public int Balance2 = 1000;
        public void WithDraw2(int amount)
        {
            lock (lockObj)
            {
                if (Balance2 >= amount)
                {
                    Balance2 -= amount;
                    Console.WriteLine($"Available Balance2: {Balance2}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance2");
                }
            }
        }

    }
}
