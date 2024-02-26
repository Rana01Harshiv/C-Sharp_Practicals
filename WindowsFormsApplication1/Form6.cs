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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            listBox1.Items.Add(data);
            textBox1.Text = "";
            radioButton1.Checked = false;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) {
                string data = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(data);
                radioButton1.Checked = false;
            }
        }
    }
}
