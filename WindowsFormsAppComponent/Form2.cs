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
    public partial class Form2 : Form
    {
        int i= 1;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0)
            {
                string name;
                double sum = 0, pirce = 0, num = 0;
                name = textBox1.Text;
                pirce = Convert.ToDouble(textBox2.Text);
                num = Convert.ToDouble(textBox3.Text);
                sum = num * pirce;
                dataGridView1.Rows.Add(i, name, pirce, num, sum);
                i++;
            }
            else
            {
                string ch="";
                if (textBox1.Text.Length < 1)
                {
                    ch += " กรุณาใส่ชื่อสินค้า";
                }
                if(textBox2.Text.Length < 1)
                {
                    ch += " กรุณาใส่ราคาสินค้า";
                }
                if(textBox3.Text.Length < 1)
                {
                    ch += " กรุณาใส่จำนวนสินค้า";
                }
                MessageBox.Show(ch);
            }
        }
    }
}
