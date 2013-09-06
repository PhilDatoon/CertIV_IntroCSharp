// Datoon, Philip Bryan B.
// 131311399
// 14 August 2013
// Using message box in Windows form (pp 28-50)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My first message.", "Message", MessageBoxButtons.YesNo,
                MessageBoxIcon.Asterisk);
        }
    }
}
