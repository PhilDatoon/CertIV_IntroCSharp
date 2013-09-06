// Datoon, Philip Bryan B.
// 131311399
// 14 August 2013
// Creating calculator using Windows form (pp 98-117)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double total1 = 0;
        double total2 = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        // when number button is clicked, it's text displays in txtDisplay element
        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   // clears text
            txtDisplay.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {   // converts text field value then perform adding operation
            total1+= double.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {   // adds to values from the textbox and display result on the element
            total2 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {   // does not allow user to add multiple decimal points
            if (!txtDisplay.Text.Contains('.'))
                txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }
    }
}
