using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankClass bank = new BankClass();
            //bank.WithDraw(200);

            //This is called Race Condition and this is wrong
            Thread t1 = new Thread(() => bank.WithDraw(800));
            Thread t2 = new Thread(() => bank.WithDraw(800));

            t1.Start();
            t2.Start(); 

            Thread t3 = new Thread(() => bank.WithDraw1(800));
            Thread t4 = new Thread(() => bank.WithDraw1(800));

            t3.Start();
            t4.Start(); 

            Thread t5 = new Thread(() => bank.WithDraw2(800));
            Thread t6 = new Thread(() => bank.WithDraw2(800));

            t5.Start();
            t6.Start(); 

            Console.ReadLine();
        }
    }
}
