using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _11_20
{
    public partial class Form1 : Form
    {
        string file = "";
        string line = "";
        string writeTo = "";
        string location = "";
        string tempLine = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            location = @"C:\Users\xdark\Desktop\";
            writeTo = location + textBox1.Text + ".cs";
            file = comboBox1.Text + ".cs";
            StreamReader reader = new StreamReader(file);
            StreamWriter writer = new StreamWriter(writeTo);
            while ((line = reader.ReadLine()) != null)
            {
                if (radioButton1.Checked)
                {
                    string[] list = line.Split(new char[] { ';', '{', '}' });
                    for (int i = 0; i < list.Length - 1; i++)
                    {
                        listBox1.Items.Add(list[i]);
                    }
                }
                else if (radioButton2.Checked)
                {
                    writer.WriteLine(line); 
                }
            }
            reader.Close();
            writer.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("3_13");
            comboBox1.Items.Add("8_16");
        }
    }
}
