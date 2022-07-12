using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aryan_Patel_Exercise02
{
    public partial class Form1 : Form
    {
        int i = 0;
        int factorial;
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "" && int.TryParse(textBox1.Text, out i))
                factorial = Int32.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = factorialCount(factorial).ToString();
        }

        public BigInteger factorialCount(int n)
        {
            if (n == 0)
                return 1;

            return n * factorialCount(n - 1);
        }
        public double simpleInterest(double principle,
                                       double time,
                                       double rate)
        {
            
            var amount = (principle * time * rate) / 100;
            return amount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = simpleInterest(double.Parse(textBox2.Text), double.Parse(textBox3.Text), double.Parse(textBox4.Text)).ToString();

        }
    }
}
