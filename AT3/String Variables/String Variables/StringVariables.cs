// Datoon, Philip Bryan B.
// 131311399
// 14 August 2013
// Using string variables in Windows form (pp 52-66)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Variables
{
    public partial class StringVariables : Form
    {
        public StringVariables()
        {
            InitializeComponent();
        }

        private void btnStrings_Click(object sender, EventArgs e)
        {
            string firstName;
            string messageText;

            messageText = "Your name is: ";

            firstName = textBox1.Text;

            // MessageBox.Show(messageText + firstName);

            TextMessage.Text = messageText + firstName;
            textBox2.Text = messageText + firstName;
        }
    }
}
