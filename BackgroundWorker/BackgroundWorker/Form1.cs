using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace BackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(i);  //send progress
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Task cancelled");
                return;
            }
            MessageBox.Show("Task completed");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void StartTask(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();  //start background task
        }

        private void CancelTask(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
