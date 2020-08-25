using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppComponent
{
    public partial class Form1 : Form
    {
        int i = 1;
        double SUM = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";
            double num = 0, pirce = 0,sum=0;
            if (comboBox1.Text.Length > 0 && textBox1.Text.Length > 0 && numericUpDown1.Value != 0)
            {
                name = comboBox1.Text;
                num = Convert.ToDouble(numericUpDown1.Value);
                pirce = Convert.ToDouble(textBox1.Text);
                sum = pirce * num;
                SUM += sum;
                dataGridView1.Rows.Add(i, name, num, pirce,sum);
                numericUpDown1.Value = 0;
                textBox1.Text = "";
                i++;
            }
            else
            {
                string ch="กรุณา";
                if(comboBox1.Text.Length < 1)
                {
                    ch += "เลือกรายการ";
                }
                if(numericUpDown1.Value == 0)
                {
                    ch += " ใส่จำนวนสินค่า";
                }
                if(textBox1.Text.Length < 1)
                {
                    ch += " ใส่ราคาสินค้า";
                }
                MessageBox.Show(ch);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            double vat = 0,vatmoney=0, sumvat = 0;
            double discout = 0, sumfor = 0;
            for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
            {
                sumfor += Convert.ToDouble(dataGridView1.Rows[j].Cells[4].Value.ToString());
            }

            if (radioButton1.Checked || radioButton2.Checked)
            {
                if (radioButton2.Checked)
                {
                    vat = 0.10;
                }
                if (radioButton1.Checked)
                {
                    vat = 0.05;
                }
                if (checkBox1.Checked)
                {
                    vat += 0.05;
                }
                vatmoney = sumfor * vat;
                
                
                sumvat = sumfor - vatmoney;
                textBox3.Text = vatmoney.ToString();
                textBox4.Text = sumvat.ToString();
            }
            else
            {
                vat = 0;
                if (checkBox1.Checked)
                {
                    vat += 0.05;
                }
               
                vatmoney = sumfor * vat;
                sumvat = sumfor - vatmoney;
                if(sumfor!=0)
                {
                    textBox3.Text = vatmoney.ToString();
                    textBox4.Text = sumvat.ToString();
                }

               
            }
            if(SUM != 0 && sumfor != 0)
            {
                textBox2.Text = sumfor.ToString();
            }
            

        }
    }
}