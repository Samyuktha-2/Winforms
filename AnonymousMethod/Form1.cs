using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnonymousMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Anounmyous Method
            button1.Click += delegate (object sender, EventArgs e)
              {
                  MessageBox.Show("Button1 Clicked thru Anounmyous Method");
              };

            //delegate is method signature
            AnonymousBtn.Click += delegate  
            {
                MessageBox.Show("Hello");
            };

            //Lambda Expression
            button2.Click += (sender, e) => MessageBox.Show("Button2 clicked thru Lambda Expression");

            LambdaBtn.Click += async (s, e) =>
            {
                label3.Text = "Btn Clicked";

                Func<int,int,int> add = (x,y) => { return x + y; };

                await Task.Delay(3000);
                int result = add(3, 4);
                label3.Text = $"Result: {result}";
            };

            listBox1.DataSource = names;

            listBox2.DataSource = peoples;

            button5.Click += (s, e) =>
            {
                var sorted = peoples.OrderBy(p => p.Name).ToList();
                listBox2.DataSource = sorted;
            };
        }


        public class People
        {
            public string Name { get; set; }
            public int Age { get; set;  }

            public override string ToString()
            {
                return $"{Name} - {Age}";
            }

        }

        List<People> peoples = new List<People> {
            new People{Name="Charls",Age=13}, 
            new People{Name="Bob",Age=32},
            new People{Name="Dany",Age=21},
            new People{Name="alice",Age=34}
            
        };

        List<string> names = new List<string>
        {
            "Alice","John","Barb","Charlie"
        };

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Enter value");
                return;
            }

            int num = Int32.Parse(textBox1.Text);

            label1.Text = (num * num).ToString();

            textBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchName = textBox2.Text.ToLower();

            var filtered = names.Where(n => n.ToLower().Contains(searchName)).ToList();

            listBox1.DataSource = filtered;
        }
    }
}
