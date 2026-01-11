using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//FOr binary serialization
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//For XML 
using System.Xml.Serialization;

//For SOAP Serialization
using System.Runtime.Serialization.Formatters.Soap;

namespace WinSerializeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ClearAllTextBoxes()
        {
            foreach (Control item in this.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Clear();
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBinSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //Binary Serialization

            FileStream fs = new FileStream(@"D:\.net\BinSearialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            //serialize in fs file from emp1 object
            bf.Serialize(fs, emp1);

            //clear all the text box values
            ClearAllTextBoxes();
            fs.Close();

            MessageBox.Show("Record Added Successfully");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinDeSeriallize_Click(object sender, EventArgs e)
        {
            //Binary DeSerialization

            FileStream fs = new FileStream(@"D:\.net\BinSearialize.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            //Deserialize from fs file to emp1 object
            Employee emp1 = (Employee)bf.Deserialize(fs);
            
            txtEmployeeID.Text = emp1.ID.ToString();
            txtName.Text = emp1.name;
            txtSalary.Text = emp1.Salary.ToString();
        }

        private void btnXMLSerialize_Click(object sender, EventArgs e)
        {

            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //XML Serialization

            FileStream fs = new FileStream(@"D:\.net\XMLSearialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(Employee)); // xml is type based so we have to mention.

            //serialize in fs file from emp1 object
            xm.Serialize(fs, emp1);

            //clear all the text box values
            ClearAllTextBoxes();
            fs.Close();
            MessageBox.Show("Record Added Successfully");
        }

        private void btnXMLDeSerialize_Click(object sender, EventArgs e)
        {
            //xml DeSerialization

            FileStream fs = new FileStream(@"D:\.net\XMLSearialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(Employee)); // xml is type based so we have to mention.

            //Deserialize from fs file to emp1 object
            Employee emp1 = (Employee)xm.Deserialize(fs);

            txtEmployeeID.Text = emp1.ID.ToString();
            txtName.Text = emp1.name;
            txtSalary.Text = emp1.Salary.ToString();
        }

        private void btnSOAPSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.ID = Convert.ToInt32(txtEmployeeID.Text);
            emp1.name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //SOAP Serialization

            FileStream fs = new FileStream(@"D:\.net\SOAPSearialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();

            //serialize in fs file from emp1 object
            bf.Serialize(fs, emp1);

            //clear all the text box values
            ClearAllTextBoxes();
            fs.Close();

            MessageBox.Show("Record Added Successfully");
        }

        private void btnSOAPDeSeriallize_Click(object sender, EventArgs e)
        {
            //SOAP DeSerialization

            FileStream fs = new FileStream(@"D:\.net\SOAPSearialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();

            //Deserialize from fs file to emp1 object
            Employee emp1 = (Employee)bf.Deserialize(fs);

            txtEmployeeID.Text = emp1.ID.ToString();
            txtName.Text = emp1.name;
            txtSalary.Text = emp1.Salary.ToString();
        }
    }
}
