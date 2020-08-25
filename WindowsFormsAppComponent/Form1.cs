using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppComponent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("...");
            
            Form2 f2 =new Form2();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ch="";
            if (checkBox1.Checked)
            {
                ch = "1";
            }
            if (checkBox2.Checked)
            {
                ch += "2";
            }
            if(checkBox3.Checked)
            {
                ch += "3";
            }
            textBox1.Text = ch;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ch = "";
           
            if (radioButton1.Checked)
            {
                ch = "1";
            }
            else if (radioButton2.Checked)
            {
                ch = "2";
            }
            else
            {
                ch = "3";
            }
            textBox2.Text = ch;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0)
            {
                listBox1.Items.Add(textBox3.Text);
            }
            textBox3.Text = "";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string cs="", set="";
            dataGridView1.Rows.Add("...", "..", ".");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}