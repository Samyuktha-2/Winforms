using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        //Returns "Int", calls Async function and Delay for 2000ms and returns integer value
        private async void StartBtn1_Click(object sender, EventArgs e)
        {
            label1.Text = "Calculating";
            int result = await CalculateAsync(); 
            label1.Text = $"Result: {result}";
        } 
        private async Task<int> CalculateAsync()
        {
            await Task.Delay(2000);
            return 20 + 30;
        }
         

        //No return type, just calls Async function and return nothing
        private async void StartBtn2_Click(object sender, EventArgs e)
        {
            label2.Text = "Working";
            await DoWorkAsync();
            label2.Text = "Done";
        } 
        private async Task DoWorkAsync()
        {
            await Task.Delay(2000);
            //return "Text";
        }


        //If any one Task is completed the result is returned
        private async void StartBtn3_Click(object sender, EventArgs e)
        {
            label6.Text = "Started";
            label7.Text = "Started";
            Task<int> x = Task.Run(() => Add());  //calls add
            Task<int> y = Task.Run(() => Sub());  //calls sub before add function returns value

            Task<int> completedTask = await Task.WhenAny(x, y);

            int result = await completedTask;
            label6.Text = $"First Result: {result}";
            label7.Text = $"First Result: {result}";
        } 
        private async Task<int> Add()
        {
            await Task.Delay(3000);
            return 30 + 30;
        } 
        private async Task<int> Sub()
        {
            await Task.Delay(2000);
            return 30 - 20;
        }

        private void StartBtn4_Click(object sender, EventArgs e)
        {
            label9.Text = "Started";
            Task.Run(() =>
            {
                Thread.Sleep(3000);
            })
            .ContinueWith(t =>
            {
                this.Invoke(new Action(() =>
                {
                    label9.Text = "Completed";
                }));
            });
        }

        private void StartBtn5_Click(object sender, EventArgs e)
        {
            label10.Text = "Started";
            Task<int> task = Task.Run(() =>
            {
                Thread.Sleep(2000);
                return 30;
            });

            task.ContinueWith(t =>
            {
                this.Invoke(new Action(() =>
                {
                    label10.Text = $"{t.Result}";
                }));
            });
        } 

        //Multiple Continue With in same Task
        private void StartBtn6_Click(object sender, EventArgs e)
        {
            label11.Text = "Started";
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                return 5;
            })
            .ContinueWith(t =>
            {
                int value = t.Result + 5;
                return value;
            })
            .ContinueWith(t =>
            {
                int final = t.Result * 2;

                this.Invoke(new Action(() =>
                {
                    label11.Text = $"{final}";
                }));
            });
        }
        
        //Multiple Task Continue With 
        private void StartBtn7_Click(object sender, EventArgs e)
        {
            label12.Text = "Started";
            Task<int> t1 = Task.Run(() =>
            {
                Thread.Sleep(2000);
                return 10;
            });

            Task<int> t2 = Task.Run(() =>
            {
                Thread.Sleep(3000);
                return 20;
            });

            Task.WhenAll(t1, t2).ContinueWith(t =>
            {
                int result = t1.Result + t2.Result;
                this.Invoke(new Action(() =>
                {
                    label12.Text = $"{result}";
                }));
            });

        }
          
    }
}
