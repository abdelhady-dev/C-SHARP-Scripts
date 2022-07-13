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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fnameInsertValue.Text = Class.filename;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            // open file to write on it
            BinaryWriter bw = new BinaryWriter(File.Open(Class.filename, FileMode.Open, FileAccess.Write)); // We Should include using System.IO
            int length = (int)bw.BaseStream.Length;


            if (length == 0) // empty file
            {
                bw.Write(int.Parse(idVal.Text)); // ID 
                nameVal.Text = nameVal.Text.PadRight(9); // Name 
                bw.Write(nameVal.Text.Substring(0, 9));

                ageVal.Text = ageVal.Text.PadRight(11);// AGE 
                bw.Write(ageVal.Text.Substring(0, 11));


                bw.Write(int.Parse(yearVal.Text));// Year 

                bw.Write(genderVal.Text.Substring(0, 5)); // Gender 
                
                length += Class.rec_size;
               
            }
            else
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);// after 32 byte  
                bw.Write(int.Parse(idVal.Text));
                nameVal.Text = nameVal.Text.PadRight(9);
                bw.Write(nameVal.Text.Substring(0, 9));

                ageVal.Text = ageVal.Text.PadRight(11);
                bw.Write(ageVal.Text.Substring(0, 11));


                bw.Write(int.Parse(yearVal.Text));

                bw.Write(genderVal.Text.Substring(0, 1));
                length += Class.rec_size;

            }

            idVal.Text = nameVal.Text = ageVal.Text = yearVal.Text = genderVal.Text = "";
            noRec.Text = (length / Class.rec_size).ToString();// number of records
            fSize.Text = length.ToString();// file size 
            MessageBox.Show("Data is saved successfully");
            bw.Close();

        }

        private void btBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            Close();
        }

    }
}
