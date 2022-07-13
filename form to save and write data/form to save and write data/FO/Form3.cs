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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            disFileName.Text = Class.filename;
        }

        private void btDisplay_Click(object sender, EventArgs e)
        {
            displayField.Text = "";
            BinaryReader br = new BinaryReader(File.Open(Class.filename, FileMode.Open, FileAccess.Read));
            int num_of_records = (int)br.BaseStream.Length / Class.rec_size;

            if (num_of_records == 0)
                MessageBox.Show("File is empty");
            else
            {
                while (!((Class.count / Class.rec_size) >= (num_of_records))) // End of File
                {
                    // Move to Specific Position in a File
                    br.BaseStream.Seek(Class.count, SeekOrigin.Begin);
                        
                    string id = br.ReadInt32().ToString(); // Read ID
                    string name = br.ReadString(); // Read Name 
                    string age = br.ReadString(); // Read age
                    string year = br.ReadInt32().ToString(); // Read Year
                    string gender = br.ReadString(); // Read Gender

                        displayField.Text += "----------------\n"
                            + "ID : " + id
                            + "\nName : " + name
                            + "\nYear : " + year
                            + "\nAge : " + age
                            + "\nGender : " + gender + "\n";
                        
                    Class.count += Class.rec_size;
                }
                Class.count = 0;
            }
            br.Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
