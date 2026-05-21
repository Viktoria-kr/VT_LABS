using System;
using System.Drawing;
using System.Windows.Forms;

namespace LAB05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                label4.Text = (a + b).ToString();
                label4.ForeColor = Color.Black;
            }
            catch
            {
                label4.Text = "Ошибка!";
                label4.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                label4.Text = (a - b).ToString();
                label4.ForeColor = Color.Black;
            }
            catch
            {
                label4.Text = "Ошибка!";
                label4.ForeColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                label4.Text = (a * b).ToString();
                label4.ForeColor = Color.Black;
            }
            catch
            {
                label4.Text = "Ошибка!";
                label4.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                if (b == 0)
                {
                    label4.Text = "На ноль делить нельзя!";
                    label4.ForeColor = Color.Red;
                    return;
                }
                label4.Text = (a / b).ToString();
                label4.ForeColor = Color.Black;
            }
            catch
            {
                label4.Text = "Ошибка!";
                label4.ForeColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
            label4.ForeColor = Color.Black;
        }
    }
}