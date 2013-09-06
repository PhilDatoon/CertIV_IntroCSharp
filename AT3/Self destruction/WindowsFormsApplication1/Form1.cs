// Datoon, Philip Bryan B.
// 131311399
// 14 August 2013
// Using windows forms - countdown timer

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public bool goodbye = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelfDestruct_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Do you want to initiate the \nself destruction sequence?",
                "Self Destruction Initialisation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Self destruction activated.");
                goodbye = true;
            }

            else
            {
                MessageBox.Show("Destruction cancelled.");
                this.Close();
            } // end of IF-ELSE

            if (goodbye == true)
            {
                for (int x = 10; x >= 1; x--)
                {
                    txtFeedback.Text = x.ToString();
                    txtFeedback.Refresh();
                    Thread.Sleep(1000);
                }

                txtFeedback.Text = "Bye bye";
                txtFeedback.Refresh();
                Thread.Sleep(1000);
                this.Close();
            } // end of IF
        }
    }
}
