// Datoon, Philip Bryan B.
// 131311399
// 14 August 2013
// Using numeric variables in Windows form (pp 67-75)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Numbers : Form
    {
        public Numbers()
        {
            InitializeComponent();
        }

        private void btnIntegers_Click(object sender, EventArgs e)
        {
            int myInteger;

            myInteger = 25;

            // converts integer data type to string data type
            MessageBox.Show(myInteger.ToString());
        }

        private void btnFloat_Click(object sender, EventArgs e)
        {
            float myFloat;

            myFloat = 1234.5678F;

            // converts float data type to string data type
            MessageBox.Show(myFloat.ToString());
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            double myDouble;

            myDouble = 12345678.12345678;

            // converts double data type to string data type
            MessageBox.Show(myDouble.ToString());
        }
    }
}
