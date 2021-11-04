using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMP_to_EAC_Improved
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                if(radioButton3.Checked == true)
                {
                    Process.Start(Application.StartupPath + "\\24.ahk");
                }
                else if(radioButton4.Checked == true)
                {
                    Process.Start(Application.StartupPath + "\\23.ahk");
                }
                else if(radioButton5.Checked == true)
                {
                    Process.Start(Application.StartupPath + "\\22.ahk");
                }
                else if(radioButton6.Checked == true)
                {
                    Process.Start(Application.StartupPath + "\\21.ahk");
                }
                else
                {
                    MessageBox.Show("Please pick an item from the right! :)");
                }
            }
            else if(radioButton2.Checked == true)
            {
                if(radioButton3.Checked == true)
                {
                    Process.Start(Application.StartupPath + "\\14.ahk");
                }
                else if(radioButton4.Checked == true)
                {
                    Process.Start(Application.StartupPath + "\\13.ahk");
                }
                else if(radioButton5.Checked == true)
                {
                    Process.Start(Application.StartupPath + "\\12.ahk");
                }
                else if(radioButton6.Checked == true)
                {
                    Process.Start(Application.StartupPath + "\\11.ahk");
                }
                else
                {
                    MessageBox.Show("Please pick an item from the right! :)");
                }
            }
            else
            {
                MessageBox.Show("Please pick an item from the left! :)");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "\\11.ahk";
            if (!File.Exists(file))
            {
                MessageBox.Show("Please make sure the scripts are in this folder.");
                this.Close();
            }
        }
    }
}
