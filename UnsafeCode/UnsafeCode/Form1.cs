using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoLibrary;

using System.Windows.Forms;

namespace UnsafeCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void UnsafeBtn_Click(object sender, EventArgs e)
        {
            int value = 10;
            label1.Text = value.ToString();

            await Task.Delay(2000);

            unsafe
            { 
                //int* p  -> pointer to integer
                //&value -> memory addres of variable value
                int* p = &value;

                //*p -> value at that memory location
                *p = 20;
                label1.Text = value.ToString();
            }


        }

        private async void UnsafeBtn2_Click(object sender, EventArgs e)
        {
            int[] arr = { 1, 2, 3 };
            label2.Text = "0";
            unsafe
            {
                int x = 315;
                int y = 178;
                fixed (int* p = arr)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int res = *(p + i);
                        Label l1 = new Label
                        {
                            Text = $"{res}",
                            Location= new Point(x,y),
                            Size = new Size(10,20)
                        };
                        this.Controls.Add(l1);
                        y += 20;
                        
                    }
                }
            }
        }

        private void UnsafeBtn3_Click(object sender, EventArgs e)
        {
            unsafe
            {
                int[] arr = { 1, 2, 3 };

                fixed(int* p = arr)
                {
                    *(p + 1) = 1000;
                }

                label3.Text = string.Join(", ", arr);
            }
        }

        //stackalloc must not be used in winforms ui logic or for button click just for code understanding, i've coded here
        private void UnsafeBtn4_Click(object sender, EventArgs e)
        {
            unsafe
            {
                //doesn't support large dataset
                //in .NET 6/8 we can use "Span<int> temp = stackalloc int[3]" instead of unsafe
                int* nums = stackalloc int[3];

                nums[0] = 10;
                nums[1] = 10;
                nums[2] = nums[0] + nums[1];

                label4.Text = $"{nums[0]}, {nums[1]}, {nums[2]}";
            } 
        }
         
    }
}
