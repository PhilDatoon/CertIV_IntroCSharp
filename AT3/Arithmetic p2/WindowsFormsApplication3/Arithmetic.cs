// Datoon, Philip Bryan B.
// 131311399
// 16 August 2013
// Getting numbers from text boxes (pp 92-97)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Arithmetic : Form
    {
        public Arithmetic()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int secondTextBoxNumber;
            int thirdTextBoxNumber;
            int answer1;
            int answer2;
            int answer3;
            int answer4;
            
            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);
            secondTextBoxNumber = int.Parse(tbSecondNumber.Text);
            thirdTextBoxNumber = int.Parse(tbThirdNumber.Text);

            answer1 = (firstTextBoxNumber + secondTextBoxNumber) - thirdTextBoxNumber;
            answer2 = (firstTextBoxNumber - secondTextBoxNumber) * thirdTextBoxNumber;
            answer3 = firstTextBoxNumber * (secondTextBoxNumber - thirdTextBoxNumber);
            answer4 = (firstTextBoxNumber / secondTextBoxNumber) + thirdTextBoxNumber;

            MessageBox.Show(answer1.ToString() + "\n" +
                answer2.ToString() + "\n" +
                answer3.ToString() + "\n" +
                answer4.ToString());
        }
    }
}
