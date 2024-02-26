using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCombobox();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeCombobox()
        {
            comboBox1.Items.Add("Prime");
            comboBox1.Items.Add("Armstrong");
            comboBox1.Items.Add("Palindrome");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                string selection = comboBox1.SelectedItem.ToString();
                string result = "";
                switch (selection)
                {
                    case "Prime":
                        result = IsPrime(number) ? "Prime" : "Not Prime";
                        break;
                    case "Armstrong":
                        result = isArmstrong(number) ? "Armstrong" : "Not Armstrong";
                        break;
                    case "Palindrome":
                        result = isPalindrome(number) ? "Palindrome" : "Not Palindrome";
                        break;


                }
                label1.Text = result;
            }
            else
            {
                MessageBox.Show("Please enter a valid number ");
            }

        }

        private bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }

                }
                return true;
            }
        }

        private bool isArmstrong(int num)
        {
            int temp = num;
            int digit;
            int sum = 0;
            while (temp != 0)
            {
                digit = temp % 10;
                sum += digit * digit * digit;
                temp /= 10;
            }
            return sum == num;
        }
        private bool isPalindrome(int num)
        {
            int reversenum = 0;
            int originalnum = num;
            int rem;

            while (originalnum > 0)
            {
                rem = originalnum % 10;
                reversenum = reversenum * 10 + rem;
                originalnum /= 10;
            }
            return reversenum == num;
        }

    }
}
