using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aryan_Patel_Ex_01
{
    public partial class Form1 : Form
    {
        List<int> primeList = new List<int>();
        int num;
        int i = 0;
        int checkNumber;
        public Form1()
        {
            InitializeComponent();
        }
        // button to check odd or even
        private void button3_Click(object sender, EventArgs e)
        {
            if (IsEven(checkNumber))
            {
                label1.Text = "Even";
            }
            else {
                label1.Text = "Odd";
            }

        }
        // button to het prome numbers
        private async void getPrime_Click(object sender, EventArgs e)
        {
            
            for (int k = num; k > 0; k--)
            {
                Task<bool> primeNumber = Task.Run(() => IsPrime(k));
                if ( await primeNumber)
                {
                    primeList.Add(k);
                    
                }
                
            }
            listBox1.DataSource = primeList;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != null && textBox1.Text != "" && int.TryParse(textBox1.Text, out i))
            num = Int32.Parse( textBox1.Text );
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void oddEven_TextChanged(object sender, EventArgs e)
        {
            if (oddEven.Text != null && oddEven.Text != "" && int.TryParse(oddEven.Text, out i))
                checkNumber = Int32.Parse(oddEven.Text);
        }
        // check prime number 
        private bool IsPrime(int a)
        {
            if (a <= 1) return false;
            if (a == 2) return true;
            if (a % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(a));

            for (int i = 3; i <= boundary; i += 2)
                if (a % i == 0)
                    return false;

            return true;
        }
        // check odd or even
        private bool IsEven(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void oddEven_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
