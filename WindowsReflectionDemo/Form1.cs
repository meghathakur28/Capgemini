using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsReflectionDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string Filename = openFileDialog1 .FileName;

            //logical unit of deployment 
            Assembly assemblyObj = Assembly.LoadFrom(Filename); // object of assembly class

            Type[] myType = assemblyObj.GetTypes();  // get  all the types of the assembly
            this.ReflectAll(typeof(Employee));
            

        }

        public  void ReflectAll(Type typeObj)
        {
            MethodInfo[] methods = typeObj.GetMethods();

            PropertyInfo[] propList = typeObj.GetProperties();

            //Load All Properties
            foreach(var item in propList)
            {
                listBox1.Items.Add(item);

            }

            //Load All Methods
            foreach (var item in methods)
            {
                listBox2.Items.Add(item);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
