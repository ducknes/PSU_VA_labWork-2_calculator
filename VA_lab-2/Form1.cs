using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VA_lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            double x = (double)numericUpDown1.Value;
            textBox1.Text = Calculator.Exp(x).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            double z = (double)numericUpDown2.Value;
            if (z <= 0)
            {
                MessageBox.Show("Не определён. Введите число > 0", "Ошибка!");
                return;
            }
            textBox2.Text = Calculator.Ln(z).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            double x = (double)numericUpDown3.Value;
            textBox3.Text = Calculator.Sin(x).ToString();  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            double x = (double)numericUpDown4.Value;
            textBox4.Text = Calculator.Cos(x).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            double x = (double)numericUpDown5.Value;
            textBox5.Text = (Calculator.Sin(x) / Calculator.Cos(x)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            double x = (double)numericUpDown6.Value;
            textBox6.Text = (Calculator.Cos(x) / Calculator.Sin(x)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            double x = (double)numericUpDown7.Value;
            if (x < 0)
            {
                MessageBox.Show("Введите число > 0. Невозможно извлечь корень из отрицательного числа", "Ошибка!");
                return;
            }
            textBox7.Text = Calculator.Sqrt(x).ToString();  
        }
    }
}
