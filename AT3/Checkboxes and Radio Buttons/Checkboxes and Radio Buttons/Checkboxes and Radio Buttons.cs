// Datoon, Philip Bryan B.
// 131311399
// 21 August 2013
// Using checkboxes and radio button in Windows form (pp 179-185)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkboxes_and_Radio_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String movies = "";

            // gets the texts of checkbox ticked
            if (checkBox1.Checked)
            {   // Environment.NewLine - syntax for Newline character (same as "\r\n")
                movies = movies + checkBox1.Text + Environment.NewLine;
            }

            if (checkBox2.Checked)
            {
                movies = movies + checkBox2.Text + Environment.NewLine;
            }

            if (checkBox3.Checked)
            {
                movies = movies + checkBox3.Text + Environment.NewLine;
            }

            if (checkBox4.Checked)
            {
                movies = movies + checkBox4.Text + Environment.NewLine;
            }

            if (checkBox5.Checked)
            {
                movies = movies + checkBox5.Text + Environment.NewLine;
            }
            // displays the texts of checkbox ticked
            MessageBox.Show(movies);
        }

        private void button2_Click(object sender, EventArgs e)
        {   // gets the texts of radio button selected
            string ChosenMovie = "";

            if (radioButton1.Checked)
            {
                ChosenMovie = radioButton1.Text;
            }

            else if (radioButton2.Checked)
            {
                ChosenMovie = radioButton2.Text;
            }

            else if (radioButton3.Checked)
            {
                ChosenMovie = radioButton3.Text;
            }

            else if (radioButton4.Checked)
            {
                ChosenMovie = radioButton4.Text;
            }

            else if (radioButton5.Checked)
            {
                ChosenMovie = radioButton5.Text;
            }
            // displays text of radio button selected
            MessageBox.Show(ChosenMovie);
        }

    }
}
