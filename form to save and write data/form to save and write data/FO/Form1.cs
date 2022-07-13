using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace FO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            Class.filename = FnameValue.Text + ".txt"; // Get the file name from user if I insert file1 in textbox1 ,filename= D:\\file1.txt
            if (!File.Exists(Class.filename)) // if the file does not exists 
            {
                File.Create(Class.filename).Close();// We Should include using System.IO;
                MessageBox.Show("File is created");
            }
            else
                MessageBox.Show("File is already created");
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            Class.filename = FnameValue.Text + ".txt";
            if (File.Exists(Class.filename)) // if the file does not exists 
            {
                File.Delete(Class.filename);
                MessageBox.Show("File is Deleted");
            } else
                MessageBox.Show("File is not found");
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Class.filename = FnameValue.Text + ".txt";
            if (File.Exists(Class.filename)) // if the file does not exists 
            {
                new Form2().Show();// Open Form 2 Insert
                this.Hide();
            }
            else
                MessageBox.Show("Please enter the File Name.\nOr file not found");
        }

        private void btDisplay_Click(object sender, EventArgs e)
        {
            Class.filename = FnameValue.Text + ".txt";
            if (File.Exists(Class.filename)) // if the file does not exists 
            {
                new Form3().Show();// Open Form 3 Display
                this.Hide();
            }
            else
                MessageBox.Show("Please enter the File Name.\nOr file not found");   
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Class.filename = FnameValue.Text + ".txt";
            if (File.Exists(Class.filename)) // if the file does not exists 
            {
                new Form4().Show();// Open Form 3 Search
                this.Hide();
            }
            else
                MessageBox.Show("Please enter the File Name.\nOr file not found");
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
