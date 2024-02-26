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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            listBox1.Items.Add(data);
            textBox1.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                string data = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(data);
                listBox1.Items.Remove(data);

            }
            else
            {
                MessageBox.Show("Select the Item First");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string data = listBox2.SelectedItem.ToString();
                listBox1.Items.Add(data);
                listBox2.Items.Remove(data);

            }
            else {
                MessageBox.Show("Select the Item First");
            }
        }

    }
}
