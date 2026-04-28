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

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowBtn(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void HideBtn(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private async void StartBtn(object sender, EventArgs e)
        {
            var progress = new Progress<int>(value =>
            {
                progressBar1.Value = value;
            });
            await Task.Run(() => DoWork(progress));
            

            MessageBox.Show("Task over!");
        }

        private void DoWork(IProgress<int> prog)
        {
            for(int i = 0; i <= 100; i++)
            {
                Thread.Sleep(50);
                prog.Report(i);
            }
        }

        private CancellationTokenSource cts;

        private async void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            CancelButton.Enabled = true;
            progressBar2.Value = 0;

            cts = new CancellationTokenSource();

            var progress = new Progress<int>(value =>
            {
                progressBar2.Value = value;
            });

            try
            {
                // Run multiple tasks in parallel
                Task<int> task1 = Task.Run(() => DoWork("Task 1", progress, cts.Token));
                Task<int> task2 = Task.Run(() => DoWork("Task 2", progress, cts.Token));

                // Wait for first task
                Task first = await Task.WhenAny(task1, task2);
                MessageBox.Show("First task finished!");

                // Wait for all tasks
                int[] results = await Task.WhenAll(task1, task2);

                MessageBox.Show($"All tasks done! Results: {results[0]}, {results[1]}");
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Operation cancelled!");
            }
            finally
            {
                StartButton.Enabled = true;
                CancelButton.Enabled = false;
            }
        }

        private int DoWork(string taskName, IProgress<int> progress, CancellationToken token)
        {
            int total = 0;

            for (int i = 1; i <= 50; i++)
            {
                token.ThrowIfCancellationRequested(); 

                Thread.Sleep(50); // simulate work
                total += i;

                progress.Report(i * 2); // progress (0–100)
            }

            return total; // return value
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (cts != null && !cts.IsCancellationRequested)
            {
                cts.Cancel();
            }
        }

        private async void BtnStart_Click(object sender, EventArgs e)
        {
            label4.Text = "started";

            await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Task Finished";
            })
            .ContinueWith(t =>
            {
                this.Invoke(new Action(() =>
                {
                    label4.Text = t.Result;
                }));
            });

            
        }
    }
}
