using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assinment1Calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sub_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(num1.Text);
                float y = float.Parse(num2.Text);
                MessageBox.Show((x - y).ToString());
            }
            catch
            {
                MessageBox.Show("Please Enter true value.");
            }
        }

        private void sum_Click(object sender, EventArgs e)
        {
            try 
            {
                float x = float.Parse(num1.Text);
                float y = float.Parse(num2.Text);
                MessageBox.Show((x + y).ToString());
            } catch 
            {
                MessageBox.Show("Please Enter true value.");
            }
        }

        private void by_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(num1.Text);
                float y = float.Parse(num2.Text);
                MessageBox.Show((x * y).ToString());
            }
            catch
            {
                MessageBox.Show("Please Enter true value.");
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(num1.Text);
                float y = float.Parse(num2.Text);
                MessageBox.Show((x / y).ToString());
            }
            catch
            {
                MessageBox.Show("Please Enter true value.");
            }
        }
    }
}
