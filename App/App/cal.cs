using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class cal : Form
    {
        public cal()
        {
            InitializeComponent();
        }

        int sum;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty) MessageBox.Show("กรุณาใส่ตัวเลขให้ครบ", "information");
            else
            {
                txt4.Text = "+";
                sum = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                textBox3.Text = sum.ToString();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty) MessageBox.Show("กรุณาใส่ตัวเลขให้ครบ", "information");
            else
            {
                txt4.Text = "-";
                sum = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                textBox3.Text = sum.ToString();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty) MessageBox.Show("กรุณาใส่ตัวเลขให้ครบ", "information");
            else
            {
                txt4.Text = "*";
                sum = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                textBox3.Text = sum.ToString();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty) MessageBox.Show("กรุณาใส่ตัวเลขให้ครบ", "information");
            else
            {
                txt4.Text = "/";
                sum = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                textBox3.Text = sum.ToString();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            txt4.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
    }
}
