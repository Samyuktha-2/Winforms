using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Start";

            ////instead of this async await can be used
            //Thread.Sleep(1000);
            //label1.Text = "Done";

            Thread workingThread = new Thread(DoWork);  //thread created
            workingThread.IsBackground = true;
            workingThread.Start();  //start thread

        }

        private void DoWork()
        {
            Thread.Sleep(3000);  //background work

            UpdateLabel("Done");
        }

        private void UpdateLabel(string text)
        {
            if (label1.InvokeRequired)  //safe UI update
            {
                label1.Invoke(new Action(() =>
                {
                    label1.Text = text;
                }));
            }
            else
            {
                label1.Text = "Start";
            }
        }


        //here the method is working asynchronous and after UI update only thread is running
        int counter = 0;
        private void CounterBtn_Click(object sender, EventArgs e)
        {
            //multiple thread access shared data, so we get unexpected result, these are called race condition
            Thread t1 = new Thread(Increment);
            Thread t2 = new Thread(Increment);

            t1.Start();
            t2.Start();

            label2.Text = $"Counter: {counter}";
        }
        private void Increment()
        {
            for (int i = 0; i < 1000; i++)
            {
                counter++;
            }
        }

        int counter1 = 0;
        private void CounterBtn2_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(Increment1);

            t1.Start();

            label3.Text = $"Counter: {counter1}";
        }
        private void Increment1()
        {
            for (int i = 0; i < 1000; i++)
            {
                counter1++;
            }
        }


        //Updates UI after execution of thread
        int counter3 = 0;
        private void CounterBtn3_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() =>
            {
                Increment2();

                this.Invoke(new Action(() =>
                {
                    label4.Text = $"Counter: {counter3}";
                }));
            });

            t1.Start();
        }
        private void Increment2()
        {
            for (int i = 0; i < 1000; i++)
            {
                counter3++;
            }
        }

        //Thread safe using Lock
        int safeCounter = 0;
        int atomicCounter = 0;
        object lockObj = new object();

        private void CounterBtn4_Click(object sender, EventArgs e)
        {
            //Lock is thread safe but performance is slow
            Parallel.For(0, 100, i =>
            {
                lock (lockObj)
                {
                    safeCounter++;
                }
            });

            //Interlocked is thread safe and best for ccounter, it's also fast
            Parallel.For(0, 100, i =>
            {
                Interlocked.Increment(ref atomicCounter);
            });

            label5.Text = $"Safe Counter: {safeCounter}";
            label6.Text = $"Atomic Counter: {atomicCounter}";
        }
    }
}
