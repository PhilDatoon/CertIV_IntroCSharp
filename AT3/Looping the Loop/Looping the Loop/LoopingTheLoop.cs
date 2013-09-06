// Datoon, Philip Bryan B.
// 131311399
// 14 August 2013
// Using loops and TryParse in Windows form (pp 124-142)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping_the_Loop
{
    public partial class LoopingTheLoop : Form
    {
        public LoopingTheLoop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int loopStart;
            int loopEnd;
            int answer = 0;
            int outputValue = 0;
            bool isNumber1 = false;
            bool isNumber2 = false;
            bool isNumber3 = false;

            // sets flag for any empty TextBox
            isNumber1 = int.TryParse(textBox1.Text, out outputValue);
            isNumber2 = int.TryParse(textBox2.Text, out outputValue);
            isNumber3 = int.TryParse(textBox3.Text, out outputValue);

            if (!isNumber1 || !isNumber2 || !isNumber3)
            {   // performs if at least one of the textbox is empty
                MessageBox.Show("Type numbers in the text boxes.");
            }
            else
            {   // executes if all textboxes have data on it
                loopStart = int.Parse(textBox1.Text);
                loopEnd = int.Parse(textBox2.Text);

                // clears listBox
                listBox1.Items.Clear();

                for (int i = loopStart; i <= loopEnd; i++)
                {
                    answer = int.Parse(textBox3.Text) * i;
                    listBox1.Items.Add(i + " times " + textBox3.Text + " = " + answer.ToString());
                }
            }
        }
    }
}
