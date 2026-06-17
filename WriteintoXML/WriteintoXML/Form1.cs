using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WriteintoXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("Employee.xml"))
            {
                doc.Load("Employee.xml");
            }
            else
            {
                XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(declaration);

                XmlElement root = doc.CreateElement("Employees");
                doc.AppendChild(root);
            }
            XmlElement employee = doc.CreateElement("Employee");
            XmlElement id = doc.CreateElement("Id");
            id.InnerText = IdTxtBox.Text;
            XmlElement name = doc.CreateElement("Name");
            name.InnerText = NameTxtbox.Text;

            employee.AppendChild(id);
            employee.AppendChild(name);

            doc.DocumentElement.AppendChild(employee);

            doc.Save("Employee.xml");

            IdTxtBox.Text = "";
            NameTxtbox.Text = "";
        }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            ds.ReadXml("Employee.xml");

            dataGridView1.DataSource = ds.Tables[0];
            //if(dataGridView1.Rows.Count > 0)
            //{
            //    dataGridView1.Rows.Clear();
            //}

            //XmlDocument doc = new XmlDocument();
            //doc.Load("Employee.xml");

            //XmlNodeList nodes = doc.SelectNodes("/Employees/Employee");

            //foreach(XmlNode employee in nodes)
            //{
            //    string id = employee["Id"].InnerText;
            //    string name = employee["Name"].InnerText;

            //    dataGridView1.Rows.Add(id, name); 
            //}
        }

        private void FindLbl_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("Employee.xml"))
            {
                doc.Load("Employee.xml");
            }
            var searchId = IdSearchbox.Text;
            XmlNode employee = doc.SelectSingleNode($"/Employees/Employee[Id='{searchId}']");

            NameSearchBox.Text = employee["Name"].InnerText;
            IdSearchbox.Text = "";
        }
         

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("Employee.xml"))
            {
                doc.Load("Employee.xml");
            }
            var UpdateId = IdUpdateBox.Text;
            XmlNode updateEmployee = doc.SelectSingleNode($"/Employees/Employee[Id='{UpdateId}']");
            updateEmployee["Name"].InnerText = NameUpdateBox.Text;
            doc.Save("Employee.xml");

            UpdateStatusLbl.Visible = true;
            UpdateStatusLbl.Text = $"Updated Id - {UpdateId} sucessfully!";

            DataSet ds = new DataSet();
            ds.ReadXml("Employee.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            if (File.Exists("Employee.xml"))
            {
                doc.Load("Employee.xml");
            }

            var DeletedId = IdDeleteBox.Text;
            XmlNode deleteEmployee = doc.SelectSingleNode($"/Employees/Employee[Id='{DeletedId}']");
            deleteEmployee.ParentNode.RemoveChild(deleteEmployee);
            doc.Save("Employee.xml");

            DeleteStatusLbl.Visible = true;
            DeleteStatusLbl.Text = $"Deleted Id - {DeletedId} sucessfully!";

            DataSet ds = new DataSet();
            ds.ReadXml("Employee.xml");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
